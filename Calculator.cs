using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStudio_Academy_Calculator
{
    class Calculator
    {
        public double Add(double LeftOperand, double RightOperand)
        {
            return (LeftOperand + RightOperand);
        }

        public double Minus(double LeftOperand, double RightOperand)
        {
            return (LeftOperand - RightOperand);
        }

        public double Multiply(double LeftOperand, double RightOperand)
        {
            return (LeftOperand*RightOperand);
        }

        public double Divide(double LeftOperand, double RightOperand)
        {
            if (RightOperand != 0)
            {
                return (LeftOperand/RightOperand);
            }
            else
            {
                throw new DivideByZeroException("Division by zero!");    //Division by zero is not allowed in this system
            }
        }
        
    }
}
