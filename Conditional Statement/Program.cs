/** 
Christopher Boehm 
Grade Calculator
9/11/2019
*/
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks for input value
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                //changes inputted value to an int
                string input = Console.ReadLine();
                int new_input = int.Parse(input);

                //if statement to determine your grade
                if(new_input >= 90)
                {
                    Console.WriteLine("You have recieved a A!");
                }

                else if(new_input >= 80)
                {
                    Console.WriteLine("You have recieved a B");
                }

                else if(new_input >= 70)
                {
                    Console.WriteLine("You have recieved a C");
                }
                else if(new_input >= 60)
                {
                    Console.WriteLine("You have recieved a D");
                }
                else
                {
                    Console.WriteLine("You have recieved a F");
                }
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("You have an error");
            }
        }
    }
}
