namespace _50_Market
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Sut sut = new Sut();
            sut.LightMi = true;
            sut.Hacim = "500 ml";
            sut.Fiyat = 20;

            Pil pil = new Pil();
            pil.Tur = "Kalem Pil - AA";
            pil.Fiyat = 10;

            Urun[] sepet = new Urun[2];                 //int array, string array gibi bir Urun class'ı array'i                                                 tanımladık

            sepet[0] = pil;
            sepet[1] = sut;

            for (int i = 0; i < sepet.Length; i++)
            {
                Urun urun = sepet[i];                   //Ürün class'ında yeni bir instance yaratarak indexe atıyoruz

                Console.WriteLine(urun.Baslik);
                Console.WriteLine(urun.Fiyat);
            }
        }
    }
}