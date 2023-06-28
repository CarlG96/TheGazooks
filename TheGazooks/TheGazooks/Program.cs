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
            //gameBuilder.AddInputDirector();
            Game game = gameBuilder.BuildGame();

            game.Run();
        }
    }
}