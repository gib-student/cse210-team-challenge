using System;

namespace _05_jumper
{
   public class Director
   {
      // Class-wide variables
      public Jumper _jumper = new Jumper();
      public UserService _userService = new UserService();
      public WordBank _wordBank = new WordBank();
      public DataValidationService _dataValidation = new DataValidationService();

      bool done = false;
      public string _letterString;
      public char _letterChar;

      /// I don't know why this doesn't work, but we need to get this to work.
      /// For now the following code will have to do
      // public const string _secretWord = _wordBank.GenerateWord(); 
      public const string _secretWord = "secret";

      public void StartGame()
      {
         DoOutput();
         while (!done)
         {
            GetInputs();
            DoUpdates();
            DoOutput();
         }
      }

      /// Get all the needed from the user
      public void GetInputs()
      {
         _letterString = _userService.PromptLetter();
         while (!_dataValidation.ValidateLetter(_letterString))
         {
            _userService.ShowBadInputMessage();
            _userService.PromptLetter();
         }
         // Convert to string now that we know it is valid input
         _letterChar = char.Parse(_letterString.ToLower());
      }

      /// Update the game state
      public void DoUpdates()
      {
         _jumper.CompareLetter(_letterChar, _secretWord);
      }

      /// Do all the outputs for the game
      public void DoOutput()
      {
         _userService.DisplayParachute();

      }
   }
}