using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4312
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;

            if (gaji < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gaji;
            }
        }

        public void infoKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }

        public void kenaikanGaji()
        {
            int gaji = 0;
            gaji = (10 * GajiBulanan) / 100;
            GajiBulanan = GajiBulanan + Convert.ToInt32(gaji);
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }
    }
}
