using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.nim = "1234";
            mhs1.nama = "Erik";
            mhs1.nilai = 75;

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.nim = "1235";
            mhs2.nama = "Wely";
            mhs2.nilai = 80;

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.nim = "1236";
            mhs3.nama = "Sony";
            mhs3.nilai = 95;

            Mahasiswa[] arrayMhs = new Mahasiswa[3];
            arrayMhs[0] = mhs1;
            arrayMhs[1] = mhs2;
            arrayMhs[2] = mhs3;

            Console.WriteLine("No.  Nim     Nama    Nilai");
            Console.WriteLine("==========================");
            for (int i = 0; i < arrayMhs.Length; i++)
            {
                Mahasiswa mhs = arrayMhs[i];
                Console.WriteLine("{0}.   {1}    {2}    {3}", i+1, mhs.nim, mhs.nama, mhs.nilai);
            }
            Console.ReadKey();
        }

        void latihan() {
            string[] arrayNama = { "erick", "wely", "sony", "joni" };

            Console.WriteLine(arrayNama[2]);
            Console.WriteLine();

            for (int i = 0; i < arrayNama.Length; i++)
            {
                Console.WriteLine(arrayNama[i]);
            }
            Console.WriteLine();

            foreach (string nama in arrayNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();


            int[] arrayBil = new int[3];
            arrayBil[0] = 12;
            arrayBil[1] = 14;
            arrayBil[2] = 24;

            foreach (int bil in arrayBil)
            {
                Console.WriteLine("" + bil);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
