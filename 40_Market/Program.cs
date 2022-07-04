namespace _40_Market
{
    abstract class Urun
    {
        public abstract string Baslik { get; }
        public string Adi { get; set; }
        public string Marka { get; set; } = "";
        public decimal Fiyat { get; set; } = 0;

        public void Hakkinda ()
        {
            Console.WriteLine("Marka : "+ Marka + "Adı : " + Adi+ "Fiyat : "+ Fiyat);
        }

        public virtual string BaslikBelirle()
        {
            string baslik = "";
            baslik += Marka + " ";
            baslik += Adi;
            return baslik;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sut sut = new Sut("Pınar");
            Pil pil = new Pil("kalem", "Duracell");

            sut.Hacim = 1;

            Console.WriteLine(sut.Baslik);
            Console.WriteLine(pil.Baslik);
        }
    }
}