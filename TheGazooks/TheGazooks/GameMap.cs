using System.Runtime.CompilerServices;

namespace TheGazooks
{
    public class GameMap
    {
        
        private Random r = new Random();
        private IMapLocation[][] _mapLocations;
        public GameMap(int numOfTiles)
        {
            _mapLocations = new IMapLocation[numOfTiles][];
            for(int i = 0; i < numOfTiles; ++i)
            {
                _mapLocations[i] = new IMapLocation[numOfTiles];
                for(int j = 0; j < numOfTiles; ++j)
                {
                    // Sets the edge of the map to be mountains, mountains are impassible, therefore stopping the player getting off the map
                    if (i == 0 || j == 0 || i == numOfTiles - 1 || j == numOfTiles - 1)
                    {
                        _mapLocations[i][j] = new MountainLocation();
                        continue;
                    }
                    else
                    {
                        /* There are currently five possible types of location, in order to weight them we'll set them at different probabilities.
                         * 0,1,2 will be Plains, 3,4,5 will be Forest, 6 will be sea, 7,8 will be city and 9 will be hill
                         */
                        int randomNum = r.Next(10);
                        switch (randomNum)
                        {
                            case 0:
                                _mapLocations[i][j] = new PlainsLocation();
                                break;
                            case 1:
                                _mapLocations[i][j] = new PlainsLocation();
                                break;
                            case 2:
                                _mapLocations[i][j] = new PlainsLocation();
                                break;
                            case 3:
                                _mapLocations[i][j] = new ForestLocation();
                                break;
                            case 4:
                                _mapLocations[i][j] = new ForestLocation();
                                break;
                            case 5:
                                _mapLocations[i][j] = new ForestLocation();
                                break;
                            case 6:
                                _mapLocations[i][j] = new SeaLocation();
                                break;
                            case 7:
                                _mapLocations[i][j] = new CityLocation();
                                break;
                            case 8:
                                _mapLocations[i][j] = new CityLocation();
                                break;
                            case 9:
                                _mapLocations[i][j] = new HillLocation();
                                break;
                        }
                    }
                }
            }

        }

        public void PrintMap()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < _mapLocations.Length; ++i)
            {
                
                for (int j = 0; j < _mapLocations.Length; ++j)
                {

                    if (_mapLocations[i][j] is PlainsLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
                    else if (_mapLocations[i][j] is SeaLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
                    else if(_mapLocations[i][j] is ForestLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
                    else if(_mapLocations[i][j] is HillLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
                    else if(_mapLocations[i][j] is CityLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
                    else if(_mapLocations[i][j] is MountainLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(_mapLocations[i][j].Symbol);
                    }
   
                    Console.Write(_mapLocations[i][j].Symbol);
                    Console.Write(_mapLocations[i][j].Symbol);
                    
                    Console.Write(' ');
                    Thread.Sleep(5);
                }
                Console.Write('\n');
                
            }
        }
    }
}