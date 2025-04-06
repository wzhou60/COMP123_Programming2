namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("first", "1");
            dictionary["second"] = "2";
            Console.WriteLine(dictionary.Count);


            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}