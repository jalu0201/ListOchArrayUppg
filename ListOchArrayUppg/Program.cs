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



    }
}