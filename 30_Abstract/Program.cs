namespace _30_Abstract
{
    internal class Program
    {
        abstract class Tasit
        {
            public abstract int TekerlekSayisi { get; }
            public string Tur { get; set; }
            public void Hakkinda()
            {
                Console.WriteLine(Tur.ToUpper());
                Console.WriteLine("Tekerlek Sayisi " + TekerlekSayisi);
            }
        }

        class Bisiklet : Tasit
        {
            public override int TekerlekSayisi
            {
                get
                {
                    return 2;
                }
            }
            public Bisiklet()
            {
                Tur = "Bisiklet";
            }
        }

        class Araba : Tasit
        {
            public override int TekerlekSayisi
            {
                get
                {
                    return 4;
                }
            }
            public Araba()
            {
                Tur = "Araba";
            }
        }

        static void Main(string[] args)
        {
            
            
            
            Bisiklet bisiklet1 = new Bisiklet();
            bisiklet1.Hakkinda();

            Araba araba1 = new Araba();
            araba1.Hakkinda();
        }
    }
}