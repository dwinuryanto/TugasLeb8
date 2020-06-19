using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap KarTap = new KaryawanTetap();
            KarTap.Nik = "123-234-345";
            KarTap.Nama = "Michael Suyama";
            KarTap.GajiBulanan = 4000000;

            KaryawanHarian KaHar= new KaryawanHarian();
            KaHar.Nik = "123-321-346";
            KaHar.Nama = "Laura Callahan";
            KaHar.JumJamKerja = 8;
            KaHar.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "123-333-347";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Upah = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(KarTap);
            listKaryawan.Add(KaHar);
            listKaryawan.Add(sales);

            int Urutan = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                    Urutan, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                Urutan++;
            }
            Console.ReadKey();
        }
    }
}