using System;

namespace _06_mastermind
{
    public class Hint
    {
        // circule menas the number is correct but not in the right place
        // Exes means correct number in the corret position
        // asterict means 

        string asterisk = "";
        string circles = "";
        string exes = "";
        private bool compare_guess()
        {
            bool compare_board = false;
            foreach(int user_random_num in RandomGenerator())
            {
                if (user_random_num == RandomGenerator())
                {
                    compare_board = true;
                }
                else if (user_random_num != RandomGenerator())
                {
                    compare_board = false;
                }
            }
            return !compare_board;
        }
        public string GetHint(int SecretNum, int user_random_num)
        {
            string asterisk = "****";

            foreach(user_random_num in SecretNum)
            {
                if (user_random_num != SecretNum)
                {
                    string circles = "OOOO";
                    return circles;
                }
                else (user_random_num == SecretNum)
                {
                    string exes = "XXXX";
                    return exes;
                }
            }
        }
    }
}
