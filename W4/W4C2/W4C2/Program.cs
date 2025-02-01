namespace W4C2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of 3 students in a list
            // write to txt file, name of text of file is given by user
            // read from file and then print
            string fileName;

            Student student1 = new Student(123, "John");
            Student student2 = new Student(456, "Jane");
            Student student3 = new Student(789, "Joe");

            List<Student> studentsList = new List<Student>();
            studentsList.Add(student1);
            studentsList.Add(student2);
            studentsList.Add(student3);

            Console.Write("Enter the name of the text file: ");
            fileName = Console.ReadLine();
            FileStream fileStream = new FileStream($"{fileName}.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            foreach (Student student in studentsList)
            {
                //streamWriter.WriteLine(student);
                streamWriter.WriteLine($"{student.Id},{student.Name},{student.IsInternational}");
            }
            streamWriter.Close();
            fileStream.Close();

            //recreate the list

            List<Student> readList = new List<Student>();
            FileStream readStream = new FileStream($"{fileName}.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(readStream);
            string line = streamReader.ReadLine();
            string[] fields;
            while (line != null)
            {
                fields = line.Split(",");
                //Console.WriteLine(line);
                readList.Add(new Student(Convert.ToInt32(fields[0]), fields[1]) { IsInternational = Convert.ToBoolean(fields[2]) });
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            readStream.Close();

            foreach (Student student in readList)
            {
                Console.WriteLine(student);
            }
        }
    }
}