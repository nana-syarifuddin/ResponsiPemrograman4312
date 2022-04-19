using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4312
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No. Nik \t Nama \t Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.Write("1. ");
            karyawan1.infoKaryawan();
            Console.Write("2. ");
            karyawan2.infoKaryawan();

            Console.WriteLine("\nAsyiiiiik kenaikan gaji 10%!!");

            Console.WriteLine("\nNo. Nik \t Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Console.Write("1. ");
            karyawan1.kenaikanGaji();
            Console.Write("2. ");
            karyawan2.kenaikanGaji();
            
            Console.ReadKey();
        }
    }
}
