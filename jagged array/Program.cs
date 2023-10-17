
namespace jagged_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student[][] squad19 = new Student[3][];

            squad19[0] = new Student[3] {
                                          new Student { Id = 1, Name = "Bisi" },
                                          new Student {Id = 2,  Name = "Bola"},
                                          new Student {Id =3,   Name = "Tomi"}
                                          };

            squad19[1] = new Student[2] {
                                          new Student { Id = 1, Name = "Bisi" },
                                          new Student {Id = 2,  Name = "Bola"}
                                          };

            squad19[2] = new Student[1] {
                                        new Student {Id = 1,  Name = "Bola"}
                                        };

            var java = squad19[0];
            var dotnet = squad19[1];
            var node = squad19[2];

            Console.WriteLine("\nJava Devs");
            Console.WriteLine("----------------------------------");
            foreach (Student student in java)
            {
                Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
            }

            Console.WriteLine("\nDotNet Devs");
            Console.WriteLine("----------------------------------");
            foreach (Student student in dotnet)
            {
                Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
            }

            Console.WriteLine("\nNode Devs");
            Console.WriteLine("----------------------------------");
            foreach (Student student in node)
            {
                Console.WriteLine($"Student Id: {student.Id}, Student Name {student.Name}");
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}