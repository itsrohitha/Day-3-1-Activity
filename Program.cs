using System;

namespace Day_3_1_Activity
    // going for job interview. There are going to be 10 people that interview. 
    // Use a loop to display a message of the time of interview (integer) value
    // integer o'clock is ur interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the time of your interview: ");
            try
            {
                string input = Console.ReadLine();
                int time = int.Parse(input);
                if ((time > 0) && (time <= 12))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + time.ToString() + " times.");
                    // Here is the For Loop
                    for (int i = 1; i < time + 1; i++)
                    {
                    Console.WriteLine(i.ToString() + " o'clock is the time of your interview.");
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter the time and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter the time and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
