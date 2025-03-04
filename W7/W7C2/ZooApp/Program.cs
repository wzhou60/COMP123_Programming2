using AnimalLibrary;

namespace ZooApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal() { Name = "XX" };
            //Console.WriteLine(animal);
            List<Animal> zoo = new List<Animal>();

            Dog dog = new Dog() { Name = "Doggo" };
            Cow cow = new Cow() { Name = "Bessie" };
            Fish fish = new Fish() { Name = "Nemo" };
            Horse horse = new Horse() { Name = "Rusty" };
            Console.WriteLine(dog);
            dog.Talk();
            Console.WriteLine(cow);
            cow.Talk();

            zoo.Add(dog);
            zoo.Add(cow);
            zoo.Add(fish);
            zoo.Add(horse);
            MakeZooTalk(zoo);
            MakeZooWork(zoo);
            //MakeAnimalTalk(dog);
            //MakeAnimalTalk(cow);
            Console.WriteLine("Before Sort");
            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal);
            }

            zoo.Sort();
            Console.WriteLine("After Sort");

            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal);
            }
        }

        private static void MakeZooWork(List<Animal> zoo)
        {
            Console.WriteLine("Zoo Working");
            foreach (Animal animal in zoo)
            {
                IWorkable workable = animal as IWorkable;
                workable?.Work();
            }
        }

        private static void MakeZooTalk(List<Animal> zoo)
        {
            Console.WriteLine("Zoo Talking");
            foreach (Animal animal in zoo)
            {
                animal.Talk();
            }
        }
    }
}