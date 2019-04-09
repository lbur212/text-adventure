using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textAdventure
{
    class Menu
    {
        public string mainMenu()
        {
            Console.Clear();

            string menu = "";
            string line;
            StreamReader sr = new StreamReader("C:\\Users\\lbur212\\Documents\\Visual Studio 2017\\Projects\\textAdventure\\textAdventure\\mainMenu.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                menu += line;
                menu += "\n";
                line = sr.ReadLine();
            }

            sr.Close();

            return menu;
        }

        public string optionsMenu()
        {
            Console.Clear();

            string menu = "";
            string line;
            StreamReader sr = new StreamReader("C:\\Users\\lbur212\\Documents\\Visual Studio 2017\\Projects\\textAdventure\\textAdventure\\optionsMenu.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                menu += line;
                menu += "\n";
                line = sr.ReadLine();
            }

            sr.Close();

            return menu;
        }

        public void mainMenuInput(string i)
        {
            switch (i)
            {
                case "p":
                    Console.Clear();
                    break;
                case "o":
                    Console.WriteLine(optionsMenu());
                    optionsMenuInput(Console.ReadLine());
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                case "r":
                    Console.WriteLine(mainMenu());
                    mainMenuInput(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine(mainMenu());
                    mainMenuInput(Console.ReadLine());
                    break;
            }
        }

        public void optionsMenuInput(string i)
        {
            switch (i)
            {
                case "b":
                    Console.WriteLine(mainMenu());
                    mainMenuInput(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine(optionsMenu());
                    optionsMenuInput(Console.ReadLine());
                    break;
            }
        }
    }
}
