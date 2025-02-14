using Newtonsoft.Json;

namespace JsonNSRead
{
    internal class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int Temp { get; set; }
        public string Summary { get; set; }

        //[JsonInclude]
        public string SummaryField;

        //[JsonIgnore]
        public List<DateTime> AvailableDates { get; set; }

        public string[] SummaryWords { get; set; }

        public override string ToString()
        {
            return $"Date: {Date}, Temp: {Temp}, Summary: {Summary}, SummaryField: {SummaryField}";
        }
    }
}