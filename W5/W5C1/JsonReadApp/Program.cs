using JsonApp;
using System.Text.Json;

namespace JsonReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString;
            FileStream fileStream = new FileStream("data.json", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            jsonString = streamReader.ReadToEnd();
            streamReader.Close();
            fileStream.Close();
            //Console.WriteLine(jsonString);
            List<WeatherForecast> weatherForecasts = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonString);
            foreach (WeatherForecast wf in weatherForecasts)
            {
                Console.WriteLine(wf);
            }
        }
    }
}