using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Form_OknoGlowne : Form
    {
        public Form_OknoGlowne()
        {
            InitializeComponent();
            var ctx = new KomisContext();
            listBoxListaOfert.DataSource = ctx.AutoAutoNaSprzedazs.ToList();
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
            labelMoc.Text = "Moc: " + zaznaczoneAutoNaSprzedaz.Moc.ToString();
            labelPojemnoscSilnika.Text = "Pojemność silnika: " + zaznaczoneAutoNaSprzedaz.PojemnoscSilnika.Pojemnosc.ToString();
            labelPrzebieg.Text = "Przebieg: " + zaznaczoneAutoNaSprzedaz.Przebieg.ToString();
            labelRodzajNadwozia.Text = "Nadwozie: " + zaznaczoneAutoNaSprzedaz.RodzajNadwozia.Nadwozie;
            labelRodzajPaliwa.Text = "Rodzaj paliwa: " + zaznaczoneAutoNaSprzedaz.RodzajPaliwa.Paliwo;
            labelRokProdukcji.Text = "Rok produkcji: " + zaznaczoneAutoNaSprzedaz.RokProdukcji.Rok.ToString();
            labelTypSkrzyniBiegow.Text = "Skrzynia biegów: " + zaznaczoneAutoNaSprzedaz.TypSkrzyniBiegow.SkrzyniaBiegow;
            richTextBoxOpis.Text = zaznaczoneAutoNaSprzedaz.Opis;

        }

        //pobranie ofert z bazy danych
        private void aktualizacjaListyOfert()
        {
            using (var ctx = new KomisContext())
            {
                listBoxListaOfert.DataSource = ctx.AutoAutoNaSprzedazs.ToList();
                listBoxListaOfert.DisplayMember = "TytulOferty";
            }
        }

        //testowa oferta
        private void button1_Click(object sender, EventArgs e)
        {
            AutoNaSprzedaz nowaOferta = new AutoNaSprzedaz()
            {
                TytulOferty = "Passeratii w LPG",
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
            using (var ctx = new KomisContext())
            {
                ctx.AutoAutoNaSprzedazs.Add(nowaOferta);
                ctx.SaveChanges();
            }
            aktualizacjaListyOfert();
        }
    }
}
