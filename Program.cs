using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This program is made to return an average of a group of numbers provided by the user*/

            //varible declaration
            int count;
            string tmp;
            double avg;
            int flg = 0;

            //loop for repeating execution
            while (flg == 0)
            {
                //clearing the console for ease of use
                Console.Clear();

                //getting the variables
                Console.Write("Enter the count: ");

                //checking if we got an integer 
                if (int.TryParse(Console.ReadLine(), out count))
                {
                    //calling the method
                    tmp = ricardoAdd(count);
                    //if the return for the method is not a string it will print it
                    if (double.TryParse(tmp, out avg))
                    {
                        //printing the results
                        Console.WriteLine($"The average value is: {avg:0.##}");
                        Console.WriteLine("Thank you, Ricardo");
                    }
                    else
                    {
                        //if the return for the method is a string it will print the error
                        Console.WriteLine(tmp);
                        Console.WriteLine("Thank you, Ricardo");
                    }
                    //asking if you want to continue
                    Console.WriteLine("Would you like to try again? Y or N");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        break;
                    }
                }
                //showing the error if any in the count of the array
                else { 
                    Console.WriteLine("Not a positive number or decimal, please try again");
                    Console.ReadLine();
                }               

            }
        }

        //method to ask for a series of numbers and return an average
        public static string ricardoAdd(int count) {

            //variable declaration
            int[] numbers = new int[count];
            double avg;
            int temp;

            //confirming how many numbers in the array
            Console.WriteLine($"Enter {count} integer numbers:");

            //assigning values
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Number {i+1}: ");

                //checking if i actually fot a number
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    //adding the number to the array
                    numbers[i] = temp;
                }
                else
                {
                    //return of NaN message and break
                    return "Not a number or decimal, please try again";
                    break;
                }

            }

            //average calculation
            avg= numbers.Sum() / numbers.Length;

            //returning average
            return avg.ToString();
        }
    }
}