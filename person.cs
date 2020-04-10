using System;

namespace person
{
    
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
    
}
