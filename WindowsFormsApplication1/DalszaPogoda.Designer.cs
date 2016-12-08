namespace PogodaApp
{
    partial class DalszaPogoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DalszaPogoda));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.WarunkiPrognoza = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miejscowość = new System.Windows.Forms.Label();
            this.NastepnęDni = new System.Windows.Forms.Button();
            this.WykresPogoda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.WykresPogoda)).BeginInit();
            this.SuspendLayout();
            // 
            // WarunkiPrognoza
            // 
            this.WarunkiPrognoza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.WarunkiPrognoza.Location = new System.Drawing.Point(12, 89);
            this.WarunkiPrognoza.Name = "WarunkiPrognoza";
            this.WarunkiPrognoza.Size = new System.Drawing.Size(435, 379);
            this.WarunkiPrognoza.TabIndex = 24;
            this.WarunkiPrognoza.UseCompatibleStateImageBehavior = false;
            this.WarunkiPrognoza.View = System.Windows.Forms.View.Details;
            this.WarunkiPrognoza.SelectedIndexChanged += new System.EventHandler(this.lvwTemps_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dzień";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Czas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temperatura[°C]";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Wiatr[m/s]";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wilgotność[%]";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 140;
            // 
            // Miejscowość
            // 
            this.Miejscowość.AutoSize = true;
            this.Miejscowość.BackColor = System.Drawing.Color.Transparent;
            this.Miejscowość.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Miejscowość.Location = new System.Drawing.Point(98, 16);
            this.Miejscowość.Name = "Miejscowość";
            this.Miejscowość.Size = new System.Drawing.Size(158, 55);
            this.Miejscowość.TabIndex = 25;
            this.Miejscowość.Text = "label1";
            // 
            // NastepnęDni
            // 
            this.NastepnęDni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NastepnęDni.BackgroundImage")));
            this.NastepnęDni.Location = new System.Drawing.Point(663, 26);
            this.NastepnęDni.Name = "NastepnęDni";
            this.NastepnęDni.Size = new System.Drawing.Size(175, 45);
            this.NastepnęDni.TabIndex = 30;
            this.NastepnęDni.Text = "Wyświetl nastepnę dni";
            this.NastepnęDni.UseVisualStyleBackColor = true;
            this.NastepnęDni.Click += new System.EventHandler(this.button2_Click);
            // 
            // WykresPogoda
            // 
            this.WykresPogoda.BackImage = "C:\\Users\\samsung\\Desktop\\Obrazy\\Pogoda\\image.php.jpg";
            chartArea1.AxisX.Title = "Czas";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Temperatura[°C] / Wiatr[m/s]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "ChartArea1";
            this.WykresPogoda.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Oznaczenie";
            this.WykresPogoda.Legends.Add(legend1);
            this.WykresPogoda.Location = new System.Drawing.Point(447, 89);
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
            this.WykresPogoda.Size = new System.Drawing.Size(401, 379);
            this.WykresPogoda.TabIndex = 31;
            this.WykresPogoda.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Wykres Pogody";
            this.WykresPogoda.Titles.Add(title1);
            // 
            // DalszaPogoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PogodaApp.Properties.Resources.deszcz1;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.WykresPogoda);
            this.Controls.Add(this.NastepnęDni);
            this.Controls.Add(this.Miejscowość);
            this.Controls.Add(this.WarunkiPrognoza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DalszaPogoda";
            this.Text = "Aplikacja pogodowa";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.WykresPogoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ListView WarunkiPrognoza;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label Miejscowość;
        private System.Windows.Forms.Button NastepnęDni;
        private System.Windows.Forms.DataVisualization.Charting.Chart WykresPogoda;
    }
}