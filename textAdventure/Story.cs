using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textAdventure
{
    class Story
    {
        public int count = 1;

        string[] word = new string[9];

        public Story()
        {
            for (int i = 0; i < 9; i++)
            {
                int fileName = i + 1;
                string line;
                StreamReader sr = new StreamReader($"C:\\Users\\lbur212\\Documents\\Visual Studio 2017\\Projects\\textAdventure\\textAdventure\\{fileName}.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    word[i] += line;
                    word[i] += "\n";
                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }

        public string narrative()
        {
            switch (count)
            {
                case 1:
                    return word[0];
                case 2:
                    return word[1];
                case 3:
                    return word[2];
                case 4:
                    return word[3];
                case 5:
                    return word[4];
                case 6:
                    return word[5];
                case 7:
                    return word[6];
                case 8:
                    return word[7];
                case 9:
                    return word[8];
                default:
                    return "";
            }
        }

        public void decisionInput(string i)
        {
            switch (i)
            {
                case "fight":
                    if (count == 6)
                    {
                        count = 8;
                    }
                    if (count == 2)
                    {
                        count = 4;
                    }
                    break;
                case "flight":
                    if (count == 6)
                    {
                        count = 9;
                    }
                    if (count == 5)
                    {
                        count = 6;
                    }
                    if (count == 2)
                    {
                        count = 3;
                    }
                    break;
                case "":
                    break;
                default:
                    if (count == 5)
                    {
                        count = 7;
                    }
                    if (count == 4)
                    {
                        count = 6;
                    }
                    if (count == 3)
                    {
                        count = 5;
                    }
                    if (count == 1)
                    {
                        count++;
                    }
                    break;
            }
        }
    }
}
