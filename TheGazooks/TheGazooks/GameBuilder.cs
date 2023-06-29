namespace TheGazooks
{
    public class GameBuilder
    {
        private Game _game;
        private int _numOfTiles;
        private GameMap _gameMap;
        private Gazook _gazook;
        private InputHandler _inputHandler;
        private Intro _intro;
        public GameBuilder()
        {

        }

        public GameBuilder AddMap()
        {
            _gameMap = new GameMap(_numOfTiles);
            return this;
        }

        public GameBuilder SetMapSize(int numOfTiles)
        {
            this._numOfTiles = numOfTiles;
            return this;
        }

        public Game BuildGame()
        {
            _game = new Game(_gameMap, _gazook, _inputHandler, _intro);
            return _game;
        }

        public GameBuilder CreateGazook()
        {
            _gazook = new Gazook();
            return this;
        }

        public GameBuilder AddInputHandler()
        {
            _inputHandler = new InputHandler();
            return this;
        }

        public GameBuilder AddIntro()
        {
            _intro = new Intro();
            return this;
        }
    }
}