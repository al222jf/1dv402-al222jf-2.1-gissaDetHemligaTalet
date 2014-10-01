using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;

        private int _count;
        private int _number;

        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
            //Set count to 0 and randomize a number
            _count = 0;
           
            Random nr = new Random();
            _number = nr.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                //If count is 7 or above
                throw new ApplicationException();
            }
                
             //To be sure the number is between 1 and a 100
            if (number > 100 || number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            //As long as count is smaller than 7

            //Counts every guess
            _count++;

            //If you guess right, will also return true
            if (number == _number)
            {
                Console.Write("RÄTT GISSAT. Du klarade det på {0} försök", _count);
                return true;
            }

            //If the number is above the secret number
            if (number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
            }
            else 
            {
                //If the number is below the secret number
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
            }

            //If you have used up all your guesses
            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är {0}", _number);
            }

            return false;
        }
    }
}
