using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TheLostAdventure
{
    public class Adventurer
    {

        public List<string> Classes = new List<string>()
            {
                "Ranger",
                "Tank",
                "Warrior",
                "Rouge",
                "Mage",
                "Healer",
                "Monk",
                "Druid",
            };
        //public Dictionary<int,string> Classes = new Dictionary<int, string>()
        //    {
        //    {1, "Ranger"},
        //    {2,   "Tank" },
        //    {3 ,"Warrior"},
        //    {4,   "Rouge" },
        //    {5,   "Mage" },
        //    {6, "Healer" },
        //    { 7,  "Monk" },
        //    {8,   "Druid" }
        //    };
        public Dictionary<int, string> weaponDict = new Dictionary<int, string>()
        {
            {1, "Basic Short bow with arrows" },
            {2, "Basic Long bow with arrows" },
            {3, "Basic Sword and a basic shield" },
            {4, "Basic Hammer and basic heavy armor" },
            {5, "Basic Great sword" },
            {6, "Basic Axes (dual wield)" },
            {7, "Basic Daggers (dual wield)" },
            {8, "Basic Wrist-mounted crossbow" },
            {9, "Basic Staff" },
            {10, "Basic Wand and book" },
            {11, "Basic Healing staff" },
            {12, "Basic Tome and divine symbol" },
            {13, "Basic Martial arts gauntlets" },
            {14, "Basic Quarterstaff" },
            {15, "Basic Wooden staff" },
            {16, "Basic Sickle" },
            


        };
        
        public string Name { get; set; }
        public string Class { get; set; }
        public string Weapon { get; set; }
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Speed { get; set; } = 10;
        public int Magic { get; set; } = 10;
        public int Health { get; set; } = 10;

        public Adventurer() { }

        public List<string> weaponsReturn(int classNumber)
        {
            List<string> classWeapons = new List<string>();

            if (classNumber - 1 == 0)
            {
                classWeapons.Add($" 1. {weaponDict[1]}");
                classWeapons.Add($" 2. {weaponDict[2]}");

                return classWeapons;
            }
            if (classNumber - 1 == 1)
            {
                classWeapons.Add($" 3. {weaponDict[3]}");
                classWeapons.Add($" 4. {weaponDict[4]}");

                return classWeapons;
            }
            if (classNumber - 1 == 2)
            {
                classWeapons.Add($" 5. {weaponDict[5]}");
                classWeapons.Add($" 6. {weaponDict[6]}");

                return classWeapons;
            }
            if (classNumber - 1 == 3)
            {
                classWeapons.Add($" 7. {weaponDict[7]}");
                classWeapons.Add($" 8. {weaponDict[8]}");

                return classWeapons;
            }
            if (classNumber - 1 == 4)
            {
                classWeapons.Add($" 9. {weaponDict[9]}");
                classWeapons.Add($" 10. {weaponDict[10]}");

                return classWeapons;
            }
            if (classNumber - 1 == 5)
            {
                classWeapons.Add($" 11. {weaponDict[11]}");
                classWeapons.Add($" 12. {weaponDict[12]}");

                return classWeapons;
            }
            if (classNumber - 1 == 6)
            {
                classWeapons.Add($" 13. {weaponDict[13]}");
                classWeapons.Add($" 14. {weaponDict[14]}");

                return classWeapons;
            }
            if (classNumber - 1 == 7)
            {
                classWeapons.Add($" 15. {weaponDict[15]}");
                classWeapons.Add($" 16. {weaponDict[16]}");

                return classWeapons;
            }

            return classWeapons;

           
        }
    }
}
