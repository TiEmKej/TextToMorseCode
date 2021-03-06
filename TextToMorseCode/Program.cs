using System;
using System.Threading;
using System.Threading.Tasks;

namespace TextToMorseCode
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Text to morse code converter");
            Input();
            Console.ReadKey();
        }
        static void Input()
        {
            string input;
            string morse = null;
            Console.WriteLine("Provide input: ");
            input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                char dalej = input[i];
                morse = morse + Dictionary(dalej);
            }
            Blink(morse);
        }
        static string Dictionary(char input)
        {
            string morse = null;
            switch (input)
            {
                case 'a':
                    Console.Write(". ─");
                    morse = ". ─";
                    break;
                case 'b':
                    Console.Write("─ . . .");
                    morse = "─ . . .";
                    break;
                case 'c':
                    Console.Write("─ . ─ .");
                    morse = "─ . ─ .";
                    break;
                case 'd':
                    Console.Write("─ . .");
                    morse = "─ . .";
                    break;
                case 'e':
                    Console.Write(".");
                    morse = ".";
                    break;
                case 'f':
                    Console.Write(". . ─ .");
                    morse = ". . ─ .";
                    break;
                case 'g':
                    Console.Write("─ ─ .");
                    morse = "─ ─ .";
                    break;
                case 'h':
                    Console.Write(". . . .");
                    morse = ". . . .";
                    break;
                case 'i':
                    Console.Write(". .");
                    morse = ". .";
                    break;
                case 'j':
                    Console.Write(". ─ ─ ─");
                    morse = ". ─ ─ ─";
                    break;
                case 'k':
                    Console.Write("─ . ─");
                    morse = "─ . ─";
                    break;
                case 'l':
                    Console.Write(". ─ . .");
                    morse = ". ─ . .";
                    break;
                case 'm':
                    Console.Write("─ ─");
                    morse = "─ ─";
                    break;
                case 'n':
                    Console.Write("─ .");
                    morse = "─ .";
                    break;
                case 'o':
                    Console.Write("─ ─ ─");
                    morse = "─ ─ ─";
                    break;
                case 'p':
                    Console.Write(". ─ ─ .");
                    morse = ". ─ ─ .";
                    break;
                case 'q':
                    Console.Write("─ ─ . ─");
                    morse = "─ ─ . ─";
                    break;
                case 'r':
                    Console.Write(". ─ .");
                    morse = ". ─ .";
                    break;
                case 's':
                    Console.Write(". . .");
                    morse = ". . .";
                    break;
                case 't':
                    Console.Write("─");
                    morse = "─";
                    break;
                case 'u':
                    Console.Write(". . ─");
                    morse = ". . ─";
                    break;
                case 'v':
                    Console.Write(". . . ─");
                    morse = ". . . ─";
                    break;
                case 'w':
                    Console.Write(". ─ ─");
                    morse = ". ─ ─";
                    break;
                case 'x':
                    Console.Write("─ . . ─");
                    morse = "─ . . ─";
                    break;
                case 'y':
                    Console.Write("─ . ─ ─");
                    morse = "─ . ─ ─";
                    break;
                case 'z':
                    Console.Write("─ ─ . .");
                    morse = "─ ─ . .";
                    break;
                case ' ':
                    Console.Write("    ");
                    break;
            }
            return morse;
        }
        static void Blink(string morse)
        {
            string lampOff = "\n╔═════╗\n" +
                             "║     ║\n" +
                             "║     ║\n" +
                             "║     ║\n" +
                             "╚═╦═╦═╝\n" +
                             "  ║ ║  \n" +
                             "  ╚═╝  \n";
            string lampOn = "╔═════╗\n" +
                            "║▒▒▒▒▒║\n" +
                            "║▒▒▒▒▒║\n" +
                            "║▒▒▒▒▒║\n" +
                            "╚═╦═╦═╝\n" +
                            "  ║ ║  \n" +
                            "  ╚═╝  \n";
            for (int i = 0; i < morse.Length; i++)
            {
                char letter = morse[i];
                if (letter == 46)
                {
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop = 5);
                    Console.WriteLine(lampOff);
                    Thread.Sleep(300);
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 8);
                    Console.WriteLine(lampOn);
                    Console.WriteLine("  .  ");
                    Thread.Sleep(300);
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 10);
                    Console.WriteLine(lampOff);

                }
                else if(letter == 32)
                {

                }
                else
                {
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop = 5);
                    Console.WriteLine(lampOff);
                    Thread.Sleep(300);
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 8);
                    Console.WriteLine(lampOn);
                    Console.WriteLine("  ─  ");
                    Thread.Sleep(900);
                    Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 10);
                    Console.WriteLine(lampOff);
                }
            }
            Console.WriteLine("Done");

        }
    }
}
            