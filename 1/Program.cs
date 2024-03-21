public class HedgehogTest : HedgehogTestBase
{
    public static void Main(string[] args)
    {
        int[] hedgehogs = { 8, 1, 9 };
        int desiredColor = 0; // Red
        Console.WriteLine(MinEncounters(hedgehogs, desiredColor));
    }
}
