

public class TicTacPlayGrid
{
    public static char[,] playfield =
    {
        {'1','2','3'},
        {'4','5','6'},
        {'7','8','9'}
    };
    public static void PlayGrid()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2} ", playfield[0, 0], playfield[0, 1], playfield[0,2]);
        Console.WriteLine("-----|-----|-----");
        Console.WriteLine("  {0}  |  {1}  |  {2} ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
        Console.WriteLine("-----|-----|-----");
        Console.WriteLine("  {0}  |  {1}  |  {2} ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
        Console.WriteLine("     |     |     ");
    }

    


}
