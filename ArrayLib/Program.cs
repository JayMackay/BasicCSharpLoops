using System;

namespace ArrayLib
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[,] grid = { { 4, 7, 8, 9 }, { 6, 1, 7, 10 } };
            Console.WriteLine(grid[1, 2] + "[1,2] This is the second array in the third positioin"); //Answer returns 7

            string name = "Jared";

            //Reference the variable to convert to upper and store it as a new variable
            string upperName = name.ToUpper();
            var secondLetter = name[1]; //This should return "a"

            var midChars = name.ToCharArray(1, 3);
                //From position one, three lengths (Starting at 0)
                //Should return "are"

            Console.WriteLine(upperName);
            Console.WriteLine(secondLetter);
            Console.WriteLine(midChars);

            //Parsing Strings Converting To Primative Types
            Console.WriteLine("How Many Apples?");
            string input = Console.ReadLine();
            int numApples = Int32.Parse(input); //Parse returns an exception, TryParse tuns the program normally
            Console.WriteLine(numApples + 2);

            //Interpolation
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("What is your age: ");
            string age = Console.ReadLine();
            int ageNum = Int32.Parse(age);
            int ageTwo = ageNum + 2;

            var greeting = $"Hi, so your name is {firstName} {lastName} and in 2 years you will be {ageTwo} years old.";
            Console.WriteLine(greeting);

            for( int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                    if (i % 15 == 0) break;
            }

            //For loop counting down from 100
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //FOR LOOPS
            int[] myArray = { 10, 20, 30 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            //WHILE LOOP
            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine(counter * 10);
                counter++;
            }
            
            //DO WHILE LOOP
            int counter = 11;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 10);

            //Cumulative value loop
            int Total = 0;
            for (int i = 0; i <= 100; i++)
            {
                Total += i; //Total value + i and keeps incrementing
            }
            Console.WriteLine(Total);

            //Print all numbers only if they are divisable by three
            for (int i = 0; i <= 100; i += 5)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //FOR EACH LOOP. Changes String to lower case and prints out each character 
            string name = "NISH IS KING";
            string lowerName = name.ToLower();
            foreach (char n in lowerName)
            {
                Console.WriteLine(n);
            }
        }
    }
}