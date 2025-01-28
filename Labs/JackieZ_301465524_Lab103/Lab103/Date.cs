namespace Lab103
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year = 2022, int month = 1, int day = 1)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            Normalize();
        }

        public override string ToString()
        {
            return $"{day}/{Enum.GetName(typeof(Months), month)}/{year}";
        }

        public void Add(int days)
        {
            for (int i = 0; i < days; i++)
            {
                this.day += 1;
                Normalize();
            }
        }

        public void Add(int days, int months)
        {
            for (int i = 0; i < months; i++)
            {
                this.month += 1;
                Normalize();
            }

            for (int i = 0; i < days; i++)
            {
                this.day += 1;
                Normalize();
            }
        }

        public void Add(Date other)
        {
            this.day += other.day;
            this.month += other.month;
            this.year += other.year;
            Normalize();
        }

        private void Normalize()
        {
            if (this.day > 30 && (this.month == 4 || this.month == 6 || this.month == 9 || this.month == 11))
            {
                this.day = 1;
                this.month += 1;
            }
            else if (this.day > 29 && (this.month == 2 && (this.year % 4 == 0) && ((this.year % 100 != 0) || (this.year % 400 == 0))))
            {
                this.day = 1;
                this.month += 1;
            }
            else if (this.day > 28 && this.month == 2 && (this.year % 4 != 0))
            {
                this.day = 1;
                this.month += 1;
            }
            else if (this.day > 31)
            {
                this.day = 1;
                this.month += 1;
            }

            if (this.month > 12)
            {
                this.month = 1;
                this.year += 1;
            }
        }
    }
}