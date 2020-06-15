using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootProfiler
{
    public static class FileOps
    {
        public static LootProfile OpenFile(string filepath)
        {
            // Opens sql file
            var profileData = new LootProfile();

            //var lines = File.ReadLines(fileName);
            //foreach (var line in lines)
            //    // Process line


            foreach (string line in File.ReadLines(filepath))
            {
                if (line.Contains("VALUE"))
                {
                    string linedata = "";
                    linedata = line.Replace("VALUES", "");
                    linedata = linedata.Replace("(", "");
                    linedata = linedata.Replace(");", "");
                    linedata = linedata.Replace("'", "");
                    string[] lootProfileValues = linedata.Split(',');
                    profileData.DTdid = ConvertToInt(lootProfileValues[0]);
                    profileData.Tier = ConvertToInt(lootProfileValues[1]);
                    profileData.LootQualityMod = float.Parse(lootProfileValues[2]);
                    profileData.UnknownChances = ConvertToInt(lootProfileValues[3]);
                    profileData.ItemChance = ConvertToInt(lootProfileValues[4]);
                    profileData.ItemMinAmount = ConvertToInt(lootProfileValues[5]);
                    profileData.ItemMaxAmount = ConvertToInt(lootProfileValues[6]);
                    profileData.ItemTreasureTypeSelectionChances = ConvertToInt(lootProfileValues[7]);
                    profileData.MagicItemChance = ConvertToInt(lootProfileValues[8]);
                    profileData.MagicItemMinAmount = ConvertToInt(lootProfileValues[9]);
                    profileData.MagicItemMaxAmount = ConvertToInt(lootProfileValues[10]);
                    profileData.MagicItemTreasureTypeSelectionChances = ConvertToInt(lootProfileValues[11]);
                    profileData.MundaneItemChance = ConvertToInt(lootProfileValues[12]);
                    profileData.MundaneItemMinAmount = ConvertToInt(lootProfileValues[13]);
                    profileData.MundaneItemMaxAmount = ConvertToInt(lootProfileValues[14]);
                    profileData.MundaneItemTreasureTypeSelectionChances = ConvertToInt(lootProfileValues[15]);
                    profileData.LastModified = lootProfileValues[16];                    
                    //string[] tokens = str.Split(',');
                }
            }


            return profileData;
        }

        public static void SaveFile(LootProfile filedata, string myfilename)
        {
            // Saves sql file

            string header = $"DELETE FROM `treasure_death` WHERE `treasure_Type` = {filedata.DTdid}; \n\n" +
                            "INSERT INTO `treasure_death` (`treasure_Type`, `tier`, `loot_Quality_Mod`, `unknown_Chances`, `item_Chance`, `item_Min_Amount`, `item_Max_Amount`, `item_Treasure_Type_Selection_Chances`, `magic_Item_Chance`, `magic_Item_Min_Amount`, `magic_Item_Max_Amount`, `magic_Item_Treasure_Type_Selection_Chances`, `mundane_Item_Chance`, `mundane_Item_Min_Amount`, `mundane_Item_Max_Amount`, `mundane_Item_Type_Selection_Chances`, `last_Modified`)\n";

            string dateModified = string.Format("{0:MM-dd-yyyy H:hh-mm-sst}", DateTime.Now);

            string dtData = $"VALUES ({filedata.DTdid}, {filedata.Tier}, {filedata.LootQualityMod}, {filedata.UnknownChances}, " +
                            $"{filedata.ItemChance}, {filedata.ItemMinAmount}, {filedata.ItemMaxAmount}, {filedata.ItemTreasureTypeSelectionChances}, " +
                            $"{filedata.MagicItemChance}, {filedata.MagicItemMinAmount}, {filedata.MagicItemMaxAmount}, {filedata.MagicItemTreasureTypeSelectionChances}, " +
                            $"{filedata.MundaneItemChance}, {filedata.MundaneItemMinAmount}, {filedata.MundaneItemMaxAmount}, {filedata.MundaneItemTreasureTypeSelectionChances}, " + dateModified;

            File.WriteAllText(myfilename, header + dtData);



        }

        private static int ConvertToInt(string Convert)
        {
            int val = 0;
            Int32.TryParse(Convert, out val);

            return val;

        }

    }
}
