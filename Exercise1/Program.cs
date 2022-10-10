using System;

namespace Exercise1
{
    class Program
    {
        // Deklarasi array int "attar" dengan ukuran 33
        private int[] attar = new int[33];
        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Method untuk menerima masukkan
        public void read()
        {
            // menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya element pada Array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 33)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 33 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("------------------------");

            // Pengguna memasukkan element pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                attar[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-------------------------------------");
            for (int tf = 0; tf < n; tf++)
            {
                Console.WriteLine(attar[tf]);
            }
            Console.WriteLine("");
        }

        public void InsertSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int tf = 0; tf < n; tf++)
                {
                    if (attar[tf] > attar[tf + 1])
                    {
                        int temp;
                        temp = attar[tf];
                        attar[tf] = attar[tf + 1];
                        attar[tf + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Membuat object dari InsertSortArray class
            Program mylist = new Program();
            // Pemanggilan fungsi untuk menerima element array
            mylist.read();
            // Pemanggilan fungsi untuk mengurutkan array
            mylist.InsertSortArray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Enter Untuk Keluar.");
            Console.Read();
        }
    }
}