using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PSBD
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
    }
}
