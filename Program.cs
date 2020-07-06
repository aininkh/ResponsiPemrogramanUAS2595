using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");

        }

        static void TambahProduk()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Tambah Data Produk\n");
            Produk produk = new Produk();
            Console.Write("Kode Produk : ");
            produk.kodeproduk = Console.ReadLine();

            Console.Write("Nama Produk : ");
            produk.namaproduk = Console.ReadLine();

            Console.Write("Harga Beli : ");
            produk.hargabeli = Convert.ToDouble(Console.ReadLine());

            Console.Write("Harga Jual : ");
            produk.hargajual = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(produk);
            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
            int no = -1, hps = -1;
            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();

            foreach(Produk produk in daftarProduk)
            {
                no++;
                if(produk.kodeproduk == kode)
                {
                    hps = no;
                }
            }

            if(hps != -1)
            {
                daftarProduk.RemoveAt(hps);
                Console.WriteLine("\nData Produk berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int nourut = 0;

            Console.WriteLine("Data Produk\n");

            foreach (Produk produk in daftarProduk)
            {
                nourut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:N0}", nourut, produk.kodeproduk, produk.namaproduk, produk.hargabeli, produk.hargajual);
            }

            if (nourut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
