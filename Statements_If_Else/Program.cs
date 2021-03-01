using System;

namespace Statements_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoritenumber = 5;
            Console.WriteLine("Which is your favorite Number? Hint: Choose from 1 to 100");
            int userguess = int.Parse(Console.ReadLine());

            if (favoritenumber > userguess)
            {
                Console.WriteLine("Too Low");
            }

            else if (favoritenumber < userguess)
            {
                Console.WriteLine("Too High");
            }

            else if (favoritenumber == userguess)

            {
                Console.WriteLine("You`re right!");
            }

            else

            {
                Console.WriteLine("NeverMind");
            }



        }
    }
}
