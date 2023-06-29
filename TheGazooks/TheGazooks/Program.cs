namespace TheGazooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfTiles = 10;
            Game game = new GameBuilder().AddIntro().SetMapSize(numOfTiles).AddMap().CreateGazook().AddInputHandler().BuildGame();
            game.Run();
        }
    }
}