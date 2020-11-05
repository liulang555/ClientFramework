using GameFramework;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityGameFramework.Editor.ResourceTools;
public sealed class BuildEventHandler : IBuildEventHandler
{
    /// <summary>
    /// 记录这次生成得版本数据
    /// </summary>
    /// <returns></returns>
    VersionInfo version = new VersionInfo();
    public string VersionPath 
    {
        get;set;
    }
    public bool ContinueOnFailure
    {
        get
        {
            return false;
        }
    }
    public void OnPreprocessAllPlatforms(string productName, string companyName, string gameIdentifier,
        string gameFrameworkVersion, string unityVersion, string applicableGameVersion, int internalResourceVersion, BuildAssetBundleOptions buildOptions, bool zip,
        string outputDirectory, string workingPath, bool outputPackageSelected, string outputPackagePath, bool outputFullSelected, string outputFullPath, bool outputPackedSelected, string outputPackedPath, string buildReportPath)
    {
        string streamingAssetsPath = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "StreamingAssets"));
        if (Directory.Exists(streamingAssetsPath))
        {
            string[] fileNames = Directory.GetFiles(streamingAssetsPath, "*", SearchOption.AllDirectories);
            foreach (string fileName in fileNames)
            {
                if (fileName.Contains(".gitkeep"))
                {
                    continue;
                }

                File.Delete(fileName);
            }

            Utility.Path.RemoveEmptyDirectory(streamingAssetsPath);
        }

        //记录版本信息
        version.InternalResourceVersion = internalResourceVersion;
    }

    public void OnPostprocessAllPlatforms(string productName, string companyName, string gameIdentifier,
        string gameFrameworkVersion, string unityVersion, string applicableGameVersion, int internalResourceVersion, BuildAssetBundleOptions buildOptions, bool zip,
        string outputDirectory, string workingPath, bool outputPackageSelected, string outputPackagePath, bool outputFullSelected, string outputFullPath, bool outputPackedSelected, string outputPackedPath, string buildReportPath)
    {
    }

    public void OnPreprocessPlatform(Platform platform, string workingPath, bool outputPackageSelected, string outputPackagePath, bool outputFullSelected, string outputFullPath, bool outputPackedSelected, string outputPackedPath)
    {
    }

    public void OnBuildAssetBundlesComplete(Platform platform, string workingPath, bool outputPackageSelected, string outputPackagePath, bool outputFullSelected, string outputFullPath, bool outputPackedSelected, string outputPackedPath, AssetBundleManifest assetBundleManifest)
    {

    }

    public void OnOutputUpdatableVersionListData(Platform platform, string versionListPath, int versionListLength, int versionListHashCode, int versionListZipLength, int versionListZipHashCode)
    {
        version.LatestGameVersion = Application.version;
        // Debug.Log("versionListPath: "+versionListPath);
        version.VersionListLength = versionListLength;
        version.VersionListHashCode = versionListHashCode;
        version.VersionListZipLength = versionListZipLength;
        version.VersionListZipHashCode = versionListZipHashCode;
    }

    public void OnPostprocessPlatform(Platform platform, string workingPath, bool outputPackageSelected, string outputPackagePath, bool outputFullSelected, string outputFullPath, bool outputPackedSelected, string outputPackedPath, bool isSuccess)
    {
        if (!outputPackageSelected)
        {
            return;
        }

        // if (platform != Platform.Windows)
        // {
        //     return;
        // }

        //生成version文件
        VersionPath = Application.dataPath.Replace("Assets","/Others/OutPut") +"/"+ GetPlatformPath(platform) + "Version.txt";
        version.UpdatePrefixUri = "file://"+ outputFullPath;
        Utility.Json.SetJsonHelper(new LitJsonHelper());
        string str = Utility.Json.ToJson(version);
        Debug.Log(str);
        if(File.Exists(VersionPath))
        {
            File.Delete(VersionPath);
        }
        StreamWriter sw = File.AppendText(VersionPath); //保存到指定路径
        sw.Write(str);
        sw.Flush();
        sw.Close();

        string streamingAssetsPath = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "StreamingAssets"));
        string[] fileNames = Directory.GetFiles(outputPackagePath, "*", SearchOption.AllDirectories);
        foreach (string fileName in fileNames)
        {
            string destFileName = Utility.Path.GetRegularPath(Path.Combine(streamingAssetsPath, fileName.Substring(outputPackagePath.Length)));
            FileInfo destFileInfo = new FileInfo(destFileName);
            if (!destFileInfo.Directory.Exists)
            {
                destFileInfo.Directory.Create();
            }

            File.Copy(fileName, destFileName);
        }
    }
     private static string GetPlatformPath(Platform platform)
        {
            switch (platform)
            {
                case Platform.Windows:
                case Platform.Windows64:
                case Platform.WindowsStore:
                    return "Windows";
                case Platform.MacOS:
                    return "MacOS";
                case Platform.IOS:
                    return "IOS";
                case Platform.Android:
                    return "Android";
                default:
                    throw new System.NotSupportedException(Utility.Text.Format("Platform '{0}' is not supported.", Application.platform.ToString()));
            }
        }
}