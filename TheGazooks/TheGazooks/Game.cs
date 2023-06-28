using System.Net.Mail;

namespace TheGazooks
{
    public class Game
    {
        private GameMap _gameMap;
        public Game()
        {
            // TODO MainCharacter mainCharacter = new MainCharacter();
            _gameMap = new GameMap();
            // TODO InputHandler inputHandler = new InputHandler();
        }

        public void Run()
        {
            _gameMap.CreateMap(int sizeX, int sizeY);
            _gameMap.PrintMap();
        }
    }
}