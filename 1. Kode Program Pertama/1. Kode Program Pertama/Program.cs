using System;

namespace _1._Kode_Program_Pertama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi dua variable integer untuk
            //menampung kedua angka yang akan dijumlahkan
            //dan satu variable interger untuk menampung hasil

            int a;
            int b;
            int result;

            //Memasukan angka pada kedua variable integer
            a = 10;
            b = 5;

            //Menjumlahkan dua interger dan menampung hasil ke variable
            result = (a + b); //assignment

            //Menampilkan hasilnya didalam console
            Console.WriteLine("Hasil : {0}", result.ToString());
            Console.ReadKey();
        }
    }
}
