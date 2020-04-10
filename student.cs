using System;

namespace student
{
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
