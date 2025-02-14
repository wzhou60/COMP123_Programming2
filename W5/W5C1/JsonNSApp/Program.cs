using Newtonsoft.Json;

namespace JsonNSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherForecast weatherForecast1 = new WeatherForecast()
            {
                Date = DateTime.Parse("2024-01-01T00:00-7:00"),
                Temp = -5,
                Summary = "Cold",
                SummaryField = "Cold Cold",
                AvailableDates = new List<DateTime>
                {
                    DateTime.Parse("2024-01-01T00:00-7:00"),
                    DateTime.Parse("2024-01-02T00:00-7:00"),
                    DateTime.Parse("2024-01-03T00:00-7:00")
                },
                SummaryWords = new string[] { "Cold", "Windy", "Clear" }
            };

            WeatherForecast weatherForecast2 = new WeatherForecast()
            {
                Date = DateTime.Parse("2024-06-01T00:00-7:00"),
                Temp = -5,
                Summary = "Hot",
                SummaryField = "Hot Hot",
                AvailableDates = new List<DateTime>
                {
                    DateTime.Parse("2024-06-01T00:00-7:00"),
                    DateTime.Parse("2024-06-02T00:00-7:00"),
                    DateTime.Parse("2024-06-03T00:00-7:00")
                },
                SummaryWords = new string[] { "Hot", "Windy", "Clear" }
            };

            Console.WriteLine(weatherForecast1.ToString());
            Console.WriteLine(weatherForecast2.ToString());
            List<WeatherForecast> weatherForecasts = new List<WeatherForecast>() { weatherForecast1, weatherForecast2 };
            SaveToJson("data.json", weatherForecasts);
        }

        public static void SaveToJson(string fileName, List<WeatherForecast> weatherForecasts)
        {
            //string jsonString = JsonSerializer.Serialize(weatherForecasts);
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //            JsonSerializer jsonSerializer = JsonSerializer.Create();
            JsonSerializer jsonSerializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented });

            jsonSerializer.Serialize(sw, weatherForecasts);
            sw.Close();
            fs.Close();
        }
    }
}