using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_static
{
    internal class Mahasiswa
    {

        private static int jumlahMahasiswa = 0;
        private int nim;
        private string nama;
        private int umur;

        public Mahasiswa(int nim, string nama, int umur)
        {
            this.nim = nim;
            this.nama = nama;
            this.umur = umur;
            jumlahMahasiswa++; 
        }

        public static int JumlahMahasiswa 
        {
            get { return jumlahMahasiswa; }
        }

        public int NIM 
        {
            get { return nim; }
        }

        public string Nama 
        {
            get { return nama; }
        }

        public int Umur 
        {
            get { return umur; }
        }
    }
}
