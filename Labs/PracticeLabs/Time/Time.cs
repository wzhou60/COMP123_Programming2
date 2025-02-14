namespace Time
{
    internal class Time
    {
        private static TimeFormat TIME_FORMAT { get; set; } = TimeFormat.Hour12;
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour = 0, int minute = 0)
        {
            if (hour < 0 || hour > 23)
            {
                Hour = 0;
            }
            else
            {
                Hour = hour;
            }

            if (minute < 0 || minute > 59)
            {
                Minute = 0;
            }
            else
            {
                Minute = minute;
            }
        }

        public override string ToString()
        {
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    return $"{Hour:D2}{Minute:D2}";

                case TimeFormat.Hour12:
                    return $"{Hour:D2}:{Minute:D2}";

                case TimeFormat.Hour24:
                    return $"{Hour:D2}:{Minute:D2} {(Hour > 12 ? "PM" : "AM")} ";

                default:
                    return $"Wrong? {Hour:D2}:{Minute:D2}";
            }
        }

        public static void SetTimeFormat(TimeFormat time_format)
        {
            TIME_FORMAT = time_format;
        }
    }
}