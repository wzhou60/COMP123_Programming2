namespace ReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileIn = new FileStream("D:\\School\\COMP123_Programming2\\W4\\W4C1\\WriteApp\\bin\\Debug\\net8.0\\myText.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileIn);
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

            reader.Close();
            fileIn.Close();
        }
    }
}