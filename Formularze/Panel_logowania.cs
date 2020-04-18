using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Projekt_PSBD.db;

namespace Projekt_PSBD.Formularze
{
    public partial class Panel_logowania : Form
    {
        public Panel_logowania()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void Panel_logowania_Load(object sender, EventArgs e)
        {
            bool adminExist = false, guestExist = false;
            using (var ctx = new KomisContext())
            {
                //Sprawdzanie czy w bazie danych istnieją domyślni użytkownicy admin i guest
                List<Uzytkownik> listaUzytkownikow = ctx.Uzytkowniks.ToList();
                foreach (var VARIABLE in listaUzytkownikow)
                {
                    if (VARIABLE.NazwaUzytkownia == "admin")
                    {
                        adminExist = true;
                        break;
                    }
                }

                foreach (var VARIABLE in listaUzytkownikow)
                {
                    if (VARIABLE.NazwaUzytkownia == "guest")
                    {
                        guestExist = true;
                        break;
                    }
                }

                //W przypadku braku domyślnych użytkowników admin i guest dodaje ich do bazy danych
                if (adminExist == false)
                {
                    var admin = new Uzytkownik();
                    admin.NazwaUzytkownia = "admin";
                    admin.ustawHasloUzytkownika("admin");
                    admin.PoziomDostepuUzytkownika = 0;
                    ctx.Uzytkowniks.Add(admin);
                    ctx.SaveChanges();
                }

                if (guestExist == false)
                {
                    var guest = new Uzytkownik();
                    guest.NazwaUzytkownia = "guest";
                    guest.ustawHasloUzytkownika("guest");
                    guest.PoziomDostepuUzytkownika = 9;
                    ctx.Uzytkowniks.Add(guest);
                    ctx.SaveChanges();
                }
            }
        }

        //logowanie
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            logowanie(login, password);

        }

        //Logowanie jako użytkownik guest
        private void buttonGuest_Click(object sender, EventArgs e)
        {
            logowanie("guest", "guest");
        }

        public void logowanie(string login, string password)
        {
            labelErrorLogin.Visible = false;

            using (var ctx = new KomisContext())
            {
                List<Uzytkownik> listaUzytkownikow = ctx.Uzytkowniks.ToList();
                foreach (var VARIABLE in listaUzytkownikow)
                {
                    if (VARIABLE.NazwaUzytkownia == login)
                    {
                        if (VARIABLE.sprawdzHasloUzytkownika(password))
                        {
                            Debug.WriteLine("Logowanie poprawne!");
                            labelErrorLogin.Visible = false;
                            Form_OknoGlowne oknoGlowne = new Form_OknoGlowne();

                            Debug.WriteLine("Przed przekazaniem: " + VARIABLE.PoziomDostepuUzytkownika);
                            oknoGlowne.PoziomLogowania = VARIABLE.PoziomDostepuUzytkownika;
                            Debug.WriteLine("Po przekazaniu: " + oknoGlowne.PoziomLogowania);
                            oknoGlowne.Show(this);
                            this.Hide();
                            break;
                        }
                        else
                        {
                            Debug.WriteLine("Błąd hasła!");
                            labelErrorLogin.Visible = true;
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Błąd loginu!");
                        labelErrorLogin.Visible = true;
                    }
                }
            }
        }
    }
}
