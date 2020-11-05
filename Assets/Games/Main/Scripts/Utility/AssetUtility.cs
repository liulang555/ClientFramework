
/// <summary>
/// 资源路径工具类
/// </summary>
public static class AssetUtility
{
    /// <summary>
    /// 场景资源
    /// </summary>
    /// <param name="assetName">资源名</param>
    /// <returns></returns>
    public static string GetSceneAssetPath(string assetName, string gameType = "Main")
    {
        return string.Format("Assets/Games/{0}/{1}.unity", gameType, assetName);
    }

    /// <summary>
    /// 界面预制体
    /// </summary>
    /// <param name="assetName"></param>
    /// <returns></returns>
    public static string GetUIFormAssetPath(string assetName, string gameType)
    {
        return string.Format("Assets/Games/{0}/UI/UIForms/{1}.prefab", gameType, assetName);
    }

    /// <summary>
    /// Lua列表文件
    /// </summary>
    /// <returns></returns>
    public static string GetPreloadFileConfig(string gameType)
    {
        return string.Format("Assets/Games/Main/Configs/{0}.txt", gameType);
    }

    /// <summary>
    /// Lua资源
    /// </summary>
    /// <param name="assetName">资源名</param>
    /// <returns></returns>
    public static string GetLuaAssetPath(string luaName, string gameType)
    {
        return string.Format("Assets/Games/{0}/LuaScripts/{1}.lua.txt", gameType, luaName);
    }

    /// <summary>
    /// 通过Entity路径，获取对应脚本路径
    /// </summary>
    /// <param name="entityAssetName"></param>
    /// <returns></returns>
    public static string GetLuaAssetPathForEntity(string entityAssetName)
    {
        return entityAssetName.Replace("Entity/", "LuaScripts/Entity/").Replace(".prefab", ".lua.txt");
    }

    /// <summary>
    /// 通过Entity路径，获取对应脚本路径
    /// </summary>
    /// <param name="uiFormAssetName"></param>
    /// <returns></returns>
    public static string GetLuaAssetPathForUIForm(string uiFormAssetName)
    {
        return uiFormAssetName.Replace("UI/UIForms/", "LuaScripts/UIForms/").Replace(".prefab", ".lua.txt");
    }
}
