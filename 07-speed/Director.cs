using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_snake
{
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        Buffer _buffer = new Buffer();

        Words _word= new Words();
        ScoreBoard _scoreBoard = new ScoreBoard();

        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            object p = _outputService.OpenWindow(Constant.MAX_X, Constant.MAX_Y, "Speed", Constant.FRAME_RATE);
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            if (_inputService.LetterPressed())
            {
                string letter = _inputService.GetLetterPressed();
                _buffer.AddLetter(letter);
            }
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            GenerateNewWords();

            foreach (Words word in _word)
            {
                _word.Move();
            }
            _buffer.Display();

            HandleMatchingWord();
            _word.RemoveOffScreenWord();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);

            _outputService.DrawActor(_buffer);
            
            foreach (Words word in _words)
            {
                _outputService.DrawActors(word);
            }
            _outputService.EndDrawing();
        }

        //Check to see if anyword matches, remove the word, clear buffer, and update scoreboard.
        private void HandleMatchingWord()
        {
            List<string> correctWords = new List<string>();
            List<string> words = _word.GetList();
            foreach(string word in words)
            {
                if (_buffer.ToString() == word)
                {
                    correctWords.Add(word);
                    _buffer.Clear();
                    _scoreBoard.AddPoints(word);
                }
            }
            foreach(string word in words)
            {
                foreach (string correctWord in correctWords)
                {
                    if (correctWord == word)
                    {
                        _word.Remove(correctWord);
                    }
                }
            }
        }
        private void GenerateNewWord()
        {

        }
    }
}