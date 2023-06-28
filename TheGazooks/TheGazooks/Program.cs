namespace TheGazooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTiles = 25;
            Game game = new Game(numOfTiles);
            game.Run();
        }
    }
}