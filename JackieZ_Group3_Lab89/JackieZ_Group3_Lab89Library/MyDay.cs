 

namespace JackieZ_Group3_Lab89Library 
{
    public class MyDay
    {
        private static MyDay currentDay;
        private DateTime date;
        private List<Task> todaysTasks;

        public List<Task> TodaysTasks
        {
            get { return todaysTasks; }
        }

        public void AddDayTask(Task task)
        {
            todaysTasks.Add(task);
        }

        private MyDay()
        {
            date = DateTime.Today;
            todaysTasks = new List<Task>();
        }

        public static MyDay NewDay()
        {
            if (currentDay == null || currentDay.date != DateTime.Today)
            {
                currentDay = new MyDay();
            }
            return currentDay;
        }

        public override string ToString()
        {
            string result = $"All Tasks for {date}: ";
            foreach (Task task in todaysTasks)
            {
                result += $"\n{task}, ";
            }
            return result;
        }
    }
}