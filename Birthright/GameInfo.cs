using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Birthright
{
    class GameInfo
    {

        public static readonly string[] HoldingTypes = {"Law",  "Temple","Guild", "Source"};

        public class TerrainType
        {
            public string TerrainName { get; set; }
            public int MaxPop { get; set; }
            public int MoveCost { get; set; }
            public int SourcePotential { get; set; }
        }

        public static readonly Dictionary<string, TerrainType> Terrain = new Dictionary<string, TerrainType>()
        {
            {"Desert", new TerrainType {TerrainName = "Desert", MaxPop = 3, MoveCost = 1, SourcePotential = 1}},
            {"ForestHeavy",new TerrainType {TerrainName = "Heavy Forest", MaxPop = 6, MoveCost = 2, SourcePotential = 9}},
            {"ForestLight",new TerrainType {TerrainName = "Light Forest", MaxPop = 8, MoveCost = 1, SourcePotential = 7}},
            {"Glacier", new TerrainType {TerrainName = "Glacier", MaxPop = 1, MoveCost = 4, SourcePotential = 9}},
            {"Hills", new TerrainType {TerrainName = "Hills", MaxPop = 9, MoveCost = 2, SourcePotential = 5}},
            {"Marsh", new TerrainType {TerrainName = "Marsh", MaxPop = 6, MoveCost = 2, SourcePotential = 9}},
            {"MountainLow",new TerrainType {TerrainName = "Low Mountains", MaxPop = 7, MoveCost = 2, SourcePotential = 7}},
            {"MountainMed",new TerrainType {TerrainName = "Medium Mountains", MaxPop = 5, MoveCost = 3, SourcePotential = 7}},
            {"MountainHigh",new TerrainType {TerrainName = "High Mountains", MaxPop = 3, MoveCost = 4, SourcePotential = 9}},
            {"Moor", new TerrainType {TerrainName = "Moor", MaxPop = 6, MoveCost = 2, SourcePotential = 5}},
            {"Plains", new TerrainType {TerrainName = "Plains", MaxPop = 10, MoveCost = 1, SourcePotential = 5}},
            {"Steppe", new TerrainType {TerrainName = "Steppe", MaxPop = 6, MoveCost = 1, SourcePotential = 5}},
            {"Swamp", new TerrainType {TerrainName = "Swamp", MaxPop = 6, MoveCost = 2, SourcePotential = 8}},
            {"Tundra", new TerrainType {TerrainName = "Tundra", MaxPop = 2, MoveCost = 2, SourcePotential = 5}},
            {"River", new TerrainType {TerrainName = "River", MaxPop = 0, MoveCost = 0, SourcePotential = 7}},
            {"Coast", new TerrainType {TerrainName = "Coast", MaxPop = 0, MoveCost = 0, SourcePotential = 7}}
        };


        
        public static BiDictionary<int, string> RulerIdToNameBiDictionary=new BiDictionary<int, string>();
        public static BiDictionary<int, string> RulerIdToAbbrBiDictionary = new BiDictionary<int, string>();
        public static BiDictionary<int, string> RealmIdToNameBiDictionary = new BiDictionary<int, string>();
        public static BiDictionary<int, string> ProvinceIdToNameBiDictionary = new BiDictionary<int, string>();
        public static BiDictionary<int, string> RealmIdVsRulerAbbrBiDictionary = new BiDictionary<int, string>();
        public static int ConvertToIDNumber(string field, string lookup)
        {
            try
            {
                switch (lookup)
                {
                    case "RulerName":
                        return RulerIdToNameBiDictionary.GetBySecond(field);
                    case "RulerAbbr":
                        return RulerIdToAbbrBiDictionary.GetBySecond(field);
                    case "RealmName":
                        return RealmIdToNameBiDictionary.GetBySecond(field);
                    case "ProvinceName":
                        return ProvinceIdToNameBiDictionary.GetBySecond(field);
                    case "RealmIDVsRulerAbbr":
                        return RealmIdVsRulerAbbrBiDictionary.GetBySecond(field);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public static string ConvertFromIDNumber(int field, string lookup)
        {
            try
            {
                switch (lookup)
                {
                    case "RulerName":
                        return RulerIdToNameBiDictionary.GetByFirst(field);
                    case "RulerAbbr":
                        return RulerIdToAbbrBiDictionary.GetByFirst(field);
                    case "RealmName":
                        return RealmIdToNameBiDictionary.GetByFirst(field);
                    case "ProvinceName":
                        return ProvinceIdToNameBiDictionary.GetByFirst(field);
                    case "RealmIDVsRulerAbbr":
                        return RealmIdVsRulerAbbrBiDictionary.GetByFirst(field);
                }
                return "";
            }
            catch
            {
                return "";
            }
        }
        public static string TerrainNameCorrector(string name)
        {
            if (name != "")
            {

                foreach (KeyValuePair<string, TerrainType> pair in Terrain)
                {
                    if (name == pair.Value.TerrainName) return pair.Key;
                }
                return "TerrainNameCorrector FAILED!";
            }
            return String.Empty;
        }

        public static string SecondaryTerrainNameCorrector(string name)
        {
            if (name != "")
            {
                string returnString = null;
                List<string> names = name.Split(',').Select(p => p.Trim()).ToList();
                for (int i = 0; i < names.Count; i++)
                {
                    names[i] = TerrainNameCorrector(names[i]);
                }
                returnString = String.Join(", ", names);
                return returnString;
            }
            return String.Empty;

        }
    }
}
