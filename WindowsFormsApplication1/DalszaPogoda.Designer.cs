namespace PogodaApp
{
    partial class DalszaPogoda
    {
        
        private System.ComponentModel.IContainer komponenty = null;

       
        protected override void Dispose(bool zamkniecie)
        {
            if (zamkniecie && (komponenty != null))
            {
                komponenty.Dispose();
            }
            base.Dispose(zamkniecie);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DalszaPogoda));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.WarunkiPrognoza = new System.Windows.Forms.ListView();
            this.NagłówekKolumny1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NagłówekKolumny2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NagłówekKolumny3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NagłówekKolumny4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NagłówekKolumny5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miejscowość = new System.Windows.Forms.Label();
            this.NastepnęDni = new System.Windows.Forms.Button();
            this.WykresPogoda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.WykresPogoda)).BeginInit();
            this.SuspendLayout();
            // 
            // WarunkiPrognoza
            // 
            this.WarunkiPrognoza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NagłówekKolumny1,
            this.NagłówekKolumny2,
            this.NagłówekKolumny3,
            this.NagłówekKolumny4,
            this.NagłówekKolumny5});
            resources.ApplyResources(this.WarunkiPrognoza, "WarunkiPrognoza");
            this.WarunkiPrognoza.Name = "WarunkiPrognoza";
            this.WarunkiPrognoza.UseCompatibleStateImageBehavior = false;
            this.WarunkiPrognoza.View = System.Windows.Forms.View.Details;
            // 
            // NagłówekKolumny1
            // 
            resources.ApplyResources(this.NagłówekKolumny1, "NagłówekKolumny1");
            // 
            // NagłówekKolumny2
            // 
            resources.ApplyResources(this.NagłówekKolumny2, "NagłówekKolumny2");
            // 
            // NagłówekKolumny3
            // 
            resources.ApplyResources(this.NagłówekKolumny3, "NagłówekKolumny3");
            // 
            // NagłówekKolumny4
            // 
            resources.ApplyResources(this.NagłówekKolumny4, "NagłówekKolumny4");
            // 
            // NagłówekKolumny5
            // 
            resources.ApplyResources(this.NagłówekKolumny5, "NagłówekKolumny5");
            // 
            // Miejscowość
            // 
            resources.ApplyResources(this.Miejscowość, "Miejscowość");
            this.Miejscowość.BackColor = System.Drawing.Color.Transparent;
            this.Miejscowość.Name = "Miejscowość";
            // 
            // NastepnęDni
            // 
            resources.ApplyResources(this.NastepnęDni, "NastepnęDni");
            this.NastepnęDni.Name = "NastepnęDni";
            this.NastepnęDni.UseVisualStyleBackColor = true;
            this.NastepnęDni.Click += new System.EventHandler(this.KliknieciePrzycisku);
            // 
            // WykresPogoda
            // 
            this.WykresPogoda.BackColor = System.Drawing.Color.MidnightBlue;
            this.WykresPogoda.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.AxisX.Title = "Czas";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Temperatura[°C] / Wiatr[m/s]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "ChartArea1";
            this.WykresPogoda.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Oznaczenie";
            this.WykresPogoda.Legends.Add(legend1);
            resources.ApplyResources(this.WykresPogoda, "WykresPogoda");
            this.WykresPogoda.Name = "WykresPogoda";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkGreen;
            series2.Legend = "Legend1";
            series2.Name = "Predkość Wiatru";
            this.WykresPogoda.Series.Add(series1);
            this.WykresPogoda.Series.Add(series2);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Wykres Pogody";
            this.WykresPogoda.Titles.Add(title1);
            // 
            // DalszaPogoda
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::PogodaApp.Properties.Resources.deszcz1;
            this.Controls.Add(this.WykresPogoda);
            this.Controls.Add(this.NastepnęDni);
            this.Controls.Add(this.Miejscowość);
            this.Controls.Add(this.WarunkiPrognoza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DalszaPogoda";
            this.Load += new System.EventHandler(this.UstawienieNazwy);
            ((System.ComponentModel.ISupportInitialize)(this.WykresPogoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ListView WarunkiPrognoza;
        private System.Windows.Forms.ColumnHeader NagłówekKolumny1;
        private System.Windows.Forms.ColumnHeader NagłówekKolumny2;
        private System.Windows.Forms.ColumnHeader NagłówekKolumny3;
        private System.Windows.Forms.ColumnHeader NagłówekKolumny4;
        private System.Windows.Forms.ColumnHeader NagłówekKolumny5;
        private System.Windows.Forms.Label Miejscowość;
        private System.Windows.Forms.Button NastepnęDni;
        private System.Windows.Forms.DataVisualization.Charting.Chart WykresPogoda;
    }
}