using System;
using System.Linq;
using Fibonacci;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GetNumbersUnderShould
    {
        private FibonacciGetter _fibonacciGetter;

        [SetUp]
        public void SetUp()
        {
            _fibonacciGetter = new FibonacciGetter();
        }

        [Test]
        public void ReturnOneTwo_WhenGivenTwo()
        {
            var sequence = _fibonacciGetter.GetNumbersUnder(2);
            sequence.Should().BeEquivalentTo(1, 2);
        }

        [Test]
        public void ReturnOneTwoThree_WhenGivenThree()
        {
            var sequence = _fibonacciGetter.GetNumbersUnder(3);
            sequence.Should().BeEquivalentTo(1, 2, 3);
        }

        [Test]
        public void ReturnOneTwoThreeFive_WhenGivenSeven()
        {
            var sequence = _fibonacciGetter.GetNumbersUnder(7);
            sequence.Should().BeEquivalentTo(1, 2, 3, 5);
        }

        [Test]
        public void ReturnFirstTenNumbersInTheFibonacciSequence()
        {
            var sequence = _fibonacciGetter.GetNumbersUnder(89);
            sequence.Should().BeEquivalentTo(1, 2, 3, 5, 8, 13, 21, 34, 55, 89);
        }

    }
}
