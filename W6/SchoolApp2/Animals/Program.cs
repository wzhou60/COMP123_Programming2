
namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal() { Name = "XX" };
            //Console.WriteLine(animal);

            Dog dog = new Dog() { Name = "Doggo" };
            Cow cow = new Cow() { Name = "Bessie" };
            Console.WriteLine(dog);
            dog.Talk();
            Console.WriteLine(cow);
            cow.Talk();

            MakeAnimalTalk(dog);
            MakeAnimalTalk(cow);
        }

        private static void MakeAnimalTalk(Animal animal)
        {
            animal.Talk(); // Animal is a reference type.
        }
    }
}