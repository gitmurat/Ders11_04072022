namespace Ders11_04072022
{
    internal class Program
    {
        class Kisi
        { 
        
        public string Adi { get; set; }

        public string Kisi ()
        {
            Console.WriteLine("yaratıldı");
        }
        
        ~Kisi()
        {
            Console.WriteLine("yokedildi");
        }
        
        static void KisiYarat()
        {
            Kisi k1 = new Kisi();
        }

        static void Main(string[] args)
        {
            
        }
        }
    }
}