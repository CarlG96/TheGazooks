using System.Reflection.Metadata.Ecma335;

namespace TheGazooks
{
    public class Gazook
    {
        public enum GazookiType
        {
            WumbaJumba,
            FooglieWooglie,
            SlurpyMurpy
        }

        private string _gazoookiName;
        private int _gazookiLocationX;
        private int _gazookiLocationY;
        private GazookiType _gazookiType;
        public Gazook()
        {
            _gazoookiName = "The Main Gazook";
            _gazookiType = GazookiType.WumbaJumba; // TODO to be changed to something else at some point
            _gazookiLocationX = 5;
            _gazookiLocationY = 5;
        }

        public string GetName()
        {
            return "Your name is " + _gazoookiName;
        }

        public GazookiType GetGazookiType()
        {
            return _gazookiType;
        }

        public (int x, int y) GetGazookiLocation()
        {
            return (_gazookiLocationX, _gazookiLocationY);
        }
    }
}