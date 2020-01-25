using System;
using System.Collections.Generic;

namespace ListWithMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and continuously ask the user to enter different names, 
             until the user presses Enter(without supplying a name).
             Depending on the number of names provided, display a 
             message based on the above pattern.*/
            //var listName = new List<string>();
            /*
                        while (true)
                        {
                            Console.WriteLine("Enter a different Name everytime and press enter to terminate the program");
                            var userInput = Console.ReadLine();

                            if (String.IsNullOrWhiteSpace(userInput))
                                break;

                            listName.Add(userInput);
                        }

                        if (listName.Count > 2)
                            Console.WriteLine("{0},{1}, and {2} others like your post", listName[0],listName[1],listName.Count-2);
                        else if (listName.Count == 1)
                            Console.WriteLine("{0} Likes your Post",listName[0]);

                        else if (listName.Count == 2)

                            Console.WriteLine("{0} and {1} Like your Post",listName[0],listName[1]);
                        else
                            Console.WriteLine();*/
            /*
                        /// <summary>
                        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
                        /// Display the reversed name on the console.
                        /// </summary>
                        Console.WriteLine("Enter your name");
                        var name = Console.ReadLine();
                        var arrayName = new char [name.Length];
                        for ( var i = name.Length; i>0 ; i--)
                            arrayName[name.Length - i] = name[i - 1];
                        var nameReversed = new string(arrayName);
                        Console.WriteLine(nameReversed);*/


            /// <summary>
            /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.
            /// </summary>


            /* var numbers = new List<int>();
             while (numbers.Count < 5) 

             {
                 Console.WriteLine("Enter 5 number :");
                 var userInput = Console.ReadLine();
                 var number = Convert.ToInt32(userInput);
                 if (numbers.Contains(number))
                 {

                         Console.WriteLine("You've previously entered " + number);
                         continue;

                 }
                 numbers.Add(number);



             }


             numbers.Sort();
             Console.WriteLine();
             foreach (int num in numbers)
             Console.WriteLine(num);*/


            /*4 - Write a program and ask the user to continuously enter a number or type
                  "Quit" to exit. The list of numbers may include duplicates.
                  Display the unique numbers that the user has entered.*/


            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or ty 'Quit ' to Exit");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() =="quit")
                    break;
                numbers.Add(Convert.ToInt32(userInput));

            }
            var uniques = new List<int>();
            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            Console.WriteLine("The unique list with all different numbers is:");
            foreach (var num in uniques) 

            Console.WriteLine(num);
               






        }
    }
} 

