using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    public class Hint
    {
        private string _hint="";

        /// Determine the hint which the user should get for his guess
        public string GetHint(string secretNumString, string guessString)
        {
            // Reset the hint
            _hint = "";
            
            // Convert guess from string to a list<int>
            List<int> guess = ConvertToListInt(guessString);
            // Convert secretNum from string to a list<int>
            List<int> secretNum = ConvertToListInt(secretNumString);
            // Make the hint
            // Go through every number in the guess
            for (int i = 0; i <= 3; i++)
            {
                bool found = false;
                // Test for an x first
                if (IsX(guess[i], secretNum[i]))
                {
                    AddX();
                    found = true;
                }
                // Test for an o second
                if (!found)
                {
                    if (IsO(guess[i], secretNum))
                    {
                        AddO();
                        found = true;
                    }
                }
                // If not an x or an o then surely it is an asterisk
                if (!found)
                {
                    AddAsterisk();
                    found = true;
                }
            }

            return _hint;
        }

        /// Test if the two numbers match
        private bool IsX(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }
        
        /// Test if the guess exists anywhere in the secret number
        private bool IsO(int guess, List<int> secretNum)
        {
            foreach(int num in secretNum)
            {
                if (guess == num)
                {
                    return true;
                }
            }
            return false;
        }

        /// Add an x to the hint
        private void AddX()
        {
            _hint += "x";
        }

        private void AddO()
        {
            _hint += "o";
        }
        private void AddAsterisk()
        {
            _hint += "*";
        }

        /// Convert given string to a list<int>
        private List<int> ConvertToListInt(string numbers)
        {
            List<int> numbersList = new List<int>();
            foreach (char letter in numbers)
            {
                numbersList.Add(letter - '0');
            }
            return numbersList;
        }
    }
}
