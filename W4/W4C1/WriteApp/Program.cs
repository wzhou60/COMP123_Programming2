namespace WriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FileStream fileStream = new FileStream("myText.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Hello, World!");
            streamWriter.Close();
            fileStream.Close();
        }
    }
}