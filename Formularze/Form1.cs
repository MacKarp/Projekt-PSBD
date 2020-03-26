using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new KomisContext())
            {
                List<string> rodzajPaliwaList = new List<string>();
                rodzajPaliwaList.Add("Benzyna");
                rodzajPaliwaList.Add("Benzyna + CNG");
                rodzajPaliwaList.Add("Benzyna + LPG");
                rodzajPaliwaList.Add("Diesel");
                rodzajPaliwaList.Add("Elektryczny");
                rodzajPaliwaList.Add("Hybryda");
                rodzajPaliwaList.Add("Inny");
                for (int i = 0; i < rodzajPaliwaList.Count; i++)
                {
                    var paliwo = new RodzajPaliwa()
                    {
                        Paliwo = rodzajPaliwaList.ElementAt(i)
                    };
                    ctx.RodzajPaliwas.Add(paliwo);
                }
                ctx.SaveChanges();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
