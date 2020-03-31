using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Form_OknoGlowne : Form
    {
        private BindingList<AutoNaSprzedaz> data;
        KomisContext ctx = new KomisContext();

        public Form_OknoGlowne()
        {
            InitializeComponent();
            ctx.AutoAutoNaSprzedazs.Load();
            data = ctx.AutoAutoNaSprzedazs.Local.ToBindingList();
            listBoxListaOfert.DataSource = data;
            listBoxListaOfert.DisplayMember = "TytulOferty";
        }
        //todo : przyjecie wartości z panelu logowania
        //todo : drukowanie wybranej oferty/wygenerowanie pdf (wszyscy)
        //todo : otwieranie okna dodania auta (poziom sprzedawca i kierownik)



        private void Form_OknoGlowne_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonPanelUzytkownikow_Click(object sender, EventArgs e)
        {
            //otwierania okna uzytkownikow (poziom kierownik)
            Form_PanelUzytkownikow panelUzytkownikow = new Form_PanelUzytkownikow();
            panelUzytkownikow.Show(this);
            this.Hide();
        }

        //lista ofert (wszyscy)
        private void listBoxListaOfert_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoNaSprzedaz zaznaczoneAutoNaSprzedaz = (AutoNaSprzedaz)listBoxListaOfert.SelectedItem;
            labelTytulOferty.Text = zaznaczoneAutoNaSprzedaz.TytulOferty;
            labelCena.Text = "Cena: " + zaznaczoneAutoNaSprzedaz.Cena.ToString();
            labelIloscMiejs.Text = "Liczba miejsc: " + zaznaczoneAutoNaSprzedaz.IloscMiejs.ToString();
            labelKolorNadwozia.Text = "Kolor: " + zaznaczoneAutoNaSprzedaz.KolorNadwozia.Kolor;
            labelMarka.Text = zaznaczoneAutoNaSprzedaz.Marka.NazwaMarka + " " + zaznaczoneAutoNaSprzedaz.Model.NazwaModel;
            labelMoc.Text = "Moc: " + zaznaczoneAutoNaSprzedaz.Moc.ToString() + "KM";
            labelPojemnoscSilnika.Text = "Pojemność silnika: " + zaznaczoneAutoNaSprzedaz.PojemnoscSilnika.Pojemnosc.ToString();
            labelPrzebieg.Text = "Przebieg: " + zaznaczoneAutoNaSprzedaz.Przebieg.ToString();
            labelRodzajNadwozia.Text = "Nadwozie: " + zaznaczoneAutoNaSprzedaz.RodzajNadwozia.Nadwozie;
            labelRodzajPaliwa.Text = "Rodzaj paliwa: " + zaznaczoneAutoNaSprzedaz.RodzajPaliwa.Paliwo;
            labelRokProdukcji.Text = "Rok produkcji: " + zaznaczoneAutoNaSprzedaz.RokProdukcji.Rok.ToString();
            labelTypSkrzyniBiegow.Text = "Skrzynia biegów: " + zaznaczoneAutoNaSprzedaz.TypSkrzyniBiegow.SkrzyniaBiegow;
            richTextBoxOpis.Text = zaznaczoneAutoNaSprzedaz.Opis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoNaSprzedaz nowaOferta = new AutoNaSprzedaz()
            {
                TytulOferty = "Honda szybsza niż wygląda :)",
                Cena = 1000,
                IloscMiejs = 4,
                KolorNadwozia = new KolorNadwozia() { Kolor = "Czarny" },
                Marka = new Marka() { NazwaMarka = "Ford" },
                Model = new Model() { NazwaModel = "Mondeo" },
                Moc = 160,
                Opis = "Mój ford :)",
                PojemnoscSilnika = new PojemnoscSilnika() { Pojemnosc = 1.6 },
                Przebieg = 76000,
                TypSkrzyniBiegow = new TypSkrzyniBiegow() { SkrzyniaBiegow = "Manualna 6 - cio biegowa" },
                RodzajNadwozia = new RodzajNadwozia() { Nadwozie = "Hatchback" },
                RodzajPaliwa = new RodzajPaliwa() { Paliwo = "Benzyna + LPG" },
                RokProdukcji = new RokProdukcji() { Rok = 2013 }
            };
            ctx.AutoAutoNaSprzedazs.Add(nowaOferta);
            ctx.SaveChanges();
        }
    }
}
