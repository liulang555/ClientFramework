public static class Extentions
{
    public static bool IsDestroyed(this UnityEngine.Object o) // 或者名字叫IsDestroyed等等
    {
        return o == null;
    }
}
