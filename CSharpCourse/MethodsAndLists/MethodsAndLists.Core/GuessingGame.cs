using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class GuessingGame
    {
        public enum GuessResult
        {
            Higher, Lower, Success, Fail
        }
        public int CorrectNumber { get; set; }
        public int GuessesLeft { get; set; }
        private int _lastGuess = 0;
        public GuessingGame(int correctNumber, int numberOfGuesses)
        {
            if (correctNumber <= 0 || numberOfGuesses <= 0)
                throw new ArgumentException("Please enter positive number only");

            CorrectNumber = correctNumber;

            GuessesLeft = numberOfGuesses;
        }
        public GuessResult Guess(int guess)
        {
            if (GuessesLeft <= 0)
                throw new Exception();

            if (guess != _lastGuess)
            {
                _lastGuess = guess;
                GuessesLeft--;
            }

            if (guess == CorrectNumber)
            {
                return GuessResult.Success;
            }
            else if (guess < CorrectNumber && GuessesLeft > 0)
                return GuessResult.Higher;
            else if (guess > CorrectNumber && GuessesLeft > 0)
                return GuessResult.Lower;
            else 
                return GuessResult.Fail;


        }
    }
}
