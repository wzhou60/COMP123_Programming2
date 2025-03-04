namespace Animals
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
            Console.WriteLine(dog);
            dog.Talk();
            Console.WriteLine(cow);
            cow.Talk();

            zoo.Add(dog);
            zoo.Add(cow);
            zoo.Add(fish);
            MakeZooTalk(zoo);
            //MakeAnimalTalk(dog);
            //MakeAnimalTalk(cow);
        }

        private static void MakeZooTalk(List<Animal> zoo)
        {
            Console.WriteLine("Zoo Talking");
            foreach (Animal animal in zoo)
            {
                animal.Talk();
            }
        }

        private static void MakeAnimalTalk(Animal animal)
        {
            animal.Talk(); // Animal is a reference type.
        }
    }
}