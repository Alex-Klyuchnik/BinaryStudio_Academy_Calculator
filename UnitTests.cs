
using System;
using NUnit.Framework;

namespace BinaryStudio_Academy_Calculator
{
    class UnitTests
    {
        [Test]
        public void Should_Equal10point1_WhenAdd1point1To9()
        {
            var Calculator = new Calculator();
            Assert.AreEqual( 10.1 ,  Calculator.Add(1.1 , 9));
        }
        
        [Test]
        public void Should_Eqal0point3_When1Minus0point7()
        {
            var Calculator = new Calculator();
            Assert.AreEqual( 0.3 , Math.Round (Calculator.Minus(1 , 0.7)),3);
        }

        [Test]
        public void Should_Equal9point9_When3point3MultipliesBy3()
        {
            var Calculator = new Calculator();
            Assert.AreEqual( 9.9 , Math.Round(Calculator.Multiply(3.3,3),5));
        }
    
        [Test]    
        public void Should_Equal0point45_When9DividesBy20()
        {
            var Calculator = new Calculator();
            Assert.AreEqual(0.45,Math.Round(Calculator.Divide(9,20)),9);
        }
 
    }
}
