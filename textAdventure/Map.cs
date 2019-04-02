using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kak
{
    class Map
    {
        char[,] tiles = new char[37, 36];
        string[,] ideologies = new string[37, 36];

        public Map()
        {
            string line;
            char[] tempArray = new char[37];
            StreamReader sr = new StreamReader("U:\\Software Development\\Projects\\Visual Studio\\kak\\startmap.txt");
            line = sr.ReadLine();
            int count = 0;
            while (line != null)
            {
                tempArray = line.ToCharArray();
                for (int i = 0; i < 36; i++)
                {
                    tiles[count, i] = tempArray[i];
                }

                count++;
                line = sr.ReadLine();
            }

            sr.Close();

            for (int i = 0; i < 37; i++)
            {
                for (int j = 0; j < 36; j++)
                {
                    switch(tiles[i, j])
                    {
                        case '#':
                            ideologies[i, j] = "fascism";
                            break;
                        case ';':
                            ideologies[i, j] = "democracy";
                            break;
                        case 'X':
                            ideologies[i, j] = "communism";
                            break;
                        case '?':
                            ideologies[i, j] = "unaligned";
                            break;
                    }
                }
            }
        }

        public override string ToString()
        {
            string ret = "\ta kak political game\n\n";
            ret += "_____________________________________\n";

            for (int i = 0; i < 37; i++)
            {
                ret += "|";

                for (int j = 0; j < 36; j++)
                {
                    ret += tiles[i, j];
                }

                ret += "|\n";
            }

            ret += "_____________________________________\n";

            return ret;
        }
    }
}
