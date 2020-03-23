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
    }
}
