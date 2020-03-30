using System;
using System.Linq;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Form_PanelUzytkownikow : Form
    {
        public Form_PanelUzytkownikow()
        {
            InitializeComponent();
            aktualizacjaListyUzytkownikow();
        }

        private void Form_PanelUzytkownikow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //todo : lista uzytkownikow
        private void aktualizacjaListyUzytkownikow()
        {
            using (var ctx = new KomisContext())
            {
                listBoxListaUzytkownikow.DataSource = ctx.Uzytkowniks.ToList();
                listBoxListaUzytkownikow.DisplayMember = "NazwaUzytkownia";
            }
        }

        private void textBoxNazwaUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPoziomDostepuUzytkownik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //todo : dodawanie uzytkownika
        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
        }

        //todo : edycja uzytkownika
        private void buttonZmienUzytkownika_Click(object sender, EventArgs e)
        {

        }

        //todo : usuniecie uzytkownia
        private void buttonUsunUzytkownika_Click(object sender, EventArgs e)
        {

        }


        
    }
}
