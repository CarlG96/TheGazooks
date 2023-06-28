using System.Runtime.CompilerServices;

namespace TheGazooks
{
    public class GameMap
    {
        
        private Random r = new Random();
        public IMapLocation[][] MapLocations;
        public GameMap(int numOfTiles)
        {
            MapLocations = new IMapLocation[numOfTiles][];
            for(int i = 0; i < numOfTiles; ++i)
            {
                MapLocations[i] = new IMapLocation[numOfTiles];
                for(int j = 0; j < numOfTiles; ++j)
                {
                    // Sets the edge of the map to be mountains, mountains are impassible, therefore stopping the player getting off the map
                    if (i == 0 || j == 0 || i == numOfTiles - 1 || j == numOfTiles - 1)
                    {
                        MapLocations[i][j] = new MountainLocation();
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
                                MapLocations[i][j] = new PlainsLocation();
                                break;
                            case 1:
                                MapLocations[i][j] = new PlainsLocation();
                                break;
                            case 2:
                                MapLocations[i][j] = new PlainsLocation();
                                break;
                            case 3:
                                MapLocations[i][j] = new ForestLocation();
                                break;
                            case 4:
                                MapLocations[i][j] = new ForestLocation();
                                break;
                            case 5:
                                MapLocations[i][j] = new ForestLocation();
                                break;
                            case 6:
                                MapLocations[i][j] = new SeaLocation();
                                break;
                            case 7:
                                MapLocations[i][j] = new CityLocation();
                                break;
                            case 8:
                                MapLocations[i][j] = new CityLocation();
                                break;
                            case 9:
                                MapLocations[i][j] = new HillLocation();
                                break;
                        }
                    }
                }
            }

        }

        public void PrintMap()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < MapLocations.Length; ++i)
            {
                
                for (int j = 0; j < MapLocations.Length; ++j)
                {

                    if (MapLocations[i][j] is PlainsLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
                    else if (MapLocations[i][j] is SeaLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
                    else if(MapLocations[i][j] is ForestLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
                    else if(MapLocations[i][j] is HillLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
                    else if(MapLocations[i][j] is CityLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
                    else if(MapLocations[i][j] is MountainLocation)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(MapLocations[i][j].Symbol);
                    }
   
                    Console.Write(MapLocations[i][j].Symbol);
                    Console.Write(MapLocations[i][j].Symbol);
                    
                    Console.Write(' ');
                    Thread.Sleep(5);
                }
                Console.Write('\n');
                
            }
        }
    }
}