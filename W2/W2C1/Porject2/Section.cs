namespace Porject2
{
    class Section
    {
        private List<Student> students;
        public string Name { get; set; }

        public Section()
        {
            students = new List<Student>();
        }

        public List<Student> Students
        {
            get { return students; }
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public override string ToString()
        {
            string result = Name;
            foreach (Student student in students)
            {
                result = $"{result}\n{student.ToString()}";
            }
            return result;
        }
    }
}