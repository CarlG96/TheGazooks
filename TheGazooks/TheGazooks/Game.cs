using System.Net.Mail;

namespace TheGazooks
{
    public class Game
    {
        private GameMap _gameMap;
        public Game(int numOfTiles)
        {
            // TODO MainCharacter mainCharacter = new MainCharacter();
            _gameMap = new GameMap(numOfTiles);
            // TODO InputHandler inputHandler = new InputHandler();
        }

        public void Run()
        {
            
            _gameMap.PrintMap();
        }
    }
}