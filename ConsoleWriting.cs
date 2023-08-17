using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TheLostAdventure
{
    //Make it an interface
    public class ConsoleWriting : Adventurer
    {
        public void Intro()
        {
            Console.WriteLine("Ahoy, brave adventurer! May your path be strewn with wonder and excitement,");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("and may your footsteps echo through uncharted realms. As you set sail into the great unknown,");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("may the wind guide your sails and the stars illuminate your way. May every challenge you face ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("be but a stepping stone to greater heights, and may every sunset witnessed be a");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("testament to your indomitable spirit. Embrace the thrill of the journey, for you");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("are the embodiment of courage and curiosity. Bon voyage, intrepid explorer, ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("and may your tales inspire the hearts of many as you leave footprints in the annals of adventure!");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please press Enter when you are done reading.");
            Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("So brave adventurer, what is your name?");
            Console.WriteLine("========================================================================================================================");
           
        }
        public void ClassList()
        {
            Console.WriteLine("1. Ranger");
            Console.WriteLine("2. Tank");
            Console.WriteLine("3. Warrior");
            Console.WriteLine("4. Rouge");
            Console.WriteLine("5. Mage");
            Console.WriteLine("6. Healer");
            Console.WriteLine("7. Monk");
            Console.WriteLine("8. Druid");
        }
        //public string ReadUserName(string userName)
        //{
        //    return User.Name = userName;
        //}

    }
}
