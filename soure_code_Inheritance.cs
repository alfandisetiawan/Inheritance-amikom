using System;

namespace Latihan_Inheritance
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

        internal class Person
        {
            private string nama;
            private int usia;
            private int ID;
            private string Status;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama anda: {0},usia anda: {1} ", nama, usia, ID, Status, Email);
            public Person(string nama, int usia)
            {
                this.nama = nama;
                this.usia = usia;
            }
        }

        internal class Teacher
        {
            private string nama;
            private int usia;
            private int ID;
            private string Status;

            public void GetNameAndAge() => Console.WriteLine("Nama anda: {0},usia anda: {1},ID anda: {2},anda mengajar: {3} ", nama, usia, ID, Status);
            public Teacher(string nama, int usia, int ID, string Status)
            {
                this.nama = nama;
                this.usia = usia;
                this.ID = ID;
                this.Status = Status;
            }
        }

        internal class Student
        {
            private string nama;
            private int usia;
            private int ID;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama anda: {0},usia anda: {1},ID anda: {2},Email anda: {3} ", nama, usia, ID, Email);
            public Student(string nama, int usia, int ID, string Email)
            {
                this.nama = nama;
                this.usia = usia;
                this.ID = ID;
                this.Email = Email;
            }
        }

    }
}
