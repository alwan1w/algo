using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variabel int untuk menyimpan banyak data pada array
        private int n;

        // Fungsi / method untuk menerima masukan
        public void read()
        {
            //menrima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukkan elemen pada party 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
             Console.WriteLine("");
             Console.WriteLine("-----------------------------------");
             Console.WriteLine(" Element array yang telah tersusun ");
             Console.WriteLine("-----------------------------------");
             for (int j = 0; j < n; j++)
             {
                 Console.WriteLine(a[j]);
             }
             Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 0; i < n; i++) // For n - 1 passes
            {
                //pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                     if (a[j] > a[j + 1])// jika elemen tidak dalam urutan yang benar
                     {
                         // tukar elemen
                         int temp;
                         temp = a[j];
                         a[j] = a[j + 1];
                         a[j + 1] = temp;
                     }
                }
            }
        }
        static void Main(string[] args)
        {
                //creating the object of the bubblesort class
                Program myList = new Program();
                // pemanggilan fungsi untuk menerima elemen array
                myList.read();
                // pemanggilan fungsi untuk mengurutkan array
                myList.BubbleSortArray();
                // pemanggilan fungsi untuk menampilkan array yang sudah tersusun
                myList.display();
                //exit
                Console.WriteLine("\n\nTekan Tombol Apa saja Untuk Keluar.");
                Console.Read();

        }
    }
}
