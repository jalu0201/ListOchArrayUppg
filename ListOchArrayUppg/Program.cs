using System;

namespace ListOchArrayUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testTal = { 1, 2, 3,6,8 };
            List<int> testIntList = new List<int>() { 5,7,54,43,3};

            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av testdatan är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av testdatan är: " + GreatestNumber(testIntList));

            // Demonstration av Contains
            string[] names = { "Anna", "Bertil", "Cesar" };
            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(names, "Bertil"));
            Console.WriteLine("Contains(David): " + Contains(names, "David"));

            // Demonstration av Swap
            int[] swapTestData = { 8, 4, 6, 9, 2, 7, 3 };
            Console.WriteLine();
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: element på index 2: " + swapTestData[2]); 
            Console.WriteLine("Före: element på index 5: " + swapTestData[5]); 
            Swap(2, 5, swapTestData);
            Console.WriteLine("Efter: element på index 2: " + swapTestData[2]);
            Console.WriteLine("Efter: element på index 5: " + swapTestData[5]);

            // Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));

            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();






        }

        public static int Summan(int[] listOfNumbers)
        {
           int sum = 0;
            for(int i = 0; i < listOfNumbers.Length; i++)
            {
                sum = sum + listOfNumbers[i];
            }

            return sum;
        }
        public static int GreatestNumber(List<int> numbers)
        {
            int största = 0;
            for (int i = 0; i <  numbers.Count; i++)
            {if (numbers[i] > största)
                {
                    största = numbers[i]; 
                }
                
            }
            return största; 
        }

        public static bool Contains(string[] names, string name)
        {
            foreach (string s in names)
            {
                if (s == name) return true;
            }


            return false; 
        }

     
        static void Swap(int i1, int i2, int[] intarray)
        {
            int swap = intarray[i1];
            intarray[i1] = intarray[i2];
            intarray[i2] = swap;
           
        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] result = new string[part1.Length + part2.Length];
            for(int i = 0; i< part1.Length; i++)
            {
                result[i] = part1[i];
            }         
            for(int i = 0; i < part2.Length; i++)
            {
                result[part1.Length + i] = part2[i];
            }


            return result ;
        }


        public static void Reverse(int[] numbers)
        {
          
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Swap(i, numbers.Length - 1 - i, numbers);
            }
            return ;
        }


    }
}