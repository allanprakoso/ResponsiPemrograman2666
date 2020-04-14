using System;

namespace ResponsiPemrograman2666
{
    class Karyawan
    {
        private string Nama;
        private string NIK;
        private int GajiBulanan;


        public Karyawan(string Nama, string NIK, int GajiBulanan)
        {
            this.Nama = Nama;
            this.NIK = NIK;
            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }


        public void TampilGaji()
        {
            Console.WriteLine("{0} {1}\t\t{2}", NIK , Nama, GajiBulanan);
        }

        public void TampilTambahanGaji()
        {
            HitungTambahan();
            Console.WriteLine("{0} {1}\t\t{2}", NIK, Nama, GajiBulanan);
        }

        void HitungTambahan(){
            int Tambahan = GajiBulanan * 10/100;
            GajiBulanan += Tambahan;
        }
    }
}