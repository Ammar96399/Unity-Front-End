

public static class StatData
{
    private static string currentMap= "MapTestDylan.json";

    public static string getCurrent()
    {
        return currentMap;
    }

    public static void  setCurrent(string change)
    {
        currentMap = change;
    }
}
