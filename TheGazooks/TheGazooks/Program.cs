namespace TheGazooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTiles = 10;
            GameBuilder gameBuilder = new GameBuilder();
            Game game = gameBuilder.AddMap();
            game.Run();
        }
    }
}