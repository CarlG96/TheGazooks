using GenerativeDictionaries.MapLocationDescriptions;
using GenerativeDictionaries.MapLocationNames;
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
            LocationName = "Forest";
            LocationDescription = "Beautiful Forest";
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
            LocationName = "Mountains";
            LocationDescription = "Beautiful Mountains";
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
            LocationName = "Sea";
            LocationDescription = "Beautiful Seas";
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
            LocationName = "Plains";
            LocationDescription = "Beautiful Plains";
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
            LocationName = CityNameDictionary.CityNames[1];  // TODO, change for randomisation
            LocationDescription = CityDescriptionDictionary.CityDescriptions[1]; //TODO, change for randomisation
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
            LocationName = "Hills";
            LocationDescription = "Beautiful Hills";
        }
    }



}