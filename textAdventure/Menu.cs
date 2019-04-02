using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kak
{
    class Menu
    {
        public string mainMenu()
        {
            Console.Clear();

            string menu = "";
            string line;
            StreamReader sr = new StreamReader("U:\\Software Development\\Projects\\Visual Studio\\kak\\mainmenu.txt");
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
            StreamReader sr = new StreamReader("U:\\Software Development\\Projects\\Visual Studio\\kak\\optionsmenu.txt");
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

        public void mainMenuInput(string i, Map t)
        {
            switch (i)
            {
                case "p":
                    Console.Clear();
                    Console.WriteLine(t);
                    break;
                case "o":
                    Console.WriteLine(optionsMenu());
                    optionsMenuInput(Console.ReadLine(), t);
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(mainMenu());
                    break;
            }
        }

        public void optionsMenuInput(string i, Map t)
        {
            switch (i)
            {
                case "b":
                    Console.WriteLine(mainMenu());
                    mainMenuInput(Console.ReadLine(), t);
                    break;
                default:
                    Console.WriteLine(optionsMenu());
                    break;
            }
        }
    }
}
