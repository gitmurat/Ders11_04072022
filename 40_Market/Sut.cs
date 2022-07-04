namespace _40_Market
{
    class Sut : Urun
    {
        public override string Baslik
        {
            get
            { return BaslikBelirle(); }
        }
        public int Hacim { get; set; }

        private bool _LightMi { get; set; }
        public bool LightMi
        {
            get
            { return _LightMi; }
            set
            {
                if (value = "Evet")
                {
                    _LightMi = true;
                }
            }

        public Sut(string marka)
        {
            Marka = marka;
            Adi = "Süt";
        }

        public override string BaslikBelirle()
        {
            return base.BaslikBelirle() + " - " + Hacim + " - " + LightMi + " - ";
        }
    }
}