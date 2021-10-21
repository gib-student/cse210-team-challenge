using System;

namespace _06_mastermind
{
    public class Hint
    {
        // circule menas the number is correct but not in the right place
        // Exes means correct number in the corret position
        // asterict means 
        private void compare_guess()
        {
            bool compare_board = false;
            foreach(int user_random_num in _random_num)
            {
                if (user_random_num == _random_num)
                {
                    compare_board = true;
                }
                else if (user_random_num != _random_num)
                {
                    compare_board = false;
                }
            }
            return !compare_board;
        }
        public get_hint()
        {
            string asterisk = "****";


        }
    }
}
