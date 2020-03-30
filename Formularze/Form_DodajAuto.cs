using System;
using System.Linq;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Form_DodajAuto : Form
    {
        public Form_DodajAuto()
        {
            InitializeComponent();
            using (var ctx = new KomisContext())
            {
                comboBoxMarka.DataSource = ctx.Markas.ToList();
                comboBoxMarka.DisplayMember = "NazwaMarka";
            }
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new KomisContext())
            {
                var nowaMarka = new Marka()
                {
                    NazwaMarka = comboBoxMarka.Text
                };
                ctx.Markas.Add(nowaMarka);
                ctx.SaveChanges();
            }
        }

        private void labelModel_Click(object sender, EventArgs e)
        {

        }

        private void Form_DodajAuto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_DodajAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
