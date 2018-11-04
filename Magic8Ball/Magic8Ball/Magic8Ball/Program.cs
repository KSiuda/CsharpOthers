using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgramName();

            Random rObject = new Random();



            while (true)
            {
                string question = QuestionFromUser();

                if (question.Length == 0)
                {
                    Console.WriteLine("You need to type a question fool!");
                    continue;
                }

                if (question.ToLower() == "quit")
                {
                    break;
                }

                if ((question.ToLower() == "pierdol sie") || (question.ToLower() == "wal sie") || (question.ToLower() == "fck you") || (question.ToLower() == "fuck you"))
                {
                    Console.WriteLine("Oooo nie, tak sie nie bedziemy bawic!");
                    break;
                }

                int sleeptime = rObject.Next(2) + 1;
                Thread.Sleep(sleeptime * 1000);

                int rannum = rObject.Next(4);

                switch (rannum)
                {
                    case 0: { Console.WriteLine("YES!"); break; }
                    case 1: { Console.WriteLine("OMG YES!"); break; }
                    case 2: { Console.WriteLine("NO!"); break; }
                    case 3: { Console.WriteLine("HELL NO!"); break; }


                }

            }

        }

        static void ProgramName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("agic8Ball (by Konrad)");
        }
        static string QuestionFromUser()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ask any question to the 8ball?: ");
            Console.ForegroundColor = ConsoleColor.White;
            string question = Console.ReadLine();

            return question;
        }

    }
}
