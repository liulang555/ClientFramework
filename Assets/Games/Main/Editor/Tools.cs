using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;
using GameFramework;
using UnityEditorInternal;
using System;
using UnityEditor.SceneManagement;

public static class Tools
{
    [MenuItem("Tools/开始游戏", false, 1)]
    public static void StartGame()
    {
        if (EditorApplication.isPlaying) return;
        GeneratePreloadFileConfig();
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Games/Main/GameFramework.unity");
        EditorApplication.isPlaying = true;
    }

    [MenuItem("Tools/生成预加载配置", false, 2)]
    public static void GeneratePreloadFileConfig()
    {
        string OutputPackedPath = "Assets/Games/Main/Configs/";
        if (Directory.Exists(OutputPackedPath))
        {
            Directory.Delete(OutputPackedPath, true);
        }

        Directory.CreateDirectory(OutputPackedPath);
        string rootPath = Application.dataPath + "/Games/";
        List<string> filePathList = new List<string>();
        var gamePathes = Directory.GetDirectories(rootPath);
        string[] extantionFormats = { ".prefab", ".lua.txt", ".shader" };

        foreach (var gamePath in gamePathes)
        {
            StringBuilder sb = new StringBuilder();
            string fileConfigPath = OutputPackedPath + gamePath.Replace(rootPath, "") + ".txt";
            var filePathes = Directory.GetFiles(gamePath, "*.*", SearchOption.AllDirectories);
            foreach (var filePath in filePathes)
            {
                foreach (var extantionFormat in extantionFormats)
                {
                    if (filePath.EndsWith(extantionFormat))
                    {
                        sb.AppendLine(Utility.Path.GetRegularPath(filePath.Replace(rootPath, "")));
                    }
                }
            }
            if (!File.Exists(fileConfigPath))
            {
                File.Create(fileConfigPath).Close();
            }
            File.WriteAllText(fileConfigPath, sb.ToString());
        }
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/生成Lua配置表", false, 3)]
    public static void GenerateLuaDataTable()
    {
        string path = Application.dataPath.Replace("/Assets", "/Others/Excels/AntiVirus");
        ExecuteProgram("生成配置表工具.bat", path, string.Format("10"));
    }

    [MenuItem("Tools/清除GameSetting", false, 4)]
    public static void ClearAllCacth()
    {
        string path = Application.persistentDataPath + "/GameFrameworkSetting.dat";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    [MenuItem("Assets/生成textmesh pro字体文件，自动分隔图片并")]
    public static void AutomaticsSlice()
    {
        var textures = Selection.GetFiltered<Texture2D>(SelectionMode.Assets);
        List<string> texturesPath = new List<string>();
        foreach (var texture in textures)
        {
            texturesPath.Add(AssetDatabase.GetAssetPath(texture));
        }
        foreach (var texture in textures)
        {
            string path = AssetDatabase.GetAssetPath(texture);
            SetTextureSetting(path);  //需要先给图片设置格式，才能调用分割的方法
            ProcessTexture(path, true);
            Selection.objects = new UnityEngine.Object[] { AssetDatabase.LoadAssetAtPath(path, typeof(Texture2D)) };
            TMPro.EditorUtilities.TMP_SpriteAssetMenu.CreateSpriteAsset(); // 调用textmshpro 插件的生成字体方法
        }
    }

    [MenuItem("Assets/生成textmesh pro字体文件，根据文件名(行列)分隔图片并生成textmesh pro字体文件")]
    public static void GridSlice()
    {
        var textures = Selection.GetFiltered<Texture2D>(SelectionMode.Assets);
        List<string> texturesPath = new List<string>();
        foreach (var texture in textures)
        {
            texturesPath.Add(AssetDatabase.GetAssetPath(texture));
        }
        foreach (var path in texturesPath)
        {
            SetTextureSetting(path);  //需要先给图片设置格式，才能调用分割的方法
            ProcessTexture(path, false);
            Selection.objects = new UnityEngine.Object[] { AssetDatabase.LoadAssetAtPath(path, typeof(Texture2D)) };
            TMPro.EditorUtilities.TMP_SpriteAssetMenu.CreateSpriteAsset(); // 调用textmshpro 插件的生成字体方法
        }
    }

    /// <summary>
    /// 设置图片的格式配置
    /// </summary>
    /// <param name="path"></param>
    static void SetTextureSetting(string path)
    {
        var importer = AssetImporter.GetAtPath(path) as TextureImporter;
        importer.textureType = TextureImporterType.Sprite;
        importer.spriteImportMode = SpriteImportMode.Multiple;
        importer.mipmapEnabled = false;
        importer.filterMode = FilterMode.Point;
        importer.spritePivot = Vector2.down;
        importer.textureCompression = TextureImporterCompression.Uncompressed;

        var textureSettings = new TextureImporterSettings(); // need this stupid class because spriteExtrude and spriteMeshType aren't exposed on TextureImporter
        importer.ReadTextureSettings(textureSettings);
        textureSettings.spriteMeshType = SpriteMeshType.Tight;
        textureSettings.spriteExtrude = 0;
        importer.SetTextureSettings(textureSettings);

        EditorUtility.SetDirty(importer);
        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
        AssetDatabase.Refresh();
    }

    static void ProcessTexture(string path, bool isAutomatics)
    {
        Rect[] rects = null;
        Texture2D texture = AssetDatabase.LoadAssetAtPath(path, typeof(Texture2D)) as Texture2D;
        if (isAutomatics)
        {
            int minimumSpriteSize = 16;
            int extrudeSize = 0;
            rects = InternalSpriteUtility.GenerateAutomaticSpriteRectangles(texture, minimumSpriteSize, extrudeSize);
        }
        else
        {
            string[] str = texture.name.Split('_');
            int widthNum = int.Parse(str[str.Length - 2]);
            int hrightNum = int.Parse(str[str.Length - 1]);
            Vector2 size = new Vector2();
            size.x = (float)texture.width / widthNum;
            size.y = (float)texture.height / hrightNum;
            rects = InternalSpriteUtility.GenerateGridSpriteRectangles(texture, Vector2.zero, size, Vector2.zero);
        }

        var rectsList = new List<Rect>(rects);
        rectsList = SortRects(rectsList, texture.width);

        string filenameNoExtension = Path.GetFileNameWithoutExtension(path);
        var metas = new List<SpriteMetaData>();
        int rectNum = 0;

        foreach (Rect rect in rectsList)
        {
            var meta = new SpriteMetaData();
            meta.pivot = Vector2.down;
            meta.alignment = (int)SpriteAlignment.BottomCenter;
            meta.rect = rect;
            meta.name = filenameNoExtension + "_" + rectNum++;
            metas.Add(meta);
        }

        var importer = AssetImporter.GetAtPath(path) as TextureImporter;
        importer.spritesheet = metas.ToArray();
        EditorUtility.SetDirty(importer);
        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
        AssetDatabase.Refresh();
    }
    static List<Rect> SortRects(List<Rect> rects, float textureWidth)
    {
        List<Rect> list = new List<Rect>();
        while (rects.Count > 0)
        {
            Rect rect = rects[rects.Count - 1];
            Rect sweepRect = new Rect(0f, rect.yMin, textureWidth, rect.height);
            List<Rect> list2 = RectSweep(rects, sweepRect);
            if (list2.Count <= 0)
            {
                list.AddRange(rects);
                break;
            }
            list.AddRange(list2);
        }
        return list;
    }

    static List<Rect> RectSweep(List<Rect> rects, Rect sweepRect)
    {
        List<Rect> result;
        if (rects == null || rects.Count == 0)
        {
            result = new List<Rect>();
        }
        else
        {
            List<Rect> list = new List<Rect>();
            foreach (Rect current in rects)
            {
                if (current.Overlaps(sweepRect))
                {
                    list.Add(current);
                }
            }
            foreach (Rect current2 in list)
            {
                rects.Remove(current2);
            }
            list.Sort((a, b) => a.x.CompareTo(b.x));
            result = list;
        }
        return result;
    }

    /// <summary>
    /// 收集指定目录下指定后缀名的所有文件
    /// </summary>
    public static void CollectFilesWithSuffix(string rootPath, string suffix, ref List<string> fileList)
    {
        Directory.GetFiles("", "*.*", SearchOption.AllDirectories);

        string[] dirs = Directory.GetDirectories(rootPath);
        foreach (string path in dirs)
        {
            CollectFilesWithSuffix(path, suffix, ref fileList);
        }

        string[] files = Directory.GetFiles(rootPath);
        foreach (string filePath in files)
        {
            if (filePath.Contains(".") && filePath.Substring(filePath.IndexOf(".")) == suffix)
            {
                fileList.Add(filePath);
            }
        }
    }

    /// <summary>
    /// 调用bat文件
    /// </summary>
    public static void ExecuteProgram(string exeFilename, string workDir, string args)
    {
        System.Diagnostics.Process proc = null;
        try
        {
            proc = new System.Diagnostics.Process();
            proc.StartInfo.WorkingDirectory = workDir;
            proc.StartInfo.FileName = exeFilename;
            proc.StartInfo.Arguments = args;//this is argument
            //proc.StartInfo.CreateNoWindow = true;
            //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//这里设置DOS窗口不显示，经实践可行
            proc.Start();
            proc.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
        }
    }
}

