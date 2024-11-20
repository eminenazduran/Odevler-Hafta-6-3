namespace SirketveCalisan
{
    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; }
        public Sirket(string ad, string konum) 
        {
            Ad = ad;    
            Konum = konum;
            Calisanlar = new List<Calisan>();
        }

        public void CalisanEkle(Calisan calisan)
        {
            if (!Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
            }
        }
    }
    class Calisan
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Sirket Sirket { get; set; }

        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
            sirket.CalisanEkle(this);
        }
    }
}
