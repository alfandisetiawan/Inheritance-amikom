using System;

namespace teacher
{
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
}

