using System.Net.Mail;

namespace TheGazooks
{
    public class Game
    {
        private GameMap _gameMap;
        private Gazook _gazook;
        public Game(GameMap gameMap, Gazook gazook)
        {
            // TODO MainCharacter mainCharacter = new MainCharacter();
            _gameMap = gameMap;
            _gazook = gazook;
            // TODO InputHandler inputHandler = new InputHandler();
        }

        public void Run()
        {
            _gameMap.PrintMap(_gazook.GetGazookiLocation().x, _gazook.GetGazookiLocation().y);
            Console.WriteLine(_gazook.GetName());
            Console.WriteLine(_gazook.GetGazookiType());
            CurrentLocation();
        }

        private void CurrentLocation()
        {
            Console.WriteLine("You are at "  + _gameMap.MapLocations[_gazook.GetGazookiLocation().x][_gazook.GetGazookiLocation().y].LocationName);
            Console.WriteLine(_gameMap.MapLocations[_gazook.GetGazookiLocation().x][_gazook.GetGazookiLocation().y].LocationDescription); // The GetGazookiMethod is stupid here
            
        }
    }
}