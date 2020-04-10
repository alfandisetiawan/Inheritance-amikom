using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("zaenudin ali", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("komari", 25, 12345, "pemrogaman");
            teacher.GetNameAndAge();

            Student student = new Student("alfandi", 17, 2713, "alfandi.2713@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
