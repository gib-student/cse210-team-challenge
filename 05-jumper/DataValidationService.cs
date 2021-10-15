using System;

namespace _05_jumper
{
   /// This class is for ensuring data is in a valid and useful state.
	public class DataValidationService
	{
		/// Ensure the input from the player is a single char a-z; either upper
		/// or lower caps is acceptable.
		public bool ValidateLetter(string input)
      {
			// First check: no more than one index
			if (input.Length > 1)
			{
				return false;
			}
			// Now that we know it is only one element, convert input to 
			// lowercase, then to a char, then get its ASCII value	
			int asci = char.Parse(input.ToLower());

			// Check if ASCII value of input is within the range of letters
			if (asci < 97 || asci > 122)
			{
				return false;
			}
			// All checks passed
			return true;
		}
	}
}