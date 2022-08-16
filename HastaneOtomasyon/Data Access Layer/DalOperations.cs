using HastaneOtomasyon.Data_Access_Layer.Context;
using HastaneOtomasyon.Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HastaneOtomasyon.Data_Access_Layer
{
    class DalOperations
    {

        public void randevulariYukle(DataGridView dataGridView)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var randevular = (from r in context.Randevular
                                 join
                                    d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                 join
                                    b in context.Branslar on r.HastaBransi equals b.BransId
                                 select new
                                 {
                                     RandevuId = r.RandevuId,
                                     HastaAdi = r.HastaAdi,
                                     HastaSoyadi = r.HastaSoyadi,
                                     HastaCinsiyeti = r.HastaCinsiyeti,
                                     HastaYasi = r.HastaYasi,
                                     HastaBransi = b.BransAdi,
                                     HastaDoktoru = d.DoktorAdi,
                                     RandevuTarihi = r.RandevuTarihi,
                                     
                                 }).ToList();

                dataGridView.DataSource = randevular;
                                 

            }
        }

        public void branslariYukle(ComboBox comboBox)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var branslar = (from b in context.Branslar
                                select new
                                {
                                    BransAdi = b.BransAdi,
                                    BransId = b.BransId
                                }
                                ).ToList();
                comboBox.DisplayMember = "BransAdi";
                comboBox.ValueMember = "BransId";
                comboBox.DataSource = branslar;
            }
        }

        public void doktorlariYukle(byte bransId,ComboBox doktor)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var doktorlar = (from d in context.Doktorlar
                                 where d.DoktorBransi.Equals(bransId)
                                 select new
                                 {
                                    DoktorId=d.DoktorId,
                                    DoktorAdi= d.DoktorAdi
                                 }
                                 ).ToList();

                doktor.DisplayMember = "DoktorAdi";
                doktor.ValueMember = "DoktorId";
                doktor.DataSource = doktorlar;
       
            }
        }
        
        public void randevuOlustur(string hastaAdi, string hastaSoyadi, string hastaCinsiyeti,byte hastaYasi, byte hastaBransi, int hastaDoktoru, DateTime randevuTarihi)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                Randevu randevu = new Randevu {
                    HastaAdi = hastaAdi,
                    HastaSoyadi = hastaSoyadi,
                    HastaCinsiyeti = hastaCinsiyeti,
                    HastaYasi = hastaYasi,
                    HastaBransi = hastaBransi,
                    HastaDoktoru = hastaDoktoru,
                    RandevuTarihi = randevuTarihi,
                    
                };
                context.Randevular.Add(randevu);
                context.SaveChanges();
            }
        } 

        public void randevuSil(int id)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var randevu = context.Randevular.Find(id);
                context.Randevular.Remove(randevu);
                context.SaveChanges();
            }
        } 
 

        public void randevuGuncelle(int id, string hastaAdi, string hastaSoyadi, string hastaCinsiyeti, byte hastaYasi, byte hastaBransi, int hastaDoktoru, DateTime randevuTarihi)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var randevu = context.Randevular.Find(id);
                randevu.HastaAdi = hastaAdi;
                randevu.HastaSoyadi = hastaSoyadi;
                randevu.HastaCinsiyeti = hastaCinsiyeti;
                randevu.HastaYasi = hastaYasi;
                randevu.HastaBransi = hastaBransi;
                randevu.HastaDoktoru = hastaDoktoru;
                randevu.RandevuTarihi = randevuTarihi;

                context.SaveChanges();
            }
        } 

        public void doktorlariYukle(DataGridView dataGridView)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var doktorlar = (from d in context.Doktorlar join b in context.Branslar on
                                 d.DoktorBransi equals b.BransId
                                 select new
                                 {
                                     DoktorId = d.DoktorId,
                                     DoktorAdi = d.DoktorAdi,
                                     DoktorCinsiyeti = d.DoktorCinsiyeti,
                                     DoktorBransi = b.BransAdi 
                                 }).ToList();

                dataGridView.DataSource = doktorlar;
                          

            }
        } 

        public void doktorEkle(string doktorAdSoyad,string cinsiyet,byte brans)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                Doktor doktor = new Doktor
                {
                    DoktorAdi = doktorAdSoyad,
                    DoktorCinsiyeti = cinsiyet,
                    DoktorBransi = brans
                };

                context.Doktorlar.Add(doktor);
                context.SaveChanges();
            }
        } 

        public void doktorGuncelle(int id,string doktorAdSoyad,string cinsiyet,byte brans)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var doktor = context.Doktorlar.Find(id);
                doktor.DoktorAdi = doktorAdSoyad;
                doktor.DoktorCinsiyeti = cinsiyet;
                doktor.DoktorBransi = brans;

                context.SaveChanges();
            }
        } 

        public void doktorSil(int id)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var doktor = context.Doktorlar.Find(id);
                context.Doktorlar.Remove(doktor);
                context.SaveChanges();
            }
        } 

        public void branslariListele(DataGridView dataGridView)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var branslar = (from b in context.Branslar
                                select new
                                {
                                    BransId = b.BransId,
                                    BransAdi = b.BransAdi
                                }).ToList();
                dataGridView.DataSource = branslar;
            }
        } 

        public void bransEkle(string bransAdi)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                Brans brans = new Brans
                {
                    BransAdi = bransAdi
                };
                context.Branslar.Add(brans);
                context.SaveChanges();
            }
        }
        
        public void bransGuncelle(byte id, string bransAdi)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var brans = context.Branslar.Find(id);
                brans.BransAdi = bransAdi;
                context.SaveChanges();
            }
        } 

        public void bransSil(byte id)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var brans = context.Branslar.Find(id);
                context.Branslar.Remove(brans);
                context.SaveChanges();
            }
        } 

        public void randevuTarihineGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            using(var context = new HastaneOtomasyonContext())
            {
           
                    var randevular = (from r in context.Randevular
                                      join
                                         d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                      join
                                         b in context.Branslar on r.HastaBransi equals b.BransId
                                      orderby r.RandevuTarihi ascending
                                      select new
                                      {
                                          RandevuId = r.RandevuId,
                                          HastaAdi = r.HastaAdi,
                                          HastaSoyadi = r.HastaSoyadi,
                                          HastaCinsiyeti = r.HastaCinsiyeti,
                                          HastaYasi = r.HastaYasi,
                                          HastaBransi = b.BransAdi,
                                          HastaDoktoru = d.DoktorAdi,
                                          RandevuTarihi = r.RandevuTarihi,

                                      }).ToList();

                    dataGridView.DataSource = randevular;
            }
        }

        public void randevuTarihineGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var randevular = (from r in context.Randevular
                                  join
                                     d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                  join
                                     b in context.Branslar on r.HastaBransi equals b.BransId
                                  orderby r.RandevuTarihi descending
                                  select new
                                  {
                                      RandevuId = r.RandevuId,
                                      HastaAdi = r.HastaAdi,
                                      HastaSoyadi = r.HastaSoyadi,
                                      HastaCinsiyeti = r.HastaCinsiyeti,
                                      HastaYasi = r.HastaYasi,
                                      HastaBransi = b.BransAdi,
                                      HastaDoktoru = d.DoktorAdi,
                                      RandevuTarihi = r.RandevuTarihi,

                                  }).ToList();

                dataGridView.DataSource = randevular;
            }
        } 

        public void hastaAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView, string hastaAdi)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var randevular = (from r in context.Randevular
                                  join
                                     d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                  join
                                     b in context.Branslar on r.HastaBransi equals b.BransId
                                  orderby r.HastaAdi ascending
                                  select new
                                  {
                                      RandevuId = r.RandevuId,
                                      HastaAdi = r.HastaAdi,
                                      HastaSoyadi = r.HastaSoyadi,
                                      HastaCinsiyeti = r.HastaCinsiyeti,
                                      HastaYasi = r.HastaYasi,
                                      HastaBransi = b.BransAdi,
                                      HastaDoktoru = d.DoktorAdi,
                                      RandevuTarihi = r.RandevuTarihi,

                                  }).ToList();

                dataGridView.DataSource = randevular;
            }
        } 

        public void hastaAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView, string hastaAdi)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var randevular = (from r in context.Randevular
                                  join
                                     d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                  join
                                     b in context.Branslar on r.HastaBransi equals b.BransId
                                  orderby r.HastaAdi descending
                                  select new
                                  {
                                      RandevuId = r.RandevuId,
                                      HastaAdi = r.HastaAdi,
                                      HastaSoyadi = r.HastaSoyadi,
                                      HastaCinsiyeti = r.HastaCinsiyeti,
                                      HastaYasi = r.HastaYasi,
                                      HastaBransi = b.BransAdi,
                                      HastaDoktoru = d.DoktorAdi,
                                      RandevuTarihi = r.RandevuTarihi,

                                  }).ToList();

                dataGridView.DataSource = randevular;
            }
        } 

        public void satirSayisi(DataGridView dataGridView, Label label)
        {
            label.Text = dataGridView.RowCount.ToString()+"   sonuç görüntüleniyor...";
        }  

        public void  hastaAdinaGoreArama(DataGridView dataGridView, string hastaAdi)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var randevular = (from r in context.Randevular
                                  join
                                     d in context.Doktorlar on r.HastaDoktoru equals d.DoktorId
                                  join
                                     b in context.Branslar on r.HastaBransi equals b.BransId
                                  where r.HastaAdi.Contains(hastaAdi)
                                  select new
                                  {
                                      RandevuId = r.RandevuId,
                                      HastaAdi = r.HastaAdi,
                                      HastaSoyadi = r.HastaSoyadi,
                                      HastaCinsiyeti = r.HastaCinsiyeti,
                                      HastaYasi = r.HastaYasi,
                                      HastaBransi = b.BransAdi,
                                      HastaDoktoru = d.DoktorAdi,
                                      RandevuTarihi = r.RandevuTarihi,

                                  }).ToList();

                dataGridView.DataSource = randevular;
            }
        } 

        public void bransAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var branslar = (from b in context.Branslar
                                orderby b.BransAdi ascending
                                  select new
                                  {
                                      BransId = b.BransId,
                                      BransAdi = b.BransAdi

                                  }).ToList();

                dataGridView.DataSource = branslar;
            }
        }

        public void bransAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var branslar = (from b in context.Branslar
                                orderby b.BransAdi descending
                                select new
                                {
                                    BransId = b.BransId,
                                    BransAdi = b.BransAdi

                                }).ToList();

                dataGridView.DataSource = branslar;
            }
        }

        public void bransAdinaGoreArama(DataGridView dataGridView, string bransAdi)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var branslar = (from b in context.Branslar
                                where b.BransAdi.Contains(bransAdi)
                                select new
                                {
                                    BransId = b.BransId,
                                    BransAdi = b.BransAdi

                                }).ToList();

                dataGridView.DataSource = branslar;
            }
        } 

        public void doktorAdinaGoreKucuktenBuyugeSirala(DataGridView dataGridView)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var doktorlar = (from d in context.Doktorlar
                                orderby d.DoktorAdi ascending
                                select new
                                {
                                    DoktorId = d.DoktorId,
                                    DoktorAdi = d.DoktorAdi

                                }).ToList();

                dataGridView.DataSource = doktorlar;
            }
        } 

        public void doktarAdinaGoreBuyuktenKucugeSirala(DataGridView dataGridView)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var doktorlar = (from d in context.Doktorlar
                                 orderby d.DoktorAdi descending
                                 select new
                                 {
                                     DoktorId = d.DoktorId,
                                     DoktorAdi = d.DoktorAdi

                                 }).ToList();

                dataGridView.DataSource = doktorlar;
            }
        } 

        public void doktorAdinaGoreArama(DataGridView dataGridView,string doktorAdi)
        {
            using (var context = new HastaneOtomasyonContext())
            {

                var branslar = (from d in context.Doktorlar
                                where d.DoktorAdi.Contains(doktorAdi)
                                select new
                                {
                                    DoktorId = d.DoktorId,
                                    DoktorAdi = d.DoktorAdi

                                }).ToList();

                dataGridView.DataSource = branslar;
            }
        }

        public void branslaraGoreDoktorSayisi(Chart chart)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var liste = from b in context.Branslar
                             join d in context.Doktorlar on
                             b.BransId equals d.DoktorBransi
                             group b by b.BransAdi
                            into g
                             select new
                             {
                                 BransAdi = g.Key,
                                 Toplam = g.Count()
                             };


                foreach (var temp in liste.ToList())
                {
                    chart.Series["Seri"].Points.AddXY(temp.BransAdi+"  ("+temp.Toplam+" doktor)", temp.Toplam);
                }
            }

        }

        public void branslaraGoreRandevuSayisi(Chart chart)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var liste = from r in context.Randevular
                            join b in context.Branslar on
                            r.HastaBransi equals b.BransId
                            group r by b.BransAdi
                            into g
                            select new
                            {
                                BransAdi = g.Key,
                                Toplam = g.Count()
                            };
                    
                foreach(var temp in liste)
                {
                    chart.Series["Seri"].Points.AddXY(temp.BransAdi+" ("+temp.Toplam+" randevu)",temp.Toplam);
                }
            }
        }

        public void doktorlarinCinsiyetDagilimi(Chart chart)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var cinsiyet = from d in context.Doktorlar
                               group d by d.DoktorCinsiyeti
                               into g
                               select new
                               {
                                   DoktorCinsiyeti = g.Key,
                                   Toplam = g.Count()
                               };
                foreach(var item in cinsiyet.ToList())
                {
                    chart.Series["Seri"].Points.AddXY(item.DoktorCinsiyeti, item.Toplam);
                }
            }
        }

        public void hastalarinCinsiyetDagilimi(Chart chart)
        {
            using (var context = new HastaneOtomasyonContext())
            {
                var cinsiyet = from d in context.Randevular
                               group d by d.HastaCinsiyeti
                               into g
                               select new
                               {
                                   DoktorCinsiyeti = g.Key,
                                   Toplam = g.Count()
                               };
                foreach (var item in cinsiyet.ToList())
                {
                    chart.Series["Seri"].Points.AddXY(item.DoktorCinsiyeti, item.Toplam);
                }
            }
        } 

        public void hastalarinYasAraligi(Chart chart)
        {
            using(var context = new HastaneOtomasyonContext())
            {
                var aralik018 = from r in context.Randevular
                             where r.HastaYasi >= 0 && r.HastaYasi <= 18
                             select r;
                var aralik1830 = from r in context.Randevular
                                where r.HastaYasi >18 && r.HastaYasi <= 30
                                select r;

                var aralik3045 = from r in context.Randevular
                                where r.HastaYasi > 30 && r.HastaYasi <= 45
                                select r;

                var aralik4565 = from r in context.Randevular
                                where r.HastaYasi >45 && r.HastaYasi <= 65
                                select r;

                var aralik65Ustu = from r in context.Randevular
                                where r.HastaYasi > 65
                                select r;

                if (aralik018.Count() > 0)
                {
                    chart.Series["Seri"].Points.AddXY("0 - 18 yaş arası: " + aralik018.Count() + " kişi", aralik018.Count());
                }


                if (aralik1830.Count() > 0)
                {
                    chart.Series["Seri"].Points.AddXY("18 - 30 yaş arası: " + aralik1830.Count() + " kişi", aralik1830.Count());
                }


                if (aralik3045.Count() > 0)
                {
                    chart.Series["Seri"].Points.AddXY("30 - 45 yaş arası: " + aralik3045.Count() + " kişi", aralik3045.Count());
                }

                if (aralik4565.Count()>0)
                {
                    chart.Series["Seri"].Points.AddXY("45 - 65 yaş arası: " + aralik4565.Count() + " kişi", aralik4565.Count());
                }

                if (aralik65Ustu.Count() > 0)
                {
                    chart.Series["Seri"].Points.AddXY("65 yaş üstü: " + aralik65Ustu.Count() + " kişi", aralik65Ustu.Count());
                }
            }
        }
    }
    }

