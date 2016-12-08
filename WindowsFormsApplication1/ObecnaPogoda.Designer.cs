namespace PogodaApp
{
    partial class ObecnaPogoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObecnaPogoda));
            this.OgólneInformacje = new System.Windows.Forms.Label();
            this.Miasto = new System.Windows.Forms.Label();
            this.tekstMiasto = new System.Windows.Forms.TextBox();
            this.SkrótPaństwa = new System.Windows.Forms.Label();
            this.tekstPaństwo = new System.Windows.Forms.TextBox();
            this.WyświetlObecną = new System.Windows.Forms.Button();
            this.TytułTekst = new System.Windows.Forms.Label();
            this.PogodaKolejne = new System.Windows.Forms.Button();
            this.WilgotnośćTekst = new System.Windows.Forms.Label();
            this.Obrazek = new System.Windows.Forms.PictureBox();
            this.PasekNarzędzi = new System.Windows.Forms.ToolStrip();
            this.Plik = new System.Windows.Forms.ToolStripLabel();
            this.Notatnik = new System.Windows.Forms.ToolStripDropDownButton();
            this.Zapisz = new System.Windows.Forms.ToolStripMenuItem();
            this.Dzielnik = new System.Windows.Forms.ToolStripSeparator();
            this.Temperatura = new System.Windows.Forms.Label();
            this.Wilgotność = new System.Windows.Forms.Label();
            this.WschódSłońca = new System.Windows.Forms.Label();
            this.TemperaturaTekst = new System.Windows.Forms.Label();
            this.WschódTekst = new System.Windows.Forms.Label();
            this.Wiatr = new System.Windows.Forms.Label();
            this.WiatrTekst = new System.Windows.Forms.Label();
            this.Widoczność = new System.Windows.Forms.Label();
            this.WidocznośćTekst = new System.Windows.Forms.Label();
            this.ZachódSłońca = new System.Windows.Forms.Label();
            this.ZachódTekst = new System.Windows.Forms.Label();
            this.Rozdzielnik = new System.Windows.Forms.Splitter();
            this.Okienko = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.PasekNarzędzi.SuspendLayout();
            this.Okienko.SuspendLayout();
            this.SuspendLayout();
            // 
            // OgólneInformacje
            // 
            this.OgólneInformacje.AutoSize = true;
            this.OgólneInformacje.BackColor = System.Drawing.Color.Transparent;
            this.OgólneInformacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OgólneInformacje.Location = new System.Drawing.Point(12, 30);
            this.OgólneInformacje.Name = "OgólneInformacje";
            this.OgólneInformacje.Size = new System.Drawing.Size(453, 25);
            this.OgólneInformacje.TabIndex = 9;
            this.OgólneInformacje.Text = "Podaj informacje, żeby wyszukać pogodę.";
            // 
            // Miasto
            // 
            this.Miasto.AutoSize = true;
            this.Miasto.BackColor = System.Drawing.Color.Transparent;
            this.Miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Miasto.Location = new System.Drawing.Point(-2, 76);
            this.Miasto.Name = "Miasto";
            this.Miasto.Size = new System.Drawing.Size(62, 20);
            this.Miasto.TabIndex = 10;
            this.Miasto.Text = "Miasto";
            // 
            // tekstMiasto
            // 
            this.tekstMiasto.BackColor = System.Drawing.SystemColors.Window;
            this.tekstMiasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tekstMiasto.Location = new System.Drawing.Point(66, 74);
            this.tekstMiasto.Multiline = true;
            this.tekstMiasto.Name = "tekstMiasto";
            this.tekstMiasto.Size = new System.Drawing.Size(85, 24);
            this.tekstMiasto.TabIndex = 11;
            // 
            // SkrótPaństwa
            // 
            this.SkrótPaństwa.AutoSize = true;
            this.SkrótPaństwa.BackColor = System.Drawing.Color.Transparent;
            this.SkrótPaństwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkrótPaństwa.Location = new System.Drawing.Point(157, 76);
            this.SkrótPaństwa.Name = "SkrótPaństwa";
            this.SkrótPaństwa.Size = new System.Drawing.Size(124, 20);
            this.SkrótPaństwa.TabIndex = 12;
            this.SkrótPaństwa.Text = "Skrót państwa";
            // 
            // tekstPaństwo
            // 
            this.tekstPaństwo.Location = new System.Drawing.Point(287, 76);
            this.tekstPaństwo.Multiline = true;
            this.tekstPaństwo.Name = "tekstPaństwo";
            this.tekstPaństwo.Size = new System.Drawing.Size(102, 22);
            this.tekstPaństwo.TabIndex = 13;
            // 
            // WyświetlObecną
            // 
            this.WyświetlObecną.AutoSize = true;
            this.WyświetlObecną.BackColor = System.Drawing.Color.Transparent;
            this.WyświetlObecną.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WyświetlObecną.BackgroundImage")));
            this.WyświetlObecną.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyświetlObecną.Location = new System.Drawing.Point(410, 74);
            this.WyświetlObecną.Name = "WyświetlObecną";
            this.WyświetlObecną.Size = new System.Drawing.Size(174, 26);
            this.WyświetlObecną.TabIndex = 14;
            this.WyświetlObecną.Text = "Wyświetl obecną pogodę ";
            this.WyświetlObecną.UseVisualStyleBackColor = false;
            this.WyświetlObecną.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.TytułTekst.AutoSize = true;
            this.TytułTekst.BackColor = System.Drawing.Color.Transparent;
            this.TytułTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TytułTekst.Location = new System.Drawing.Point(2, 114);
            this.TytułTekst.Name = "label9";
            this.TytułTekst.Size = new System.Drawing.Size(0, 39);
            this.TytułTekst.TabIndex = 15;
            // 
            // PogodaKolejne
            // 
            this.PogodaKolejne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PogodaKolejne.BackgroundImage")));
            this.PogodaKolejne.Location = new System.Drawing.Point(410, 302);
            this.PogodaKolejne.Name = "PogodaKolejne";
            this.PogodaKolejne.Size = new System.Drawing.Size(167, 31);
            this.PogodaKolejne.TabIndex = 29;
            this.PogodaKolejne.Text = "Pogoda na kolejne dni";
            this.PogodaKolejne.UseVisualStyleBackColor = true;
            this.PogodaKolejne.Click += new System.EventHandler(this.button2_Click);
            // 
            // WilgotnośćTekst
            // 
            this.WilgotnośćTekst.AutoSize = true;
            this.WilgotnośćTekst.BackColor = System.Drawing.Color.LightCyan;
            this.WilgotnośćTekst.Location = new System.Drawing.Point(110, 90);
            this.WilgotnośćTekst.Name = "WilgotnośćTekst";
            this.WilgotnośćTekst.Size = new System.Drawing.Size(0, 13);
            this.WilgotnośćTekst.TabIndex = 31;
            // 
            // Obrazek
            // 
            this.Obrazek.BackColor = System.Drawing.Color.Transparent;
            this.Obrazek.Location = new System.Drawing.Point(18, 13);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(67, 49);
            this.Obrazek.TabIndex = 37;
            this.Obrazek.TabStop = false;
            // 
            // PasekNarzędzi
            // 
            this.PasekNarzędzi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Plik,
            this.Notatnik,
            this.Dzielnik});
            this.PasekNarzędzi.Location = new System.Drawing.Point(0, 0);
            this.PasekNarzędzi.Name = "PasekNarzędzi";
            this.PasekNarzędzi.Size = new System.Drawing.Size(584, 25);
            this.PasekNarzędzi.TabIndex = 33;
            this.PasekNarzędzi.Text = "toolStrip1";
            // 
            // Plik
            // 
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(29, 22);
            this.Plik.Text = "Plik:";
            // 
            // Notatnik
            // 
            this.Notatnik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Notatnik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zapisz});
            this.Notatnik.Image = ((System.Drawing.Image)(resources.GetObject("Notatnik.Image")));
            this.Notatnik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Notatnik.Name = "Notatnik";
            this.Notatnik.Size = new System.Drawing.Size(29, 22);
            this.Notatnik.Text = "toolStripDropDownButton1";
            this.Notatnik.ToolTipText = "Notatnik";
            // 
            // Zapisz
            // 
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(110, 22);
            this.Zapisz.Text = "Zapisz ";
            // 
            // Dzielnik
            // 
            this.Dzielnik.Name = "Dzielnik";
            this.Dzielnik.Size = new System.Drawing.Size(6, 25);
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(12, 65);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(70, 13);
            this.Temperatura.TabIndex = 16;
            this.Temperatura.Text = "Temperatura:";
            // 
            // Wilgotność
            // 
            this.Wilgotność.AutoSize = true;
            this.Wilgotność.Location = new System.Drawing.Point(12, 90);
            this.Wilgotność.Name = "Wilgotność";
            this.Wilgotność.Size = new System.Drawing.Size(63, 13);
            this.Wilgotność.TabIndex = 26;
            this.Wilgotność.Text = "Wilgotność:";
            // 
            // WschódSłońca
            // 
            this.WschódSłońca.AutoSize = true;
            this.WschódSłońca.Location = new System.Drawing.Point(12, 119);
            this.WschódSłońca.Name = "WschódSłońca";
            this.WschódSłońca.Size = new System.Drawing.Size(86, 13);
            this.WschódSłońca.TabIndex = 27;
            this.WschódSłońca.Text = "Wschód słońca:";
            // 
            // TemperaturaTekst
            // 
            this.TemperaturaTekst.AutoSize = true;
            this.TemperaturaTekst.Location = new System.Drawing.Point(110, 65);
            this.TemperaturaTekst.Name = "TemperaturaTekst";
            this.TemperaturaTekst.Size = new System.Drawing.Size(0, 13);
            this.TemperaturaTekst.TabIndex = 30;
            // 
            // WschódTekst
            // 
            this.WschódTekst.AutoSize = true;
            this.WschódTekst.Location = new System.Drawing.Point(110, 119);
            this.WschódTekst.Name = "WschódTekst";
            this.WschódTekst.Size = new System.Drawing.Size(0, 13);
            this.WschódTekst.TabIndex = 33;
            // 
            // Wiatr
            // 
            this.Wiatr.AutoSize = true;
            this.Wiatr.BackColor = System.Drawing.Color.LightCyan;
            this.Wiatr.Location = new System.Drawing.Point(251, 65);
            this.Wiatr.Name = "Wiatr";
            this.Wiatr.Size = new System.Drawing.Size(35, 13);
            this.Wiatr.TabIndex = 18;
            this.Wiatr.Text = "Wiatr:";
            // 
            // WiatrTekst
            // 
            this.WiatrTekst.AutoSize = true;
            this.WiatrTekst.Location = new System.Drawing.Point(337, 65);
            this.WiatrTekst.Name = "WiatrTekst";
            this.WiatrTekst.Size = new System.Drawing.Size(0, 13);
            this.WiatrTekst.TabIndex = 34;
            // 
            // Widoczność
            // 
            this.Widoczność.AutoSize = true;
            this.Widoczność.BackColor = System.Drawing.Color.LightCyan;
            this.Widoczność.Location = new System.Drawing.Point(251, 90);
            this.Widoczność.Name = "Widoczność";
            this.Widoczność.Size = new System.Drawing.Size(69, 13);
            this.Widoczność.TabIndex = 20;
            this.Widoczność.Text = "Widoczność:";
            // 
            // WidocznośćTekst
            // 
            this.WidocznośćTekst.AutoSize = true;
            this.WidocznośćTekst.Location = new System.Drawing.Point(337, 90);
            this.WidocznośćTekst.Name = "WidocznośćTekst";
            this.WidocznośćTekst.Size = new System.Drawing.Size(0, 13);
            this.WidocznośćTekst.TabIndex = 33;
            // 
            // ZachódSłońca
            // 
            this.ZachódSłońca.AutoSize = true;
            this.ZachódSłońca.BackColor = System.Drawing.Color.LightCyan;
            this.ZachódSłońca.Location = new System.Drawing.Point(251, 119);
            this.ZachódSłońca.Name = "ZachódSłońca";
            this.ZachódSłońca.Size = new System.Drawing.Size(83, 13);
            this.ZachódSłońca.TabIndex = 23;
            this.ZachódSłońca.Text = "Zachód słońca:";
            // 
            // ZachódTekst
            // 
            this.ZachódTekst.AutoSize = true;
            this.ZachódTekst.Location = new System.Drawing.Point(337, 119);
            this.ZachódTekst.Name = "ZachódTekst";
            this.ZachódTekst.Size = new System.Drawing.Size(0, 13);
            this.ZachódTekst.TabIndex = 35;
            // 
            // Rozdzielnik
            // 
            this.Rozdzielnik.Location = new System.Drawing.Point(3, 16);
            this.Rozdzielnik.Name = "Rozdzielnik";
            this.Rozdzielnik.Size = new System.Drawing.Size(3, 116);
            this.Rozdzielnik.TabIndex = 36;
            this.Rozdzielnik.TabStop = false;
            // 
            // Okienko
            // 
            this.Okienko.BackColor = System.Drawing.Color.LightCyan;
            this.Okienko.Controls.Add(this.WilgotnośćTekst);
            this.Okienko.Controls.Add(this.Rozdzielnik);
            this.Okienko.Controls.Add(this.ZachódTekst);
            this.Okienko.Controls.Add(this.ZachódSłońca);
            this.Okienko.Controls.Add(this.WidocznośćTekst);
            this.Okienko.Controls.Add(this.Widoczność);
            this.Okienko.Controls.Add(this.WiatrTekst);
            this.Okienko.Controls.Add(this.Wiatr);
            this.Okienko.Controls.Add(this.WschódTekst);
            this.Okienko.Controls.Add(this.TemperaturaTekst);
            this.Okienko.Controls.Add(this.Obrazek);
            this.Okienko.Controls.Add(this.WschódSłońca);
            this.Okienko.Controls.Add(this.Wilgotność);
            this.Okienko.Controls.Add(this.Temperatura);
            this.Okienko.Location = new System.Drawing.Point(17, 156);
            this.Okienko.Name = "Okienko";
            this.Okienko.Size = new System.Drawing.Size(535, 135);
            this.Okienko.TabIndex = 32;
            this.Okienko.TabStop = false;
            this.Okienko.Text = "Obecna pogoda";
            // 
            // ObecnaPogoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::PogodaApp.Properties.Resources.deszcz1;
            this.ClientSize = new System.Drawing.Size(584, 345);
            this.Controls.Add(this.PasekNarzędzi);
            this.Controls.Add(this.PogodaKolejne);
            this.Controls.Add(this.TytułTekst);
            this.Controls.Add(this.WyświetlObecną);
            this.Controls.Add(this.tekstPaństwo);
            this.Controls.Add(this.SkrótPaństwa);
            this.Controls.Add(this.tekstMiasto);
            this.Controls.Add(this.Miasto);
            this.Controls.Add(this.OgólneInformacje);
            this.Controls.Add(this.Okienko);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObecnaPogoda";
            this.Text = "Aplikacja pogodowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).EndInit();
            this.PasekNarzędzi.ResumeLayout(false);
            this.PasekNarzędzi.PerformLayout();
            this.Okienko.ResumeLayout(false);
            this.Okienko.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

       

        #endregion

        private System.Windows.Forms.Label OgólneInformacje;
        private System.Windows.Forms.Label Miasto;
        private System.Windows.Forms.TextBox tekstMiasto;
        private System.Windows.Forms.Label SkrótPaństwa;
        private System.Windows.Forms.TextBox tekstPaństwo;
        private System.Windows.Forms.Label TytułTekst;
        private System.Windows.Forms.Button PogodaKolejne;
        private System.Windows.Forms.Label WilgotnośćTekst;
        private System.Windows.Forms.ToolStrip PasekNarzędzi;
        private System.Windows.Forms.ToolStripLabel Plik;
        private System.Windows.Forms.ToolStripDropDownButton Notatnik;
        private System.Windows.Forms.ToolStripMenuItem Zapisz;
        private System.Windows.Forms.ToolStripSeparator Dzielnik;
        private System.Windows.Forms.Button WyświetlObecną;
        private System.Windows.Forms.PictureBox Obrazek;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Label Wilgotność;
        private System.Windows.Forms.Label WschódSłońca;
        private System.Windows.Forms.Label TemperaturaTekst;
        private System.Windows.Forms.Label WschódTekst;
        private System.Windows.Forms.Label Wiatr;
        private System.Windows.Forms.Label WiatrTekst;
        private System.Windows.Forms.Label Widoczność;
        private System.Windows.Forms.Label WidocznośćTekst;
        private System.Windows.Forms.Label ZachódSłońca;
        private System.Windows.Forms.Label ZachódTekst;
        private System.Windows.Forms.Splitter Rozdzielnik;
        private System.Windows.Forms.GroupBox Okienko;

    }
}

