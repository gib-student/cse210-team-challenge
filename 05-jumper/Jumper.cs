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

    }
} 