using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TheLostAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriting write = new ConsoleWriting();
            Adventurer User = new Adventurer();
            write.Intro();
            
            
            //make sure to catch exceptions (try / catch / finally)
            string userName = Console.ReadLine();
            User.Name = userName;
            Console.WriteLine("\n");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine($"Okay, {User.Name} what is your class specialty? The following are your choices (Please input a number):");
            write.ClassList();
            //Console.WriteLine("1. Ranger");
            //Console.WriteLine("2. Tank");
            //Console.WriteLine("3. Warrior");
            //Console.WriteLine("4. Rouge");
            //Console.WriteLine("5. Mage");
            //Console.WriteLine("6. Healer");
            //Console.WriteLine("7. Monk");
            //Console.WriteLine("8. Druid");
            Console.WriteLine("========================================================================================================================");
            //make sure to catch exceptions (try / catch / finally) ("Thanks for not listening, we will chose a random class for you!") (edge cases they put in a word
            // or they put in an incorrect number.
            string userClass = Console.ReadLine();
            int classNumber = int.Parse(userClass.Substring(0, 1));
            User.Class = User.Classes[classNumber - 1];
            Console.WriteLine("\n");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine($"Ah, so you chose {User.Class}, what an exciting path you have chosen.");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\n");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine($"{User.Name}, what weapon(s) do you choose? (Please write a number): ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine(User.weaponsReturn(classNumber)[0]);
            Console.WriteLine(User.weaponsReturn(classNumber)[1]);
            Console.WriteLine("========================================================================================================================");
            //make sure to catch exceptions (try / catch / finally) (while loop, not returning) (try to only allow them to choose certain weapons based on their class)
            string userWeapon = Console.ReadLine();
            int weaponNumber = int.Parse(userWeapon.Substring(0));
            User.Weapon = User.weaponDict[weaponNumber];
            Console.WriteLine("\n");

            Console.WriteLine($"");
            List<string> storyLine = new List<string>()
            {
                $"In the verdant realm of Elysia, where magic and wonder intertwine, a young {User.Class} named {User.Name} embarked on a remarkable journey with their {User.Weapon} in tow. Armed with ancient knowledge passed down through generations, you set forth from her humble village, your heart brimming with compassion and a yearning to alleviate suffering. Guided by the ethereal whispers of nature, you, {User.Name} venture into uncharted lands, where mystical creatures roamed and the wounded cried out for solace. Your healing touch ignited a spark of hope in the darkest of hearts, and with each life she mended, you discovered that her destiny was intertwined with the very essence of healing the world itself.",

            };
            Console.WriteLine(storyLine[0].Substring(0, 116));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(storyLine[0].Substring(117, 109));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(storyLine[0].Substring(229, 110));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(storyLine[0].Substring(363, 120));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }







        //          \||/
        //          |  @___oo
        ///\   /\  / (__,,,,|
        //) /^\) ^\/ _)
        //)   /^\/   _)
        //\  /  /  / _)
        // \/  (  /    
        //  |  (  |
        //   \  \ |
        //    | || )
        //    | || |
        //    | || |
        //   _| || |_
        //  /\  || /\
        /// _ \.-./ _ \



        //Can you write me some pixel art drawings using any common symbols on a keyboard.Make sure each line is  max of  120 characters long and a min of 100 characters long. Base it on mythical characters such as a goblin or skeleton soldier.There is no maximum line length

        //          / \        
        //         /   \       
        //        /     \      
        //       /       \     
        //      /         \    
        //     /           \   
        //    /             \  
        //   /               \ 
        //  /                 \
        // /                   \
        ///_____________________\ 
        //||   ___ ___  ___    ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||  |   ||   ||   |  ||
        //||  |___||___||___|  ||
        //||___________________||
        //||___________________||



        //           / \       
        //          / _ \      
        //         / / \ \     
        //        / / _ \ \    
        //       / / / \ \ \   
        //      / / /_/_\ \ \  
        //     / /________\ \ 
        //    / /|        |\ \
        //   /_/ |        | \_\
        //      _|        |_
        //     / |        | \
        //    /  |        |  \
        //   /   |________|   \
        //  /    |        |    \
        // /     |        |     \
        //|      |________|      |
        //|      |        |      |
        // \     |        |     /
        //  \    |        |    /
        //   \   |________|   /
        //    \  |        |  /
        //     \_|        |_/
        //       |        |
        //       |        |
        //       |        |
        //       |________|

       
          //    .-.
          //   (o.o)
          //    |=|
          //   __|__
          // //.=|=.\\
          //// .=|=. \\
          //\\ .=|=. //
          // \\(_=_)//
          //  (:| |:)
          //   || ||
          //   () ()
          //   || ||
          //   || ||
          //  ==' '==
    } 

}
