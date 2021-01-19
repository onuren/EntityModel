using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani
{
    public class Kategori
    {
        public int ID { get; set; }
        public string Isim { get; set; }
    }

    public class Makale
    {
        public int ID { get; set; }
        public int KategoriID { get; set; }
        public int YazarID { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public DateTime EklemeTarih { get; set; }
        public int Begeni { get; set; }
        public int OkumaSayisi { get; set; }
        public string KapakResim { get; set; }
        public bool Durum { get; set; }
    }
}
