﻿using System;
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

            Console.WriteLine(m.mainMenu());
            m.mainMenuInput(Console.ReadLine());
            
            Console.ReadKey();
        }
    }
}
