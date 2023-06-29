using System.Net.Mail;
using System.Reflection;

namespace TheGazooks
{
    public class Game
    {
        private GameMap _gameMap;
        private Gazook _gazook;
        //private Intro _intro; TODO
        private InputHandler _inputHandler;
        public Game(GameMap gameMap, Gazook gazook)
        {
            //_intro; TODO
            _gameMap = gameMap;
            _gazook = gazook;
            _inputHandler = new InputHandler();
        }

        public void Run()
        {
            char playerMovementInput = '1';
            while (playerMovementInput != 'x') // THIS IS WEIRD AND THE MOVEMENT INPUT NEEDS TO BE CHANGED
            {
                Console.Clear();
                _gameMap.PrintMap(_gazook.GetGazookiLocationX(), _gazook.GetGazookiLocationY());
                CurrentLocation();
                playerMovementInput = _inputHandler.GetPlayerMovementInput(); // TODO method needs renaming
                if (_inputHandler.CheckInput(playerMovementInput))
                {
                    MoveLocation(playerMovementInput);    
                }
            }
        }

        private void MoveLocation(char input)
        {
            // THIS IS WEIRD BUT IT WORKS, ALSO NEED ERROR HANDLING FOR THE ARRAY STUFF
            switch (input)
            {
                case 'w':
                    _gazook.SetGazookiLocationX(_gazook.GetGazookiLocationX() - 1);
                    break;
                case 'd':
                    _gazook.SetGazookiLocationY(_gazook.GetGazookiLocationY() + 1);
                    break;
                case 's':
                    _gazook.SetGazookiLocationX(_gazook.GetGazookiLocationX() + 1);
                    break;
                case 'a':
                    _gazook.SetGazookiLocationY(_gazook.GetGazookiLocationY() - 1);
                    break;
                default:
                    throw new Exception("Char input was wrong!");

            }
        }

        private void CurrentLocation()
        {
            Console.WriteLine("You are at "  + _gameMap.MapLocations[_gazook.GetGazookiLocationX()][_gazook.GetGazookiLocationY()].LocationName);
            Console.WriteLine(_gameMap.MapLocations[_gazook.GetGazookiLocationX()][_gazook.GetGazookiLocationY()].LocationDescription); // The GetGazookiMethod is stupid here
            Console.WriteLine("To the north is: " + _gameMap.MapLocations[_gazook.GetGazookiLocationX()][_gazook.GetGazookiLocationY() -1].LocationDescription);
            Console.WriteLine("To the east is: " + _gameMap.MapLocations[_gazook.GetGazookiLocationX() + 1][_gazook.GetGazookiLocationY()].LocationDescription);
            Console.WriteLine("To the south is: " + _gameMap.MapLocations[_gazook.GetGazookiLocationX()][_gazook.GetGazookiLocationY() + 1].LocationDescription);
            Console.WriteLine("To the west is: " + _gameMap.MapLocations[_gazook.GetGazookiLocationX() - 1][_gazook.GetGazookiLocationY()].LocationDescription);
        }
    }
}