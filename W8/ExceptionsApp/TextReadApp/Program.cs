namespace TextReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileIn = null;
            StreamReader reader = null;
            try
            {
                fileIn = new FileStream("", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileIn);

                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception)
            {
                Console.WriteLine("File not found");
            }
            finally //executes no matter what (unless u get an exception)
            {
                reader?.Close();
                fileIn?.Close();
            }
           
        }
    }
}