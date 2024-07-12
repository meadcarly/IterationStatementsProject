using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //Done!  Create a variable of type int and name it num
            int num;
            //Done!  initialize the variable with a value of 0
            num = 0;


            // Done!  Create a do-while loop and use the template below:
            do
            {
                // Done!  Increment num by 1
                num++;
                // Done! Then add num to the collection - numbers
                // Done! Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100);// Done! <---- While your variable is less than 100



            // Done!  Create a while loop
            // Done!  <--- While num is less than 200
            while(num < 200)
            {
                // Done!  Increment num by 1
                num++;
                // Done!  Then add num to the collection numbers
                // Done!  HINT: copy how this was done in the do while loop
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Done!  Create a foreach loop using the collection - numbers (Carly's note-from top of the page-already created)
            // Done!  In the scope of the foreach loop, print each number in numbers
            foreach (int number in numbers)
            {
                    Console.WriteLine($"{number}");
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Done!  Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // Done!  in your initializer set the value of i to 199
                // Done!  in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // Done!  AND as long as i is greater than or equal to 0
                // Done!  Decrement i by 1

            // Done!  start for loop here
            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }

            //------------End of exercise
        }
    }
}
