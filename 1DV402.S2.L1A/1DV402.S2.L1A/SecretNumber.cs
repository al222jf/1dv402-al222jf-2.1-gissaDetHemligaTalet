﻿using System;
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


        public void Initialize()
        {
            _count = 0;
           
            Random nr = new Random();
            _number = nr.Next(1, 101);
            
        }

        public bool MakeGuess(int number)
        {
            if (number > 100 || number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (_count < MaxNumberOfGuesses)
            {
                if (number > _number)
                {
                    Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
                }
                _count++;

                if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
                }
                if (number == _number)
                {
                    Console.Write("RÄTT GISSAT. Du klarade det på {0} försök", _count);
                    return true;
                }
                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Det hemliga talet är {0}", _number);
                }
                return false;
            }
            else
            {
                throw new ApplicationException();
            }


            
           
            

            

           
        }

        public SecretNumber()
        {
            Initialize();
        }
        
        
    }

    
}
