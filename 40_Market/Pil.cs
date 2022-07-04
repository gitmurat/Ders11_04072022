namespace _40_Market
{
    class Pil : Urun
    {
        public string Tip { get; set; }
        public override string Baslik
        {
            get
            {
                return BaslikBelirle();
            }
        }
        public Pil(string tip, string marka)
        {
            Adi = "Pil";
            Tip = tip;
            Marka = marka;
        }

        public override string BaslikBelirle()
        {
            return base.BaslikBelirle()+" - "+ Tip + " - ";
        }
    }
}