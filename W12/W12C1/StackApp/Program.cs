namespace StackApp
{
    class Stack<T>
    {
        private T[] items;
        private int top = 0;

        public Stack(int size)
        {
            items = new T[size];
        }

        public T Pop()
        {
            return items[--top];
        }

        public void Push(T item)
        {
            items[top++] = item;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>(4);

            myStack.Push("1");
            myStack.Push("26");
            myStack.Push("Three");
            myStack.Push("Hello");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            List<int> list = new List<int>();
        }
    }
}