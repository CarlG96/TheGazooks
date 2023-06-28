namespace TheGazooks
{
    public class GameBuilder
    {
        private Game _game;
        private int _numOfTiles;
        private GameMap _gameMap;
        private Gazook _gazook;
        public GameBuilder()
        {

        }

        public void AddMap()
        {
            _gameMap = new GameMap(_numOfTiles);
        }

        public void SetMapSize(int numOfTiles)
        {
            this._numOfTiles = numOfTiles;
        }

        public Game BuildGame()
        {
            _game = new Game(_gameMap, _gazook);
            return _game;
        }

        public void CreateGazook()
        {
            _gazook = new Gazook();
        }
    }
}