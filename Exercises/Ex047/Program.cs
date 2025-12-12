// https://github.com/acenelio/set2-csharp
using Ex047.Entities;

namespace Ex047
{
    class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = { new Course("A"), new Course("B"), new Course("C") };
            HashSet<int> totalStudent = new HashSet<int>();
            foreach (Course course in courses)
            {
                Console.Write($"How many students for course {course.Name}? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int student = int.Parse(Console.ReadLine());
                    course.Students.Add(student);
                }
                totalStudent.UnionWith(course.Students);
            }
            Console.WriteLine("Total students: " + totalStudent.Count);
        }
    }
}