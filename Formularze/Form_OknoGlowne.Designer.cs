namespace Projekt_PSBD.Formularze
{
    partial class Form_OknoGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OknoGlowne));
            this.listBoxListaOfert = new System.Windows.Forms.ListBox();
            this.buttonPanelUzytkownikow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxListaOfert
            // 
            this.listBoxListaOfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxListaOfert.FormattingEnabled = true;
            this.listBoxListaOfert.ItemHeight = 24;
            this.listBoxListaOfert.Location = new System.Drawing.Point(12, 12);
            this.listBoxListaOfert.Name = "listBoxListaOfert";
            this.listBoxListaOfert.Size = new System.Drawing.Size(410, 532);
            this.listBoxListaOfert.TabIndex = 0;
            // 
            // buttonPanelUzytkownikow
            // 
            this.buttonPanelUzytkownikow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPanelUzytkownikow.Location = new System.Drawing.Point(1105, 631);
            this.buttonPanelUzytkownikow.Name = "buttonPanelUzytkownikow";
            this.buttonPanelUzytkownikow.Size = new System.Drawing.Size(143, 34);
            this.buttonPanelUzytkownikow.TabIndex = 1;
            this.buttonPanelUzytkownikow.Text = "Użytkownicy";
            this.buttonPanelUzytkownikow.UseVisualStyleBackColor = true;
            this.buttonPanelUzytkownikow.Click += new System.EventHandler(this.buttonPanelUzytkownikow_Click);
            // 
            // Form_OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.buttonPanelUzytkownikow);
            this.Controls.Add(this.listBoxListaOfert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OknoGlowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katalog - Komis samochodowy \"Janusz\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_OknoGlowne_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxListaOfert;
        private System.Windows.Forms.Button buttonPanelUzytkownikow;
    }
}