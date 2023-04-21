using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chars = { {'A','B','C','D','E'}, { 'F', 'G', 'H', 'I', 'K' }, {'L', 'M', 'N', 'O', 'P' }, {'Q', 'R', 'S', 'T', 'U' }, {'V', 'W', 'X', 'Y', 'Z' } };
            char[] write = new char[50];
            string s = "";
            bool breac = false;
            m1: Console.WriteLine("Введите сообщение на английском капсом");
            s = Console.ReadLine();
            if (s.Length <= 50)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    write[i] = s[i];
                }
            }
            else
            { 
                Console.WriteLine("Максимум 50 символов");
                goto m1;
            }
            for (int i = 0; i < 50; i++)
            {      
                for (int j = 0; j < 5; j++)
                {
                    if (breac)
                    {
                        breac = false;
                        break;
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        if (write[i] == chars[j, k])
                        {
                            if (j == 4)
                            {
                                write[i] = chars[j - 1, k];
                                breac = true;

                            }
                            else
                            {
                                write[i] = chars[j + 1, k];
                                breac = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(write);
            Console.ReadLine();
            Console.WriteLine(" Дешифровка ");
            s = Console.ReadLine();
            if (s.Length <= 50)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    write[i] = s[i];
                }
            }
            else
            {
                Console.WriteLine("Максимум 50 символов");
                goto m1;
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (breac)
                    {
                        breac = false;
                        break;
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        if (write[i] == chars[j, k])
                        {
                            if (j == 4)
                            {
                                write[i] = chars[j + 1, k];
                                breac = true;

                            }
                            else
                            {
                                write[i] = chars[j - 1, k];
                                breac = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(write);
            Console.ReadLine();
        }
    }
}
