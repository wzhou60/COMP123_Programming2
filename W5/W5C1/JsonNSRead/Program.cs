using Newtonsoft.Json;

namespace JsonNSRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString;
            FileStream fileStream = new FileStream("data.json", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });
            List<WeatherForecast> weatherForecasts = jsonSerializer.Deserialize(streamReader, typeof(List<WeatherForecast>)) as List<WeatherForecast>;

            fileStream.Close();
            streamReader.Close();

            // List<WeatherForecast> weatherForecasts = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonString);
            foreach (WeatherForecast wf in weatherForecasts)
            {
                Console.WriteLine(wf);
            }
        }
    }
}