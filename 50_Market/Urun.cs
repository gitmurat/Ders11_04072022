namespace _50_Market
{
    abstract class Urun
    {
        public abstract string Tip { get; }                 //constructor'da set edilecek
        public abstract string Marka { get; }
        public string Baslik
        {
            get
            {
                return BaslikBelirle();
            }             
        }

        public decimal Fiyat { get; set; }

        public virtual string BaslikBelirle()
        {
            return Tip + " " + Marka;
        }
    }
}