using System;

namespace ResponsiPemrograman2666
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Allan", "19112666", 2000000);
            Karyawan karyawan2 = new Karyawan("Jati", "19112667", 1000000);

            Console.WriteLine("NIK/Nama\t\tGajiBulanan");
            karyawan1.TampilGaji();
            karyawan2.TampilGaji();

            Console.WriteLine("\nYeay Tambahan Gaji 10%!!\n");
            Console.WriteLine("NIK/Nama\t\tGajiBulanan");
            karyawan1.TampilTambahanGaji();
            karyawan2.TampilTambahanGaji();
        }
    }
}
