using System.Text.Json;

namespace FileSystemPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = File.ReadAllText("students.json");
            Students students = JsonSerializer.Deserialize<Students>(jsonString);
            
            foreach (Student student in students.students)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);
                Console.WriteLine(student.description);
            }
        }
    }
}