namespace YazarveKitap2
{
    class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public Kitap(string baslik, DateTime yayinTarihi)
        {
            Baslik = baslik;
            YayinTarihi = yayinTarihi;
            Yazar = new Yazar("Haruki Murakami", "Japonya");
        }

        public void YazarAtama(Yazar yazar)
        {
            Yazar = yazar;
            yazar.KitapEkle(this);
        }
    }

    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            if (!Kitaplar.Contains(kitap))
            {
                Kitaplar.Add(kitap);
            }
        }
    }
}
