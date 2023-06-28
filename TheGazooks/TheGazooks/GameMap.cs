using System.Runtime.CompilerServices;

namespace TheGazooks
{
    public class GameMap
    {
        private char[][] _mapArrays;
        private Random r = new Random();
        public GameMap(int numOfTiles)
        {
            char[] potentialArray = new char[] { '0', '&', '4', '!' };
            _mapArrays = new char[numOfTiles][];
            for(int i = 0; i < numOfTiles; ++i)
            {
                _mapArrays[i] = new char[numOfTiles];
                for(int j = 0; j < numOfTiles; ++j)
                {
                    if (i == 0 || j == 0 || i == numOfTiles - 1 || j == numOfTiles - 1)
                    {
                        _mapArrays[i][j] = '^';
                        continue;
                    }
                    else
                    {
                        _mapArrays[i][j] = potentialArray[r.Next(4)];
                    }
                }
            }

        }

        public void PrintMap()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < _mapArrays.Length; ++i)
            {
                
                for (int j = 0; j < _mapArrays.Length; ++j)
                {

                    switch (_mapArrays[i][j])
                    {
                        case '0':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(_mapArrays[i][j]);
                            break;
                        case '&':
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(_mapArrays[i][j]);
                            break;
                        case '4':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(_mapArrays[i][j]);
                            break;
                        case '!':
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(_mapArrays[i][j]);
                            break;
                        case '^':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(_mapArrays[i][j]);
                            break;
                        default:
                            throw new Exception();


                            
                    }
                    Console.Write(_mapArrays[i][j]);
                    Console.Write(_mapArrays[i][j]);
                    
                    Console.Write(' ');
                }
                Console.Write('\n');
                
            }
        }
    }
}