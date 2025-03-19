namespace EvenNumberEventApp
{
    //  internal delegate void OnEvenCountDelegate(object originator, EventArgs number);

    internal class OnEvenCountEventArg : EventArgs
    {
        public int Number { get; }

        public OnEvenCountEventArg(int value)
        {
            Number = value;
        }
    }

    class Counter
    {
        public event EventHandler OnEvenCount;

        public string Name { get; set; }

        public void Count()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Counter: {Name}, counting {i}");

                if (i % 2 == 0)
                {
                    if (OnEvenCount != null)
                    {
                        OnEvenCountEventArg onEvenCountEventArg = new OnEvenCountEventArg(i);
                        OnEvenCount(this, onEvenCountEventArg);
                    }
                    //OnEvenCount?.Invoke(i);
                }
            }
        }
    }

    class Foo
    {
        public string Name { get; set; }

        public void DoThisOnEven(object orginator, EventArgs args)
        {
            Counter counter = orginator as Counter;
            OnEvenCountEventArg arg = args as OnEvenCountEventArg;
            Console.WriteLine($"Counter: {counter.Name}, Foo: {Name}, value is {arg.Number}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter() { Name = "Counter 1" };
            Counter counter2 = new Counter() { Name = "Counter 2" };
            counter.Count();
            counter2.Count();

            Foo foo = new Foo() { Name = "Foo 1" };
            Foo foo2 = new Foo() { Name = "Foo 2" };
            counter.OnEvenCount += foo.DoThisOnEven;
            counter.OnEvenCount += foo2.DoThisOnEven;
            counter2.OnEvenCount += foo2.DoThisOnEven;
            Console.WriteLine();
            counter.Count();
            counter2.Count();
        }
    }
}