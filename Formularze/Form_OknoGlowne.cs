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
        private readonly KomisContext _ctx = new KomisContext();

        public Form_OknoGlowne()
        {
            InitializeComponent();
            _ctx.AutoAutoNaSprzedazs.Load();
            data = _ctx.AutoAutoNaSprzedazs.Local.ToBindingList();
            listBoxListaOfert.DataSource = data;
            listBoxListaOfert.DisplayMember = "TytulOferty";
        }
        //todo : przyjecie wartości z panelu logowania
        //todo : drukowanie wybranej oferty/wygenerowanie pdf (wszyscy)




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
            //labelMarka.Text = zaznaczoneAutoNaSprzedaz.Marka.NazwaMarka + " " + zaznaczoneAutoNaSprzedaz.Model.NazwaModel;
            labelMoc.Text = "Moc: " + zaznaczoneAutoNaSprzedaz.Moc.ToString() + "KM";
            labelPojemnoscSilnika.Text = "Pojemność silnika: " + zaznaczoneAutoNaSprzedaz.PojemnoscSilnika.Pojemnosc.ToString();
            labelPrzebieg.Text = "Przebieg: " + zaznaczoneAutoNaSprzedaz.Przebieg.ToString();
            labelRodzajNadwozia.Text = "Nadwozie: " + zaznaczoneAutoNaSprzedaz.RodzajNadwozia.Nadwozie;
            labelRodzajPaliwa.Text = "Rodzaj paliwa: " + zaznaczoneAutoNaSprzedaz.RodzajPaliwa.Paliwo;
            labelRokProdukcji.Text = "Rok produkcji: " + zaznaczoneAutoNaSprzedaz.RokProdukcji.Rok.ToString();
            //labelTypSkrzyniBiegow.Text = "Skrzynia biegów: " + zaznaczoneAutoNaSprzedaz.TypSkrzyniBiegow.SkrzyniaBiegow;
            richTextBoxOpis.Text = zaznaczoneAutoNaSprzedaz.Opis;
        }

        //todo : otwieranie okna dodania auta (poziom sprzedawca i kierownik)
        private void buttonDodajAuto_Click(object sender, EventArgs e)
        {
            Form_DodajAuto dodajAuto = new Form_DodajAuto();
            dodajAuto.Show(this);
            this.Hide();
        }
    }
}
