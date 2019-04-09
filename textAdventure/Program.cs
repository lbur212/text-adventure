using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Story s = new Story();

            Console.WriteLine(m.mainMenu());
            m.mainMenuInput(Console.ReadLine());

            while(s.count != 9 && s.count != 8 && s.count != 7)
            {
                Console.Clear();
                Console.WriteLine(s.narrative());
                s.decisionInput(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine(s.narrative());
            Console.WriteLine("\n\nthanks for playing\n\nburger\n");
            Console.WriteLine("enter (r) to return to the menu");
            s.count = 1;
            m.mainMenuInput(Console.ReadLine());
        }
    }
}
