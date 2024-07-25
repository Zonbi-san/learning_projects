using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string sentence = "what have i done";

            //WNꓭꓥꓛXZꓶꓘſHꓨꓞꓷSⱯꓒOIꓵ⅄ꓕꓤƎMῸɯuqʌɔxzʅʞꓩɥɓɟpsɐdoᴉnʎʇɹǝʍb i gonna leave this here for later
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                switch (sentence[i])
                {
                    case 'q': Console.Write("b");
                        break;
                    case 'w':
                        Console.Write("ʍ");
                        break;
                    case 'e':
                        Console.Write("ǝ");
                        break;
                    case 'r':
                        Console.Write("ɹ");
                        break;
                    case 't':
                        Console.Write("ʇ");
                        break;
                    case 'y':
                        Console.Write("ʎ");
                        break;
                    case 'u':
                        Console.Write("n");
                        break;
                    case 'i':
                        Console.Write("ᴉ");
                        break;
                    case 'o':
                        Console.Write("o");
                        break;
                    case 'p':
                        Console.Write("d");
                        break;
                    case 'a':
                        Console.Write("ɐ");
                        break;
                    case 's':
                        Console.Write("s");
                        break;
                    case 'd':
                        Console.Write("p");
                        break;
                    case 'f':
                        Console.Write("ɟ");
                        break;
                    case 'g':
                        Console.Write("ɓ");
                        break;
                    case 'h':
                        Console.Write("ɥ");
                        break;
                    case 'j':
                        Console.Write("ꓩ");
                        break;
                    case 'k':
                        Console.Write("ʞ");
                        break;
                    case 'l':
                        Console.Write("ʅ");
                        break;
                    case 'z':
                        Console.Write("z");
                        break;
                    case 'x':
                        Console.Write("x");
                        break;
                    case 'c':
                        Console.Write("ɔ");
                        break;
                    case 'v':
                        Console.Write("ʌ");
                        break;
                    case 'b':
                        Console.Write("q");
                        break;
                    case 'n':
                        Console.Write("u");
                        break;
                    case 'm':
                        Console.Write("ɯ");
                        break;
                    case ' ':
                        Console.Write(" ");
                        break;
                }
                //System.Threading.Thread.Sleep(200);
            }
            Console.ReadLine();
        }
    }
}