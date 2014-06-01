using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    public class FibonacciGetter
    {
        private List<int> _numbersInSequence;

        public FibonacciGetter()
        {
            _numbersInSequence = new List<int> { 1, 2 };
        }

        public List<int> GetNumbersUnder(int maxPossibleNumber)
        {
            var nextNumber = GetNextNumberInSequence();

            while (nextNumber <= maxPossibleNumber)
            {
                _numbersInSequence.Add(nextNumber);
                nextNumber = GetNextNumberInSequence();  
            }

            return _numbersInSequence;
        }
  
        private int GetNextNumberInSequence()
        {
            var length = _numbersInSequence.Count();
            var lastNumber = _numbersInSequence[length - 1];
            var secondToLastNumber = _numbersInSequence[length - 2];
            var sum = lastNumber + secondToLastNumber;
            return sum;
        }
    }
}