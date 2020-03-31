namespace Projekt_PSBD.Formularze
{
    partial class Form_PanelUzytkownikow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PanelUzytkownikow));
            this.listBoxListaUzytkownikow = new System.Windows.Forms.ListBox();
            this.labelNazwaUzytkownika = new System.Windows.Forms.Label();
            this.textBoxNazwaUzytkownika = new System.Windows.Forms.TextBox();
            this.labelPoziomDostepu = new System.Windows.Forms.Label();
            this.radioButtonPoziomDostepuUzytkownik = new System.Windows.Forms.RadioButton();
            this.radioButtonPoziomDostepuKierownik = new System.Windows.Forms.RadioButton();
            this.radioButtonPoziomDostepuSprzedawca = new System.Windows.Forms.RadioButton();
            this.buttonDodajUzytkownika = new System.Windows.Forms.Button();
            this.buttonZmienUzytkownika = new System.Windows.Forms.Button();
            this.buttonUsunUzytkownika = new System.Windows.Forms.Button();
            this.labelZmianaHasla = new System.Windows.Forms.Label();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxHasloPowtorz = new System.Windows.Forms.TextBox();
            this.labelPowtorzHaslo = new System.Windows.Forms.Label();
            this.labelNiepoprawneHaslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxListaUzytkownikow
            // 
            this.listBoxListaUzytkownikow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxListaUzytkownikow.FormattingEnabled = true;
            this.listBoxListaUzytkownikow.ItemHeight = 29;
            this.listBoxListaUzytkownikow.Location = new System.Drawing.Point(12, 12);
            this.listBoxListaUzytkownikow.Name = "listBoxListaUzytkownikow";
            this.listBoxListaUzytkownikow.Size = new System.Drawing.Size(139, 410);
            this.listBoxListaUzytkownikow.TabIndex = 0;
            this.listBoxListaUzytkownikow.SelectedIndexChanged += new System.EventHandler(this.listBoxListaUzytkownikow_SelectedIndexChanged);
            this.listBoxListaUzytkownikow.SelectedValueChanged += new System.EventHandler(this.listBoxListaUzytkownikow_SelectedValueChanged);
            // 
            // labelNazwaUzytkownika
            // 
            this.labelNazwaUzytkownika.AutoSize = true;
            this.labelNazwaUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaUzytkownika.Location = new System.Drawing.Point(157, 58);
            this.labelNazwaUzytkownika.Name = "labelNazwaUzytkownika";
            this.labelNazwaUzytkownika.Size = new System.Drawing.Size(207, 25);
            this.labelNazwaUzytkownika.TabIndex = 1;
            this.labelNazwaUzytkownika.Text = "Nazwa użytkownika:";
            // 
            // textBoxNazwaUzytkownika
            // 
            this.textBoxNazwaUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwaUzytkownika.Location = new System.Drawing.Point(369, 52);
            this.textBoxNazwaUzytkownika.Name = "textBoxNazwaUzytkownika";
            this.textBoxNazwaUzytkownika.Size = new System.Drawing.Size(415, 31);
            this.textBoxNazwaUzytkownika.TabIndex = 2;
            this.textBoxNazwaUzytkownika.TextChanged += new System.EventHandler(this.textBoxNazwaUzytkownika_TextChanged);
            // 
            // labelPoziomDostepu
            // 
            this.labelPoziomDostepu.AutoSize = true;
            this.labelPoziomDostepu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomDostepu.Location = new System.Drawing.Point(157, 104);
            this.labelPoziomDostepu.Name = "labelPoziomDostepu";
            this.labelPoziomDostepu.Size = new System.Drawing.Size(172, 25);
            this.labelPoziomDostepu.TabIndex = 3;
            this.labelPoziomDostepu.Text = "Poziom dostępu:";
            // 
            // radioButtonPoziomDostepuUzytkownik
            // 
            this.radioButtonPoziomDostepuUzytkownik.AutoSize = true;
            this.radioButtonPoziomDostepuUzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPoziomDostepuUzytkownik.Location = new System.Drawing.Point(190, 132);
            this.radioButtonPoziomDostepuUzytkownik.Name = "radioButtonPoziomDostepuUzytkownik";
            this.radioButtonPoziomDostepuUzytkownik.Size = new System.Drawing.Size(139, 29);
            this.radioButtonPoziomDostepuUzytkownik.TabIndex = 4;
            this.radioButtonPoziomDostepuUzytkownik.TabStop = true;
            this.radioButtonPoziomDostepuUzytkownik.Text = "Użytkownik";
            this.radioButtonPoziomDostepuUzytkownik.UseVisualStyleBackColor = true;
            this.radioButtonPoziomDostepuUzytkownik.CheckedChanged += new System.EventHandler(this.radioButtonPoziomDostepuUzytkownik_CheckedChanged);
            // 
            // radioButtonPoziomDostepuKierownik
            // 
            this.radioButtonPoziomDostepuKierownik.AutoSize = true;
            this.radioButtonPoziomDostepuKierownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPoziomDostepuKierownik.Location = new System.Drawing.Point(190, 202);
            this.radioButtonPoziomDostepuKierownik.Name = "radioButtonPoziomDostepuKierownik";
            this.radioButtonPoziomDostepuKierownik.Size = new System.Drawing.Size(123, 29);
            this.radioButtonPoziomDostepuKierownik.TabIndex = 5;
            this.radioButtonPoziomDostepuKierownik.TabStop = true;
            this.radioButtonPoziomDostepuKierownik.Text = "Kierownik";
            this.radioButtonPoziomDostepuKierownik.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoziomDostepuSprzedawca
            // 
            this.radioButtonPoziomDostepuSprzedawca.AutoSize = true;
            this.radioButtonPoziomDostepuSprzedawca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPoziomDostepuSprzedawca.Location = new System.Drawing.Point(190, 167);
            this.radioButtonPoziomDostepuSprzedawca.Name = "radioButtonPoziomDostepuSprzedawca";
            this.radioButtonPoziomDostepuSprzedawca.Size = new System.Drawing.Size(148, 29);
            this.radioButtonPoziomDostepuSprzedawca.TabIndex = 6;
            this.radioButtonPoziomDostepuSprzedawca.TabStop = true;
            this.radioButtonPoziomDostepuSprzedawca.Text = "Sprzedawca";
            this.radioButtonPoziomDostepuSprzedawca.UseVisualStyleBackColor = true;
            // 
            // buttonDodajUzytkownika
            // 
            this.buttonDodajUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajUzytkownika.Location = new System.Drawing.Point(162, 377);
            this.buttonDodajUzytkownika.Name = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Size = new System.Drawing.Size(202, 45);
            this.buttonDodajUzytkownika.TabIndex = 7;
            this.buttonDodajUzytkownika.Text = "Dodaj użytkownika";
            this.buttonDodajUzytkownika.UseVisualStyleBackColor = true;
            this.buttonDodajUzytkownika.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // buttonZmienUzytkownika
            // 
            this.buttonZmienUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmienUzytkownika.Location = new System.Drawing.Point(370, 377);
            this.buttonZmienUzytkownika.Name = "buttonZmienUzytkownika";
            this.buttonZmienUzytkownika.Size = new System.Drawing.Size(204, 45);
            this.buttonZmienUzytkownika.TabIndex = 8;
            this.buttonZmienUzytkownika.Text = "Edytuj użytkownika";
            this.buttonZmienUzytkownika.UseVisualStyleBackColor = true;
            this.buttonZmienUzytkownika.Click += new System.EventHandler(this.buttonZmienUzytkownika_Click);
            // 
            // buttonUsunUzytkownika
            // 
            this.buttonUsunUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsunUzytkownika.Location = new System.Drawing.Point(580, 377);
            this.buttonUsunUzytkownika.Name = "buttonUsunUzytkownika";
            this.buttonUsunUzytkownika.Size = new System.Drawing.Size(202, 45);
            this.buttonUsunUzytkownika.TabIndex = 9;
            this.buttonUsunUzytkownika.Text = "Usuń użytkownika";
            this.buttonUsunUzytkownika.UseVisualStyleBackColor = true;
            this.buttonUsunUzytkownika.Click += new System.EventHandler(this.buttonUsunUzytkownika_Click);
            // 
            // labelZmianaHasla
            // 
            this.labelZmianaHasla.AutoSize = true;
            this.labelZmianaHasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZmianaHasla.Location = new System.Drawing.Point(365, 104);
            this.labelZmianaHasla.Name = "labelZmianaHasla";
            this.labelZmianaHasla.Size = new System.Drawing.Size(130, 25);
            this.labelZmianaHasla.TabIndex = 10;
            this.labelZmianaHasla.Text = "Nowe hasło:";
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(370, 130);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(412, 31);
            this.textBoxHaslo.TabIndex = 11;
            this.textBoxHaslo.UseSystemPasswordChar = true;
            // 
            // textBoxHasloPowtorz
            // 
            this.textBoxHasloPowtorz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHasloPowtorz.Location = new System.Drawing.Point(370, 200);
            this.textBoxHasloPowtorz.Name = "textBoxHasloPowtorz";
            this.textBoxHasloPowtorz.Size = new System.Drawing.Size(412, 31);
            this.textBoxHasloPowtorz.TabIndex = 12;
            this.textBoxHasloPowtorz.UseSystemPasswordChar = true;
            // 
            // labelPowtorzHaslo
            // 
            this.labelPowtorzHaslo.AutoSize = true;
            this.labelPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPowtorzHaslo.Location = new System.Drawing.Point(365, 169);
            this.labelPowtorzHaslo.Name = "labelPowtorzHaslo";
            this.labelPowtorzHaslo.Size = new System.Drawing.Size(153, 25);
            this.labelPowtorzHaslo.TabIndex = 13;
            this.labelPowtorzHaslo.Text = "Powtórz hasło:";
            this.labelPowtorzHaslo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNiepoprawneHaslo
            // 
            this.labelNiepoprawneHaslo.AutoSize = true;
            this.labelNiepoprawneHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNiepoprawneHaslo.ForeColor = System.Drawing.Color.Red;
            this.labelNiepoprawneHaslo.Location = new System.Drawing.Point(430, 234);
            this.labelNiepoprawneHaslo.Name = "labelNiepoprawneHaslo";
            this.labelNiepoprawneHaslo.Size = new System.Drawing.Size(292, 25);
            this.labelNiepoprawneHaslo.TabIndex = 14;
            this.labelNiepoprawneHaslo.Text = "Hasła muszą być takie same!";
            this.labelNiepoprawneHaslo.Visible = false;
            this.labelNiepoprawneHaslo.Click += new System.EventHandler(this.labelNiepoprawneHaslo_Click);
            // 
            // Form_PanelUzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNiepoprawneHaslo);
            this.Controls.Add(this.labelPowtorzHaslo);
            this.Controls.Add(this.textBoxHasloPowtorz);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.labelZmianaHasla);
            this.Controls.Add(this.buttonUsunUzytkownika);
            this.Controls.Add(this.buttonZmienUzytkownika);
            this.Controls.Add(this.buttonDodajUzytkownika);
            this.Controls.Add(this.radioButtonPoziomDostepuSprzedawca);
            this.Controls.Add(this.radioButtonPoziomDostepuKierownik);
            this.Controls.Add(this.radioButtonPoziomDostepuUzytkownik);
            this.Controls.Add(this.labelPoziomDostepu);
            this.Controls.Add(this.textBoxNazwaUzytkownika);
            this.Controls.Add(this.labelNazwaUzytkownika);
            this.Controls.Add(this.listBoxListaUzytkownikow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PanelUzytkownikow";
            this.Text = "Użytkownicy - Komis samochodowy \"Janusz\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PanelUzytkownikow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaUzytkownikow;
        private System.Windows.Forms.Label labelNazwaUzytkownika;
        private System.Windows.Forms.TextBox textBoxNazwaUzytkownika;
        private System.Windows.Forms.Label labelPoziomDostepu;
        private System.Windows.Forms.RadioButton radioButtonPoziomDostepuUzytkownik;
        private System.Windows.Forms.RadioButton radioButtonPoziomDostepuKierownik;
        private System.Windows.Forms.RadioButton radioButtonPoziomDostepuSprzedawca;
        private System.Windows.Forms.Button buttonDodajUzytkownika;
        private System.Windows.Forms.Button buttonZmienUzytkownika;
        private System.Windows.Forms.Button buttonUsunUzytkownika;
        private System.Windows.Forms.Label labelZmianaHasla;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxHasloPowtorz;
        private System.Windows.Forms.Label labelPowtorzHaslo;
        private System.Windows.Forms.Label labelNiepoprawneHaslo;
    }
}