namespace Projekt_PSBD
{
    public class AutoNaSprzedaz
    {
        public int AutoNaSprzedazID { get; set; }
        public string TytulOferty { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Model Model { get; set; }
        public virtual RokProdukcji RokProdukcji { get; set; }
        public virtual PojemnoscSilnika PojemnoscSilnika { get; set; }
        public virtual RodzajPaliwa RodzajPaliwa { get; set; }
        public int Przebieg { get; set; }
        public int Moc { get; set; }
        public virtual RodzajNadwozia RodzajNadwozia { get; set; }
        public int IloscMiejs { get; set; }
        public virtual KolorNadwozia KolorNadwozia { get; set; }
        public virtual TypSkrzyniBiegow TypSkrzyniBiegow { get; set; }
        public string Opis { get; set; }
        public int Cena { get; set; }
    }
}