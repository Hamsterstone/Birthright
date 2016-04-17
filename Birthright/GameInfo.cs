using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthright
{
    class GameInfo
    {
        
       public  Dictionary<string, int[]> terrainTypeDictionary = new Dictionary<string, int[]>();
        
        public void PopulateTerrainDictionary()
        {
            terrainTypeDictionary.Add("Desert", new[] { 3, 1, 1 });        //TerrainKeyName(string),MaxPop(int),MoveCost(int),SourcePotential(int),
            terrainTypeDictionary.Add("ForestHeavy", new[] { 6, 2, 9 });
            terrainTypeDictionary.Add("ForestLight", new[] { 8, 1, 7 });
            terrainTypeDictionary.Add("Glacier", new[] { 1, 4, 9 });
            terrainTypeDictionary.Add("Hills", new[] { 9, 2, 5 });
            terrainTypeDictionary.Add("Marsh", new[] { 6, 2, 5 });
            terrainTypeDictionary.Add("MountainLow", new[] { 7, 2, 7 });
            terrainTypeDictionary.Add("MountainMed", new[] { 5, 3, 7 });
            terrainTypeDictionary.Add("MountainHigh", new[] { 3, 4, 9 });
            terrainTypeDictionary.Add("Moor", new[] { 6, 2, 5 });
            terrainTypeDictionary.Add("Plains", new[] { 10, 1, 5 });
            terrainTypeDictionary.Add("Steppe", new[] { 6, 1, 5 });
            terrainTypeDictionary.Add("Swamp", new[] { 6, 2, 8 });
            terrainTypeDictionary.Add("Tundra", new[] { 2, 2, 5 });
            terrainTypeDictionary.Add("River", new[] { 0, 0, 7 });
            terrainTypeDictionary.Add("Coast", new[] { 0, 0, 7 });


        }
        Dictionary<string, Dictionary<string,int>> terrainDictionary=new Dictionary<string, Dictionary<string, int>>();

        public class TerrainType
        {
            public string TerrainName { get; set; }
            public int MaxPop { get; set; }
            public int MoveCost { get; set; }
            public int SourcePotential { get; set; }
        }


        public Dictionary<string, TerrainType> Terrain = new Dictionary<string, TerrainType>()
        {
            {"Desert", new TerrainType {TerrainName="Desert", MaxPop = 3, MoveCost = 1, SourcePotential = 1}},
            {"ForestHeavy", new TerrainType {MaxPop = 6, MoveCost = 2, SourcePotential = 9}},
            {"ForestLight", new TerrainType {MaxPop = 8, MoveCost = 1, SourcePotential = 7}},
            {"Glacier", new TerrainType {MaxPop=1, MoveCost=4, SourcePotential=9}},
        { "Hills", new TerrainType {MaxPop=9,  MoveCost=2, SourcePotential=5}},
        { "Marsh", new TerrainType {MaxPop=6, MoveCost=2, SourcePotential=9}},
        { "MountainLow", new TerrainType {MaxPop=7, MoveCost=2, SourcePotential=7}},
        { "MountainMed", new TerrainType {MaxPop=5, MoveCost=3, SourcePotential=7}},
        { "MountainHigh", new TerrainType {MaxPop=3, MoveCost=4, SourcePotential=9}},
        { "Moor", new TerrainType {MaxPop=6, MoveCost=2, SourcePotential=5}},
        { "Plains", new TerrainType {MaxPop=10, MoveCost=1, SourcePotential=5}},
        { "Steppe", new TerrainType {MaxPop=6, MoveCost=1, SourcePotential=5}},
        { "Swamp", new TerrainType {MaxPop=6, MoveCost=2, SourcePotential=8}},
        { "Tundra", new TerrainType {MaxPop=2, MoveCost=2, SourcePotential=5}},
        { "River", new TerrainType {MaxPop=0, MoveCost=0, SourcePotential=7}},
        { "Coast", new TerrainType {MaxPop=0, MoveCost=0, SourcePotential=7}}

    };
        



        //Lookup<string,string> 
        //TerrainKeyName(string),TerrainType(string),MaxPop(int),MoveCost(int),SourcePotential(int),
    }
}
