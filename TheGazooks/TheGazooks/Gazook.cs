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

        private string _name;
        private GazookiType _gazookiType;
        public Gazook()
        {
            _name = "The Main Gazook";
            _gazookiType = GazookiType.WumbaJumba; // TODO to be changed to something else at some point
        }

        public string GetName()
        {
            return "Your name is " + _name;
        }

        public GazookiType GetGazookiType()
        {
            return _gazookiType;
        }
    }
}