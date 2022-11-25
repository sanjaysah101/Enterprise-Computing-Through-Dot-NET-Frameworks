using System;

    delegate void DoubleOp(double x);
    class MathOperations
    {
        public static void MultiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine("Multiplying by 2: {0} gives {1}", value, result);
        }
        public static void Square(double value)
        {
            double result = value * value;
            Console.WriteLine("Squaring: {0} gives {1}", value, result);
        }
    }
    class MultiCastDemo
    {
        static void Main(string[] args)
        {
            DoubleOp doubleOp = new DoubleOp(MathOperations.MultiplyByTwo);
            doubleOp += MathOperations.Square;

            doubleOp(2);
        }
    }


