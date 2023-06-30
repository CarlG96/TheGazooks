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

    public interface IMapLocationWithShop // TODO, is there a better way to handle the shop stuff
    {
        public void EnterShop();
    }

    public interface IMapLocationWithRandomEncounters // TODO, is there a better way to handle this sort of thing?
    {
        public void RandomEncounter();
    }

    public interface IImpassableLocation // TODO, there has to be a better way of handling this!!!! Also would need renaming
    {
        public void Block();
    }

    public class ForestLocation : IMapLocation, IMapLocationWithRandomEncounters
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

        public void RandomEncounter()
        {
            throw new NotImplementedException(); // TODO, not implemented
        }
    }

    public class MountainLocation : IMapLocation, IImpassableLocation
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

        public void Block()
        {
            throw new NotImplementedException(); // TODO, consider changing all of this
        }
    }

    public class SeaLocation : IMapLocation, IMapLocationWithRandomEncounters
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

        public void RandomEncounter()
        {
            throw new NotImplementedException(); //TODO, not implemented
        }
    }

    public class PlainsLocation : IMapLocation, IMapLocationWithRandomEncounters
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

        public void RandomEncounter()
        {
            throw new NotImplementedException(); //TODO, not implemented
        }
    }

    public class CityLocation : IMapLocation, IMapLocationWithShop
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

        public void EnterShop()
        {
            throw new NotImplementedException(); // TODO not implented yet but want it to be
        }
    }

    public class HillLocation : IMapLocation, IMapLocationWithRandomEncounters
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

        public void RandomEncounter()
        {
            throw new NotImplementedException(); //TODO, not implemented
        }
    }



}