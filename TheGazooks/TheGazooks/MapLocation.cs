using System.Reflection.Metadata.Ecma335;

namespace TheGazooks
{
    public interface IMapLocation
    {
        public char Symbol { get;}
        public string LocationName { get;}
        public string LocationDescription { get; }
    }

    public class ForestLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public ForestLocation()
        {
            Symbol = '?';
        }
    }

    public class MountainLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public MountainLocation()
        {
            Symbol = '^';
        }
    }

    public class SeaLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public SeaLocation()
        {
            Symbol = '&';
        }
    }

    public class PlainsLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public PlainsLocation()
        {
            Symbol = '"';
        }
    }

    public class CityLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public CityLocation()
        {
            Symbol = '!';
        }
    }

    public class HillLocation : IMapLocation
    {
        public char Symbol { get; private set; }
        public string LocationName { get; private set; }
        public string LocationDescription { get; private set; }

        public HillLocation()
        {
            Symbol = '~';
        }
    }



}