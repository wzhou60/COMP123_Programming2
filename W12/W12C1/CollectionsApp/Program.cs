using System.Collections;

namespace CollectionsApp
{
    class Foo() : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();

            Foo foo = new Foo();
            foreach (object item in foo)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}