namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = default;
            while((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split();
                string name = parts[0];
                double grade = double.Parse(parts[1]);
                Student student = new Student(name, grade);
                Console.WriteLine(student);
                students.Add(student);
            }

            Sorter.InsertionSort(students, s => s.Name);
            Sorter.InsertionSort(students, s => s.Grade);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
