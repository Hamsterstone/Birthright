using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthright
{
    class GameInfo
    {
        Dictionary<string, int[]> terrainTypeDictionary = new Dictionary<string, int[]>();

        void PopulateTerrainDictionary()
        {
            terrainTypeDictionary.Add("Desert", new[] { 3, 1, 1 });
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

        //Lookup<string,string> 
        //TerrainKeyName(string),TerrainType(string),MaxPop(int),MoveCost(int),SourcePotential(int),
    }
}
