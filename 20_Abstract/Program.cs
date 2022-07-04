namespace _20_Abstract
{
    internal class Program
    {
        abstract class Hayvan                       //abstract özelliği alan sınıf main'de new ctor ile instance'ı                                                oluşturulamaz.
        {
            public abstract string Tur { get; set; }
            public string  Adi { get; set; }
            public abstract void Bagir();
        }
        
        class Kedi : Hayvan
        {
            public Kedi()
            {
                Tur = "Kedi";

            }

            public override string Tur { get; set ; }

            public override void Bagir()
            {
                Console.WriteLine("MİYAV"); ;
            }
        }

        class Kopek : Hayvan
        {
            public Kopek()
            {
                Tur = "Köpek";

            }
            public override string Tur { get; set; }

            public override void Bagir()
            {
                Console.WriteLine("MİYAV"); ;
            }
        }

        static void Main(string[] args)
        {
            Hayvan hayvan1 = new Hayvan();


        }
    }
}