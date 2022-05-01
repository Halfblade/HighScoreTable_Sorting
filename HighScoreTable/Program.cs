/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          1) Read the Instructions.pdf file.
//          2) Run the example.exe to see how this program will behave.
//          3) Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.
//
//          Unless where specified, the program does not have to look exactly
//          like the example (e.g. text doesn't have to be centered on screen)
/////////////////////////////////////////////////////////////////////////////
using System;
using FSPG;


namespace HighScoreTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Ask the user how many high scores they want.
            //       Then read in their input.
            //       Support error checking (input validation).
            //       The user should only be able to input a positive
            //       integer value.
            //       You may use Utility.ReadInt() and Utility.IsReadGood()
            //       to help you with error checking.

            
            
            int Highscorenumbers = 0;
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("How many high scores do you want?");
                if (!Int32.TryParse(Console.ReadLine(), out Highscorenumbers))
                {
                    Console.WriteLine("Invalid output! Please use a number");
                }
                else
                {
                    if (Highscorenumbers < 0)
                    {
                       Console.WriteLine("Invalid output! Please do not use a negitive.");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                

            }
















            // TODO: Define an array of ints, which will hold the high scores.
            //       Make the array the exact size indicated by the user above.  
            int[] HighScores = new int[Highscorenumbers];
           

            // TODO: Ask the user for each high score, and read in their inputs.
            //       Make sure to read in as many high scores are in the array.
            //       If the high score array is size 5, then read in 5 inputs.
            //       You DO NOT NEED to support error checking for each score;
            //       assume each input will be an integer.
           
            
            for (int Indx = 0; Indx < HighScores.Length; Indx++)
            {
                Console.Write("Enter Score 0" + (Indx + 1) + ": ");
                HighScores[Indx] = Int32.Parse(Console.ReadLine());
            }

            
           
            

            

            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Unsorted");

            // TODO: Call your PrintArray function passing the array of high scores.
            
            PrintArray(HighScores);


            // TODO: Call the SortArrayHighToLow procedure,
            //       passing the array of high scores, to sort them.
            
            SortArrayHighToLow(HighScores);

            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Sorted");

            // TODO: Call your PrintArray function passing the array of high scores.
            
            PrintArray(HighScores);
            Console.ReadKey();
            
        }

        // TODO: Write a function called PrintArray that takes as input
        //       a single int array, and returns nothing.
        //       The function will loop through the array and print out
        //       each int on its own line.
        //       Don't forget the keyword static.
       static void PrintArray(int[] HighS)
       {
            foreach(int x in HighS)
            {
                Console.WriteLine(x);
            }
       }

        
       

        /// <summary>
        /// This procedure takes an array of ints and sorts them in place.
        /// After a call to this procedure the array of ints passed in will be
        /// sorted from highest to lowest.
        /// </summary>
        /// <param name="numbers">an array of ints to sort</param>
        static void SortArrayHighToLow(int[] numbers)
        {
            int tmp;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j] > numbers[j-1]; j--)
                {
                    tmp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = tmp;
                }
            }
        }
    }
}
