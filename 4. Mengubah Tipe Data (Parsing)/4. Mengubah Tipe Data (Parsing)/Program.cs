using System;

namespace _4._Mengubah_Tipe_Data__Parsing_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Parsing data variable adalah teknik mengubah jenis tipe data variable.
            Contoh tipe data umur string diubah ke integer agar bisa menghasilkan
            variable umur bertipe data integer bukan lagi string.
             */
            int umur = 17;
            float rupiah = 100.005f;
            Console.WriteLine(umur.ToString());
            Console.WriteLine(rupiah.ToString());

            Console.ReadKey();
        }
    }
}
