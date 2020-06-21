using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance, Polymorphsim, Abstraction & Collection";

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "111-222-333";
            karyawanHarian.Name = "Jatmiko Saputro";
            karyawanHarian.UpahPerJam = 15000;
            karyawanHarian.JumlahJamKerja = 10;

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "111-324-451";
            karyawanTetap.Name = "Suyatmi";
            karyawanTetap.GajiBulanan = 5000000;

            Sales sales = new Sales();
            sales.NIK = "125-354-332";
            sales.Name = "Bima Putra";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 100000;


            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

			//show
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}
