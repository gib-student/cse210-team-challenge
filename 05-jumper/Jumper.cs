using System;
using System.Collections.Generic;

namespace _05_jumper
{
   /// Stores all the data and logic associated with the jumper.
   public class Jumper
   {
        // Class-wide variables go here

        /// Compare the letter guess given by player to the secret word and 
        /// determine if the secret word contains that letter.
        public bool CompareLetter(char letter, string word)
        {
            foreach (char element in word)
            {
                if (element == letter)
                {
                    return true;
                }
            }
            // No matches
            return false;
        }

        public void DisplayJumper()
        {
            bool failed_try = 0;
            bool isWinner = false;


            while (failed_try = 0)
            {
                Console.WriteLine ("   ___   ");
                Console.WriteLine (" /     \ ");
                Console.WriteLine ("  _____  ");
                Console.WriteLine (" \     / ");
                Console.WriteLine ("  \   /  ");
                Console.WriteLine ("    0    ");
                Console.WriteLine ("   /|\   ");
                Console.WriteLine ("   / \   ");
                }

          if (failed_try == 1)
          { 
            Console.WriteLine (" /     \ ");
            Console.WriteLine ("  _____  ");
            Console.WriteLine (" \     / ");
            Console.WriteLine ("  \   /  ");
            Console.WriteLine ("    0    ");
            Console.WriteLine ("   /|\   ");
            Console.WriteLine ("   / \   ");

          }
          if (failed_try == 2)
          {
            Console.WriteLine ("  _____  ");
            Console.WriteLine (" \     / ");
            Console.WriteLine ("  \   /  ");
            Console.WriteLine ("    0    ");
            Console.WriteLine ("   /|\   ");
            Console.WriteLine ("   / \   ");
           }
           if (failed_try == 3)
           {
            Console.WriteLine (" \     / ");
            Console.WriteLine ("  \   /  ");
            Console.WriteLine ("    0    ");
            Console.WriteLine ("   /|\   ");
            Console.WriteLine ("   / \   ");
           }
            if (failed_try == 4)
            {
            Console.WriteLine ("  \   /  ");
            Console.WriteLine ("    0    ");
            Console.WriteLine ("   /|\   ");
            Console.WriteLine ("   / \   ");
           }
           if (failed_try == 5)
           {
            Console.WriteLine ("    X    ");
            Console.WriteLine ("   /|\   ");
            Console.WriteLine ("   / \   ");
            isWinner = false;
            Console.WriteLine("");
            Console.WriteLine(" You died. Please try again...");
            
           }

        }

    }
} 