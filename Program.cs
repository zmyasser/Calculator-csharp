using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{

    class clsCalculator
    {

        private enum enOpType : byte
        { enNone, enAdd, enSubtract, enMultiply, enDivide }


        private int _Number;
        private enOpType _OpName;
        private int _Result;
        private int _PrevResult;

        private void _ShowResult()
        {
            switch (_OpName)
            {
                case enOpType.enAdd:
                    {
                        Console.WriteLine("Result after adding " + _Number + ": " + _Result);
                        break;
                    }

                case enOpType.enSubtract:
                    {
                        Console.WriteLine("Result after subtracting by " + _Number + ": " + _Result);
                        break;
                    }

                case enOpType.enMultiply:
                    {
                        Console.WriteLine("Result after multiplying by " + _Number + ": " + _Result);
                        break;
                    }

                case enOpType.enDivide:
                    {
                        Console.WriteLine("Result after dividing by " + _Number + ": " + _Result);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Result after Clearing: {0}", _Result);
                        break;
                    }
            }

        }


        public void add(int Number)
        {
            _OpName = enOpType.enAdd;
            _Number = Number;
            _PrevResult = _Result;
            _Result += _Number;

        }

        public void Subtract(int Number)
        {
            _OpName = enOpType.enSubtract;
            _Number = Number;
            _PrevResult = _Result;
            _Result -= _Number;
        }

        public void Multiply(int Number)
        {
            _OpName = enOpType.enMultiply;
            _Number = Number;
            _PrevResult = _Result;
            _Result *= _Number;
        }

        public void Divide(int Number)
        {
            if (Number == 0)
            {
                _OpName = enOpType.enDivide;
                _Number = Number;
                return;
            }

            _OpName = enOpType.enDivide;
            _Number = Number;
            _PrevResult = _Result;
            _Result /= _Number;
        }

        public void Clear()
        {
            _OpName = enOpType.enNone;
            _Number = 0;
            _PrevResult = _Result;
            _Result = _Number;
        }

       
        public void PrintResult()
        {
            _ShowResult();
        }

        public void PrintPrevResult()
        {
            Console.WriteLine("Previous Result {0}: ", _PrevResult);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsCalculator calculator = new clsCalculator();

            calculator.add(10);
            calculator.PrintResult();

            calculator.add(100);
            calculator.PrintResult();

            calculator.Subtract(20);
            calculator.PrintResult();

            calculator.Divide(0);
            calculator.PrintResult();

            calculator.Divide(2);
            calculator.PrintResult();

            calculator.Multiply(3);
            calculator.PrintResult();

            calculator.Clear();
            calculator.PrintResult();

            Console.ReadKey();

        }
    }
}
