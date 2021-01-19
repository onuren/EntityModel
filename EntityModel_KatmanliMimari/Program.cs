using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriKatmani;

namespace EntityModel_KatmanliMimari
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();

            //foreach (Kategori item in dm.KategorileriListele())
            //{
            //    Console.WriteLine(item.ID + " " + item.Isim);
            //}

            //Kategori kat = new Kategori();
            //kat.Isim = "Yemek";

            //if (dm.KategoriEkle(kat))
            //{
            //    Console.WriteLine("Kategori ekleme başarılı.");
            //}
            //else
            //{
            //    Console.WriteLine("Eklenemedi.");
            //}

            //Kategori kat = new Kategori();
            //kat.ID = 6;
            //kat.Isim = "Değiştirdim";

            //if (dm.KategoriGüncelle(kat))
            //{
            //    Console.WriteLine("Güncelleme başarılı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hata oluştu.");
            //}

            //if (dm.KategoriSil(6))
            //{
            //    Console.WriteLine("Kategori silme başarılı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hata oluştu.");
            //}

            //Kategori ka = new Kategori();
            //ka = dm.KategoriGoster(4);
            //Console.WriteLine(ka.ID+" "+ka.Isim);

            //foreach (Makale item in dm.MakaleleriListele())
            //{
            //    Console.WriteLine(item.ID + " " + item.Baslik);
            //}

        }
    }
}
