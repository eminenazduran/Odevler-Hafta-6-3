namespace UrunveSiparis
{

    class Siparis
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }

        public Siparis(DateTime tarih, decimal toplam)
        {
            Toplam = toplam;
            Tarih = tarih;
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        private int Fiyat { get; set; }

        public Urun(string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public void UrunBilgisi()
        {
            Console.WriteLine($"Ürün adı: {Ad} , Fiyat: {Fiyat}");
        }
    }
}
