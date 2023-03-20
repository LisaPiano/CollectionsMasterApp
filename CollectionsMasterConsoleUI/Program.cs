using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            var list = new int[50];
            Populater(list);
           
            Console.WriteLine($"The first number is {list[0]}.");
            Console.WriteLine($"The last number is {list[list.Length-1]}"); 

           
            //TODO: Print the first number of the array

            //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(list);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(list);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
           

            Array.Sort(list);
            NumberPrinter(list);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var numberList = new List<int>();
            Console.WriteLine(numberList);
            Console.WriteLine($"Here is the first capacity: {numberList.Capacity}");


            //TODO: Print the capacity of the list to the console
            Populater(numberList);
            Console.WriteLine($"Here is the new capacity: {numberList.Capacity}");


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //TODO: Print the new capacity


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int answer;
            bool isANumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out answer);
            } while (!isANumber);


            NumberChecker(numberList, answer);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
                OddKiller(numberList);
            NumberPrinter(numberList);


            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] listToArray = numberList.ToArray();
          
            

            //TODO: Clear the list

            numberList.Clear();
            Console.WriteLine("See! No more lists or array. No more time to play. :(");
            NumberPrinter(numberList);


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
           for (var i = 0; i < numbers.Length; i++)
               {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
               
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(i => i % 2 == 1);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes! Your number, {searchNumber} is in the list. See! Here is the list:");
                NumberPrinter(numberList);
            }
            else
            {
                Console.WriteLine($"No, sorry. Avada Kedavra! Your number, {searchNumber} is not in the list. See! Here is the list:");
                NumberPrinter(numberList);
            }
        }

        private static void Populater(List<int> numberList)
   
        {
            int no = 1;
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();
                numberList.Add(rng.Next(0, 50));
                Console.WriteLine($"{no}. is {numberList[i]}");
                no++;
            }
            NumberPrinter(numberList);
        }
        
        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) {
                Random rng = new Random();
                int v = rng.Next(0, 50);
                numbers[i] = v;
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
