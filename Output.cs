using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStudio_Academy_Calculator
{
    public interface IOutput
    {
        void MakeOutput(double LeftOperand, double RightOperand, double Result, char TypeOfAction);
    }

    public class ConsoleOutput: IOutput
    {
        public void MakeOutput(double LeftOperand, double RightOperand, double Result, char TypeOfAction)
        {
            Console.Write("Result of {0}{1}{2} is {3}", arg0: LeftOperand, arg1: TypeOfAction, arg2:RightOperand, arg3:Result);
        }
    }

    public class DiskOutput: IOutput
    {
        public void MakeOutput(double LeftOperand, double RightOperand, double Result, char TypeOfAction)
        {
            string resStr = "Result of " + LeftOperand.ToString() + TypeOfAction.ToString() + RightOperand.ToString() + Result.ToString();
            System.IO.File.WriteAllText("Result.txt", resStr);
        }
    }
}
