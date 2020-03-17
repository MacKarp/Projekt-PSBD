using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PSBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("naciskam button");
            using (var ctx = new MagazynContext())
            {
                Debug.WriteLine("var towar");
                var towar = new Towar()
                {
                    NazwaTowaru = "MateBook D 15",
                    Producent = new Producent() { NazwaProducenta = "Huawei", AdresProducenta = "Wuhan", Kraj = new Kraj() { NazwaKraju = "Chiny" } },
                    CenaTowaru = 2.99,
                    IloscTowaru = 100
                };
                Debug.WriteLine("ctx.towary.add");
                ctx.Towary.Add(towar);
                ctx.SaveChanges();
            }
        }
    }
}
