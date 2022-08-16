using HastaneOtomasyon.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HastaneOtomasyon.Business_Layer
{
    class BusinessOperations
    {
        DalOperations dalOperations = new DalOperations();

        private string kelimeFiltrele(string kelime)
        {
            //ç ğ ı ö ş ü Ç Ğ İ Ö Ş Ü 
            kelime = kelime.Trim();
            kelime = kelime.ToLower();
            kelime = kelime.Replace('ç', 'c');
            kelime = kelime.Replace('ğ', 'g');
            kelime = kelime.Replace('ı', 'i');
            kelime = kelime.Replace('ö', 'o');
            kelime = kelime.Replace('ş', 's');
            kelime = kelime.Replace('ü', 'u');
            return kelime;

        }

        public void randevulariYukle(DataGridView dataGridView)
        {
            dalOperations.randevulariYukle(dataGridView);
        }

        public void branslariYukle(ComboBox comboBox)
        {
            dalOperations.branslariYukle(comboBox);
        }

        public void doktorlariYukle(byte bransId, ComboBox doktor)
        {
            dalOperations.doktorlariYukle(bransId, doktor);
        }

        public void randevuOlustur(string hastaAdi, string hastaSoyadi, string hastaCinsiyeti, byte hastaYasi, byte hastaBransi, int hastaDoktoru, DateTime randevuTarihi)
        {
            dalOperations.randevuOlustur(kelimeFiltrele(hastaAdi),kelimeFiltrele(hastaSoyadi),kelimeFiltrele(hastaCinsiyeti), hastaYasi, hastaBransi, hastaDoktoru, randevuTarihi);
        }

        public void randevuSil(int id)
        {
            dalOperations.randevuSil(id);
        }
       
        public void randevuGuncelle(int id, string hastaAdi, string hastaSoyadi, string hastaCinsiyeti, byte hastaYasi, byte hastaBransi, int hastaDoktoru, DateTime randevuTarihi)
        {
            dalOperations.randevuGuncelle(id, kelimeFiltrele(hastaAdi), kelimeFiltrele(hastaSoyadi), kelimeFiltrele(hastaCinsiyeti), hastaYasi, hastaBransi, hastaDoktoru, randevuTarihi);
        }

        public void doktorlariYukle(DataGridView dataGridView)
        {
            dalOperations.doktorlariYukle(dataGridView);
        }

        public void doktorEkle(string doktorAdSoyad, string cinsiyet, byte brans)
        {
            dalOperations.doktorEkle(kelimeFiltrele(doktorAdSoyad), kelimeFiltrele(cinsiyet), brans);
        }

        public void doktorGuncelle(int id, string doktorAdSoyad, string cinsiyet, byte brans)
        {
            dalOperations.doktorGuncelle(id, kelimeFiltrele(doktorAdSoyad), kelimeFiltrele(cinsiyet), brans);
        }

        public void doktorSil(int id)
        {
            dalOperations.doktorSil(id);
        }

        public void branslariListele(DataGridView dataGridView)
        {
            dalOperations.branslariListele(dataGridView);
        }

        public void bransEkle(string bransAdi)
        {
            dalOperations.bransEkle(kelimeFiltrele(bransAdi));
        }

        public void bransGuncelle(byte id, string bransAdi)
        {
            dalOperations.bransGuncelle(id, kelimeFiltrele(bransAdi));
        }

        public void bransSil(byte id)
        {
            dalOperations.bransSil(id);
        }

        public void randevuTarihineGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            dalOperations.randevuTarihineGoreKucuktenBuyugeSirala(dataGridView);
        }

        public void randevuTarihineGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            dalOperations.randevuTarihineGoreBuyuktenKucugeSirala(dataGridView);
        }

        public void hastaAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView, string hastaAdi)
        {
            dalOperations.hastaAdinaGoreKucuktenBuyugeSirala(dataGridView, kelimeFiltrele(hastaAdi));
        }

        public void hastaAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView, string hastaAdi)
        {
            dalOperations.hastaAdinaGoreBuyuktenKucugeSirala(dataGridView, kelimeFiltrele(hastaAdi));
        }

        public void satirSayisi(DataGridView dataGridView, Label label)
        {
            dalOperations.satirSayisi(dataGridView, label);
        }

        public void hastaAdinaGoreArama(DataGridView dataGridView, string hastaAdi)
        {
            dalOperations.hastaAdinaGoreArama(dataGridView, kelimeFiltrele(hastaAdi));
        }

        public void bransAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            dalOperations.bransAdinaGoreKucuktenBuyugeSirala(dataGridView); 
        }

        public void bransAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            dalOperations.bransAdinaGoreBuyuktenKucugeSirala(dataGridView);
        }

        public void bransAdinaGoreArama(DataGridView dataGridView, string bransAdi)
        {
            dalOperations.bransAdinaGoreArama(dataGridView, kelimeFiltrele(bransAdi));
        }

        public void doktorAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            dalOperations.doktorAdinaGoreKucuktenBuyugeSirala(dataGridView);
        } 

        public void doktorAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            dalOperations.doktarAdinaGoreBuyuktenKucugeSirala(dataGridView);
        }

        public void doktorAdinaGoreArama(DataGridView dataGridView, string doktorAdi)
        {
            dalOperations.doktorAdinaGoreArama(dataGridView, kelimeFiltrele(doktorAdi));
        }

        public void branslaraGoreDoktorSayisi(Chart chart)
        {
            dalOperations.branslaraGoreDoktorSayisi(chart);
        }

        public void branslaraGoreRandevuSayisi(Chart chart)
        {
            dalOperations.branslaraGoreRandevuSayisi(chart);
        }

        public void doktorlarinCinsiyetDagilimi(Chart chart)
        {
            dalOperations.doktorlarinCinsiyetDagilimi(chart);
        }

        public void hastalarinCinsiyetDagilimi(Chart chart)
        {
            dalOperations.hastalarinCinsiyetDagilimi(chart);
        }

        public void hastalarinYasAraligi(Chart chart)
        {
            dalOperations.hastalarinYasAraligi(chart);
        }
    }
}
