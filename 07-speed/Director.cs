using System;
using System.Collections.Generic;

namespace _07_speed
{
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        Buffer _buffer = new Buffer();

        ScoreBoard _scoreBoard = new ScoreBoard();

        List<Word> _words = new List<Word>();
        WordBank _wordBank = new WordBank();

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
            _outputService.OpenWindow(Constant.MAX_X, Constant.MAX_Y, "Speed", Constant.FRAME_RATE);
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            string letter = _inputService.GetLetterPressed();
            
            if (letter != "")
            {
                _buffer.AddLetter(letter);
            }
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            GenerateNewWord();

            foreach (Word word in _words)
            {
                word.MoveNext();
            }

            HandleMatchingWord();
            RemoveOffScreenWord();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);

            _outputService.DrawActor(_buffer);
            
            foreach (Word word in _words)
            {
                _outputService.DrawActor(word);
            }
            _outputService.EndDrawing();
        }

        //Check to see if anyword matches
        private void HandleMatchingWord()
        {
            List<Word> removeWords = new List<Word>();
            foreach(Word word in _words)
            {
                if (_buffer.IsMatch())
                {
                    removeWords.Add(word);
                    _buffer.Clear();
                    int points = word.GetPoints();
                    _scoreBoard.AddPoints(points);
                }
            }
            foreach (Word word in removeWords)
            {
                _words.Remove(word);
            }
        }
        //Add a new word to the screen
        private void GenerateNewWord()
        {
            Random randomGenerator = new Random();
            double randomNumber = randomGenerator.NextDouble();
            if (randomNumber < Constant.RANDOM_WORD_RATE)
            {
                string newWord = _wordBank.RandomWord();
                Word word = new Word(newWord);
                _words.Add(word);
            }
            
        }
        //Remove any word from screen
        private void RemoveOffScreenWord()
        {
            List<Word> removeWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (word.OffScreen())
                {
                    removeWords.Add(word);
                    int points = word.GetPoints();
                    _scoreBoard.SubtractPoints(points);
                }
            }
            foreach (Word word in removeWords)
            {
                _words.Remove(word);
            }
        }
    }
}