public class GameData
{
    /// <summary>
    /// 游戏类型
    /// </summary>
    public static string GameType;
    public static bool IsChangeGameType { set; get; }
    static string PreGameType = string.Empty;

    public static void ChangeGameType(string gameType)
    {
        PreGameType = GameType;
        GameType = gameType;
        IsChangeGameType = true;
    }
}
