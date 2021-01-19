using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani
{
    //Projemiz ne olursa olsun tüm veri tabanı işlemleri bu sınıfta toplanacak
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString_VeriYolu.ConStr);
            cmd = con.CreateCommand();
        }
        #region Kategori metotları

        public List<Kategori> KategorileriListele()
        {
            List<Kategori> Kategoriler = new List<Kategori>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Kategoriler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    Kategoriler.Add(k);
                }
                return Kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriEkle(Kategori k)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler(Isim) VALUES(@Isim)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Isim", k.Isim);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriGüncelle(Kategori k)
        {
            try
            {
                cmd.CommandText = "UPDATE Kategoriler SET Isim=@isim WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", k.Isim);
                cmd.Parameters.AddWithValue("@id", k.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Kategoriler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Kategori KategoriGoster(int id)
        {
            try
            {
                Kategori k = new Kategori();
                cmd.CommandText = "SELECT ID, Isim FROM Kategoriler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                }

                return k;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Makale> MakaleleriListele()
        {
            try
            {
                List<Makale> mlist = new List<Makale>();
                cmd.CommandText = "SELECT ID,KategoriID,YazarID,Baslik,Ozet,Icerik,EklemeTarih,Begeni,OkumaSayisi,KapakResim,Durum FROM Makaleler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Makale a = new Makale();
                    a.ID = reader.GetInt32(0);
                    a.KategoriID = reader.GetInt32(1);
                    a.YazarID = reader.GetInt32(2);
                    a.Baslik = reader.GetString(3);
                    a.Ozet = reader.GetString(4);
                    a.Icerik = reader.GetString(5);
                    a.EklemeTarih = reader.GetDateTime(6);
                    a.Begeni = reader.GetInt32(7);
                    a.OkumaSayisi = reader.GetInt32(8);
                    a.KapakResim = reader.GetString(9);
                    a.Durum = reader.GetBoolean(10);
                    mlist.Add(a);
                }
                return mlist;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public bool MakaleEkle(Makale a)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Makele(ID,KategoriID,YazarID,Baslik,Ozet,Icerik,EklemeTarih,Begeni,OkumaSayisi,KapakResim,Durum) VALUES(@ID,@KategoriID,@YazarID,@Baslik,@Ozet,@Icerik,@EklemeTarih,@Begeni,@OkumaSayisi,@KapakResim,@Durum) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", a.ID);
                cmd.Parameters.AddWithValue("@KategoriID", a.KategoriID);
                cmd.Parameters.AddWithValue("@YazarID", a.YazarID);
                cmd.Parameters.AddWithValue("@Baslik", a.Baslik);
                cmd.Parameters.AddWithValue("@Ozet", a.Ozet);
                cmd.Parameters.AddWithValue("@Icerik", a.Icerik);
                cmd.Parameters.AddWithValue("@EklemeTarih", a.EklemeTarih);
                cmd.Parameters.AddWithValue("@Begeni", a.Begeni);
                cmd.Parameters.AddWithValue("@OkumaSayisi", a.OkumaSayisi);
                cmd.Parameters.AddWithValue("@KapakResim", a.KapakResim);
                cmd.Parameters.AddWithValue("@Durum", a.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool MakaleGuncelle(Makale a)
        {
            try
            {
                cmd.CommandText = "UPDATE Makaleler SET ID=@ID,KategoriID=@KategoriID,YazarID=@YazarID,Baslik=@Baslik,Ozet=@Ozet,Icerik=@Icerik,EklemeTarih=@EklemeTarih,Begeni=@Begeni,OkumaSayisi=@OkumaSayisi,KapakResim=@KapakResim,Durum=@Durum) ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", a.ID);
                cmd.Parameters.AddWithValue("@KategoriID", a.KategoriID);
                cmd.Parameters.AddWithValue("@YazarID", a.YazarID);
                cmd.Parameters.AddWithValue("@Baslik", a.Baslik);
                cmd.Parameters.AddWithValue("@Ozet", a.Ozet);
                cmd.Parameters.AddWithValue("@Icerik", a.Icerik);
                cmd.Parameters.AddWithValue("@EklemeTarih", a.EklemeTarih);
                cmd.Parameters.AddWithValue("@Begeni", a.Begeni);
                cmd.Parameters.AddWithValue("@OkumaSayisi", a.OkumaSayisi);
                cmd.Parameters.AddWithValue("@KapakResim", a.KapakResim);
                cmd.Parameters.AddWithValue("@Durum", a.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool MakaleSil(int a)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Makaleler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", a);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
