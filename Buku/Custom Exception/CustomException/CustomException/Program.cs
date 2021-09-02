using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input nilai untuk menghiting akar kuadrat : ");
                double readNilai = Convert.ToDouble(Console.ReadLine());
                double hasilNilai = akarKuadrat(readNilai);

                Console.WriteLine("Akar kuadrat dari {0} adalah {1:F6}\n",
                    readNilai, hasilNilai);
            }
            catch (FormatException eksepsiFormat)
            {
                Console.WriteLine("\n" + eksepsiFormat.Message);
                Console.WriteLine("Input nilai type double.\n");
            }
            catch (AngkaNegatifException angkaNegatifException)
            {
                Console.WriteLine("\n" + angkaNegatifException.Message);
                Console.WriteLine("Input nilai tak-negatif.\n");
            }
        }


        /*
         Menghitung akar kuadrat dari parameter.
        AngkaNegatifException akan dieksekusi jika parameter benilai negatif
         */
        public static double akarKuadrat(double nilai)
        {
            if (nilai < 0)
                throw new AngkaNegatifException("Akar kuadrat dari angka negatif tidak diijinkan");
            else
                return Math.Sqrt(nilai);
        }
    }
}
