namespace FunctionDelegateApp
{
    class AddFunc
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {result}");
        }
    }

    class MultiplyFunc
    {
        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"The product of {a} and {b} is {result}");
        }
    }

    class SubFunc
    {
        public static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"The difference of {a} and {b} is {result}");
        }
    }

    class MathOp
    {
        public delegate void Operation(int a, int b);

        private int first;
        private int second;

        public Operation Func;

        public void Invoke()
        {
            if (Func != null) Func(first, second);
        }

        public MathOp(int a, int b)
        {
            first = a;
            second = b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOp mo = new MathOp(50, 30);
            mo.Func = AddFunc.Add;
            mo.Invoke();
            Console.WriteLine();
            mo.Func += MultiplyFunc.Multiply;
            mo.Func += SubFunc.Subtract;
            mo.Invoke();
            mo.Func -= AddFunc.Add;
            Console.WriteLine();
            mo.Invoke();

        }
    }
}