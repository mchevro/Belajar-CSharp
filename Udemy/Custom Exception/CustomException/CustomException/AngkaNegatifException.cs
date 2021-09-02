using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class AngkaNegatifException : Exception
    {
        //konstruktor default
        public AngkaNegatifException() : base("Operasi Ilegal untuk sebuang angka negatif")
        {

        }//akhir konstruktor default

        //konstruktor untuk memodifikasi pesan erorr
        public AngkaNegatifException(string errorPesan) : base(errorPesan)
        {

        }//akhir konstruktor satu argumen

        /*
         konstruktor untuk memodifikasi pesan error
         dan menetapkan objek InnerException
        */
        public AngkaNegatifException(string errorPesan, Exception inner) : base(errorPesan, inner)
        {

        }//akhir konstruktor dua argumen
    }
}
