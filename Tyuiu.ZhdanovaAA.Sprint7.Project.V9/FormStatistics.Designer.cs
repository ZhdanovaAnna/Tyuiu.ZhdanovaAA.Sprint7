namespace WindowsFormsApp1
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMenuStatistics_ZAA = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStatisticsTime_ZAA = new System.Windows.Forms.Label();
            this.comboBoxStatisticsTime_ZAA = new System.Windows.Forms.ComboBox();
            this.groupBoxMenuStatistics_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenuStatistics_ZAA
            // 
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.comboBoxStatisticsTime_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelStatisticsTime_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.chart1);
            this.groupBoxMenuStatistics_ZAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenuStatistics_ZAA.Name = "groupBoxMenuStatistics_ZAA";
            this.groupBoxMenuStatistics_ZAA.Size = new System.Drawing.Size(776, 426);
            this.groupBoxMenuStatistics_ZAA.TabIndex = 0;
            this.groupBoxMenuStatistics_ZAA.TabStop = false;
            this.groupBoxMenuStatistics_ZAA.Text = "Статистика";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(275, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(495, 401);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelStatisticsTime_ZAA
            // 
            this.labelStatisticsTime_ZAA.AutoSize = true;
            this.labelStatisticsTime_ZAA.Location = new System.Drawing.Point(6, 28);
            this.labelStatisticsTime_ZAA.Name = "labelStatisticsTime_ZAA";
            this.labelStatisticsTime_ZAA.Size = new System.Drawing.Size(122, 13);
            this.labelStatisticsTime_ZAA.TabIndex = 1;
            this.labelStatisticsTime_ZAA.Text = "Статистика за период:";
            // 
            // comboBoxStatisticsTime_ZAA
            // 
            this.comboBoxStatisticsTime_ZAA.FormattingEnabled = true;
            this.comboBoxStatisticsTime_ZAA.Location = new System.Drawing.Point(135, 28);
            this.comboBoxStatisticsTime_ZAA.Name = "comboBoxStatisticsTime_ZAA";
            this.comboBoxStatisticsTime_ZAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatisticsTime_ZAA.TabIndex = 2;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxMenuStatistics_ZAA);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.groupBoxMenuStatistics_ZAA.ResumeLayout(false);
            this.groupBoxMenuStatistics_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenuStatistics_ZAA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelStatisticsTime_ZAA;
        private System.Windows.Forms.ComboBox comboBoxStatisticsTime_ZAA;
    }
}