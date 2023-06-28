namespace TheGazooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTiles = 10;
            GameBuilder gameBuilder = new GameBuilder();
            gameBuilder.SetMapSize(numOfTiles); 
            gameBuilder.AddMap();
            gameBuilder.CreateGazook();
            Game game = gameBuilder.BuildGame();

            game.Run();
        }
    }
}