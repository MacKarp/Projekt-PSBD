using System.Windows.Forms;

namespace Projekt_PSBD.Formularze
{
    public partial class Form_PrzegladarkaZdjec : Form
    {
        public string pic1;
        public string pic2;
        public string pic3;
        public string pic4;

        public Form_PrzegladarkaZdjec()
        {
            InitializeComponent();
        }

        private void Form_PrzegladarkaZdjec_VisibleChanged(object sender, System.EventArgs e)
        {
            pictureBox1.ImageLocation = pic1;
            pictureBox2.ImageLocation = pic2;
            pictureBox3.ImageLocation = pic3;
            pictureBox4.ImageLocation = pic4;
        }
    }
}
