using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_PRG2
{
    class Program
    {
        
            static void Main(string[] args)
            {
                String[] names = new String[10];


                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Enter a word");
                    names[i] = Console.ReadLine();
                    Console.WriteLine("                              ");
                }

                Array.Sort(names, StringComparer.InvariantCultureIgnoreCase);

                for (int j = 0; j < names.Length; j++)
                {
                    Console.WriteLine("                              ");
                    Console.WriteLine("\t" + j + "." + names[j]);
                }


                Console.WriteLine("                              ");
                Console.WriteLine("Enter in a word from the list of words to see the number of each type of Vowel");
                int count_a = 0, count_e = 0, count_i = 0, count_o = 0, count_u = 0;
                Char[] word = Console.ReadLine().ToCharArray();
                for (int x = 0; x < word.Length; x++)
                {
                    if (word[x].Equals('a') || word[x].Equals('A'))
                    {
                        count_a++;
                    }
                    else if (word[x].Equals('e') || word[x].Equals('E'))
                    {
                        count_e++;
                    }
                    else if (word[x].Equals('i') || word[x].Equals('I'))
                    {
                        count_i++;
                    }
                    else if (word[x].Equals('o') || word[x].Equals('O'))
                    {
                        count_o++;
                    }
                    else if (word[x].Equals('u') || word[x].Equals('U'))
                    {
                        count_u++;
                    }
                }
                Console.WriteLine("                  ");
                Console.WriteLine("a :" + count_a);
                Console.WriteLine("e :" + count_e);
                Console.WriteLine("i :" + count_i);
                Console.WriteLine("o :" + count_o);
                Console.WriteLine("u :" + count_u);
                Console.ReadLine();
            }
        }
    }

