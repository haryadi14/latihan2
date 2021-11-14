using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204026
{
    class Program
    {
        static void Main(string[] args)
        {
            barang barangsaya;
            barangsaya = new barang();
            barangsaya.nama = "Celana";
            barangsaya.jumlahbarang = 5;
            barangsaya.hargabarang = 40000;
            Console.WriteLine("ADI STORE");
            Console.WriteLine("nama barang  = {0}", barangsaya.nama);
            Console.WriteLine("jumlah barang yang dibeli = {0} ", barangsaya.jumlahbarang);
            Console.WriteLine("harga barangnya adalah {0} Rupiah", barangsaya.hargabarang);

            


        }
    }
}
