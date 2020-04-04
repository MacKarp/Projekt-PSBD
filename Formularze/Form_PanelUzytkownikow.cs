using System;
using System.Data.Entity.Migrations;
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

        //lista uzytkownikow
        private void aktualizacjaListyUzytkownikow()
        {
            using (var ctx = new KomisContext())
            {
                listBoxListaUzytkownikow.DataSource = ctx.Uzytkowniks.ToList();
                listBoxListaUzytkownikow.DisplayMember = "NazwaUzytkownia";
            }

            labelNiepoprawneHaslo.Visible = false;
            textBoxHaslo.Text = "";
            textBoxHasloPowtorz.Text = "";
        }

        private void listBoxListaUzytkownikow_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uzytkownik zaznaczonyUzytkownik = (Uzytkownik)listBoxListaUzytkownikow.SelectedItem;
            textBoxNazwaUzytkownika.Text = zaznaczonyUzytkownik.NazwaUzytkownia;
            switch (zaznaczonyUzytkownik.PoziomDostepuUzytkownika)
            {
                case 0: //Uzytkownik
                    radioButtonPoziomDostepuUzytkownik.Checked = true;
                    radioButtonPoziomDostepuSprzedawca.Checked = false;
                    radioButtonPoziomDostepuKierownik.Checked = false;
                    break;
                case 1: //Sprzedawca
                    radioButtonPoziomDostepuUzytkownik.Checked = false;
                    radioButtonPoziomDostepuSprzedawca.Checked = true;
                    radioButtonPoziomDostepuKierownik.Checked = false;
                    break;
                case 2: //Kierownik
                    radioButtonPoziomDostepuUzytkownik.Checked = false;
                    radioButtonPoziomDostepuSprzedawca.Checked = false;
                    radioButtonPoziomDostepuKierownik.Checked = true;
                    break;
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

        //dodawanie uzytkownika
        private void buttonDodajUzytkownika_Click(object sender, EventArgs e)
        {
            Uzytkownik nowyUzytkownik = new Uzytkownik();
            nowyUzytkownik.NazwaUzytkownia = textBoxNazwaUzytkownika.Text;
            if (radioButtonPoziomDostepuUzytkownik.Checked)
            {
                nowyUzytkownik.PoziomDostepuUzytkownika = 0;
            }
            if (radioButtonPoziomDostepuSprzedawca.Checked)
            {
                nowyUzytkownik.PoziomDostepuUzytkownika = 1;
            }
            if (radioButtonPoziomDostepuKierownik.Checked)
            {
                nowyUzytkownik.PoziomDostepuUzytkownika = 2;
            }
            if (textBoxHaslo.Text == textBoxHasloPowtorz.Text)
            {
                nowyUzytkownik.ustawHasloUzytkownika(textBoxHaslo.Text);
                using (var ctx = new KomisContext())
                {
                    ctx.Uzytkowniks.Add(nowyUzytkownik);
                    ctx.SaveChanges();
                    aktualizacjaListyUzytkownikow();
                }
            }
            else
            {
                labelNiepoprawneHaslo.Visible = true;
            }
        }

        //edycja uzytkownika
        private void buttonZmienUzytkownika_Click(object sender, EventArgs e)
        {
            Uzytkownik doEdycjiUzytkownik = (Uzytkownik)listBoxListaUzytkownikow.SelectedItem;
            if (textBoxHaslo.Text != "")
            {
                if (textBoxHaslo.Text == textBoxHasloPowtorz.Text)
                {
                    doEdycjiUzytkownik.ustawHasloUzytkownika(textBoxHaslo.Text);

                }
            }
            if (radioButtonPoziomDostepuUzytkownik.Checked)
            {
                doEdycjiUzytkownik.PoziomDostepuUzytkownika = 0;
            }
            if (radioButtonPoziomDostepuSprzedawca.Checked)
            {
                doEdycjiUzytkownik.PoziomDostepuUzytkownika = 1;
            }
            if (radioButtonPoziomDostepuKierownik.Checked)
            {
                doEdycjiUzytkownik.PoziomDostepuUzytkownika = 2;
            }

            using (var ctx = new KomisContext())
            {
                ctx.Uzytkowniks.AddOrUpdate(doEdycjiUzytkownik);
                ctx.SaveChanges();
                aktualizacjaListyUzytkownikow();
            }
        }

        //usuniecie uzytkownia
        private void buttonUsunUzytkownika_Click(object sender, EventArgs e)
        {
            Uzytkownik doUsunieciaUzytkownik = (Uzytkownik)listBoxListaUzytkownikow.SelectedItem;
            using (var ctx = new KomisContext())
            {
                ctx.Uzytkowniks.Attach(doUsunieciaUzytkownik);
                ctx.Uzytkowniks.Remove(doUsunieciaUzytkownik);
                ctx.SaveChanges();
                aktualizacjaListyUzytkownikow();
            }
        }

        private void labelNiepoprawneHaslo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxListaUzytkownikow_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxHaslo.Text = "";
            textBoxHasloPowtorz.Text = "";
        }
    }
}
