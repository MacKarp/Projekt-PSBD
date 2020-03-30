using System;
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
            aktualizacjaListyOfert();
        }
        //todo : przyjecie wartości z panelu logowania
        //todo : lista ofert (wszyscy)
        //todo : przegladarka wybranej oferty (wszyscy)
        //todo : drukowanie wybranej oferty/wygenerowanie pdf (wszyscy)
        //todo : otwieranie okna dodania auta (poziom sprzedawca i kierownik)



        private void Form_OknoGlowne_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonPanelUzytkownikow_Click(object sender, EventArgs e)
        {
            //todo : otwierania okna uzytkownikow (poziom kierownik)
            Form_PanelUzytkownikow panelUzytkownikow = new Form_PanelUzytkownikow();
            panelUzytkownikow.Show(this);
            this.Hide();
        }

        //todo : pobranie ofert z bazy danych
        private void aktualizacjaListyOfert()
        {
            using (var ctx = new KomisContext())
            {
                listBoxListaOfert.DataSource = ctx.AutoAutoNaSprzedazs.ToList();
                listBoxListaOfert.DisplayMember = "Marka";
            }
        }
    }
}
