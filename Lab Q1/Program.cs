namespace Lab_Q1
{
    class Program
    {
        static void Main()
        {
            List<Student> listStudent = new List<Student>
           {
               new Student { StudentID = 1, Name = "Harshal Thakare", TotalMarks = 450},
               new Student { StudentID = 2, Name = "Ketan Patil", TotalMarks = 380},
               new Student { StudentID = 3, Name = "Tushar Chaudhari", TotalMarks = 400},
               new Student { StudentID = 4, Name = "Harsh Chaudhari", TotalMarks = 500},
               new Student { StudentID = 5, Name = "AKash Ingale", TotalMarks = 550}
           };

            IEnumerable<Student> studentResult = from student in listStudent where student.TotalMarks > 400 select student;

            foreach (Student s in studentResult)
            {
                Console.WriteLine(s.StudentID + " " + s.Name + " " + s.TotalMarks);

            }
        }

    }
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }
}