﻿namespace WindowsFormsApp1
{
    partial class FormStatistics_ZAA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxMenuStatistics_ZAA = new System.Windows.Forms.GroupBox();
            this.buttonSearchStatistic_ZAA = new System.Windows.Forms.Button();
            this.comboBoxStatisticAction_ZAA = new System.Windows.Forms.ComboBox();
            this.labelStatisticAction_ZAA = new System.Windows.Forms.Label();
            this.labelSearchStatistic_ZAA = new System.Windows.Forms.Label();
            this.textBoxSearchStatistic_ZAA = new System.Windows.Forms.TextBox();
            this.comboBoxHeadersStatistic_ZAA = new System.Windows.Forms.ComboBox();
            this.labelHeadersStatistic_ZAA = new System.Windows.Forms.Label();
            this.labelEndRange_ZAA = new System.Windows.Forms.Label();
            this.textBoxEndRange_ZAA = new System.Windows.Forms.TextBox();
            this.labelBeginRange_ZAA = new System.Windows.Forms.Label();
            this.textBoxBeginRange_ZAA = new System.Windows.Forms.TextBox();
            this.comboBoxHeadersRange_ZAA = new System.Windows.Forms.ComboBox();
            this.labelHeadersRange_ZAA = new System.Windows.Forms.Label();
            this.chartStatistic_ZAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMenuStatistics_ZAA = new System.Windows.Forms.Panel();
            this.splitterMenuStatistics_ZAA = new System.Windows.Forms.Splitter();
            this.panelStatistics_ZAA = new System.Windows.Forms.Panel();
            this.toolTipStatistics_ZAA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMenuStatistics_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_ZAA)).BeginInit();
            this.panelMenuStatistics_ZAA.SuspendLayout();
            this.panelStatistics_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenuStatistics_ZAA
            // 
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.buttonSearchStatistic_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.comboBoxStatisticAction_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelStatisticAction_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelSearchStatistic_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.textBoxSearchStatistic_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.comboBoxHeadersStatistic_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelHeadersStatistic_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelEndRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.textBoxEndRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelBeginRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.textBoxBeginRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.comboBoxHeadersRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Controls.Add(this.labelHeadersRange_ZAA);
            this.groupBoxMenuStatistics_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenuStatistics_ZAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenuStatistics_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenuStatistics_ZAA.Name = "groupBoxMenuStatistics_ZAA";
            this.groupBoxMenuStatistics_ZAA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMenuStatistics_ZAA.Size = new System.Drawing.Size(596, 554);
            this.groupBoxMenuStatistics_ZAA.TabIndex = 0;
            this.groupBoxMenuStatistics_ZAA.TabStop = false;
            this.groupBoxMenuStatistics_ZAA.Text = "Статистика";
            // 
            // buttonSearchStatistic_ZAA
            // 
            this.buttonSearchStatistic_ZAA.Enabled = false;
            this.buttonSearchStatistic_ZAA.Location = new System.Drawing.Point(245, 395);
            this.buttonSearchStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchStatistic_ZAA.Name = "buttonSearchStatistic_ZAA";
            this.buttonSearchStatistic_ZAA.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchStatistic_ZAA.TabIndex = 15;
            this.buttonSearchStatistic_ZAA.Text = "Поиск";
            this.toolTipStatistics_ZAA.SetToolTip(this.buttonSearchStatistic_ZAA, "Начать поиск");
            this.buttonSearchStatistic_ZAA.UseVisualStyleBackColor = true;
            this.buttonSearchStatistic_ZAA.Click += new System.EventHandler(this.buttonSearchStatistic_ZAA_Click);
            // 
            // comboBoxStatisticAction_ZAA
            // 
            this.comboBoxStatisticAction_ZAA.FormattingEnabled = true;
            this.comboBoxStatisticAction_ZAA.Location = new System.Drawing.Point(245, 318);
            this.comboBoxStatisticAction_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStatisticAction_ZAA.Name = "comboBoxStatisticAction_ZAA";
            this.comboBoxStatisticAction_ZAA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxStatisticAction_ZAA.TabIndex = 14;
            this.toolTipStatistics_ZAA.SetToolTip(this.comboBoxStatisticAction_ZAA, "Выберите функцию статистики");
            this.comboBoxStatisticAction_ZAA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelStatisticAction_ZAA
            // 
            this.labelStatisticAction_ZAA.AutoSize = true;
            this.labelStatisticAction_ZAA.Location = new System.Drawing.Point(35, 318);
            this.labelStatisticAction_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatisticAction_ZAA.Name = "labelStatisticAction_ZAA";
            this.labelStatisticAction_ZAA.Size = new System.Drawing.Size(189, 20);
            this.labelStatisticAction_ZAA.TabIndex = 13;
            this.labelStatisticAction_ZAA.Text = "Значение статистики*";
            // 
            // labelSearchStatistic_ZAA
            // 
            this.labelSearchStatistic_ZAA.AutoSize = true;
            this.labelSearchStatistic_ZAA.Location = new System.Drawing.Point(35, 276);
            this.labelSearchStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchStatistic_ZAA.Name = "labelSearchStatistic_ZAA";
            this.labelSearchStatistic_ZAA.Size = new System.Drawing.Size(126, 20);
            this.labelSearchStatistic_ZAA.TabIndex = 12;
            this.labelSearchStatistic_ZAA.Text = "Значение поля";
            // 
            // textBoxSearchStatistic_ZAA
            // 
            this.textBoxSearchStatistic_ZAA.Location = new System.Drawing.Point(245, 276);
            this.textBoxSearchStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchStatistic_ZAA.Name = "textBoxSearchStatistic_ZAA";
            this.textBoxSearchStatistic_ZAA.Size = new System.Drawing.Size(160, 27);
            this.textBoxSearchStatistic_ZAA.TabIndex = 11;
            this.toolTipStatistics_ZAA.SetToolTip(this.textBoxSearchStatistic_ZAA, "Введите значение для поиска количества");
            // 
            // comboBoxHeadersStatistic_ZAA
            // 
            this.comboBoxHeadersStatistic_ZAA.FormattingEnabled = true;
            this.comboBoxHeadersStatistic_ZAA.Location = new System.Drawing.Point(245, 217);
            this.comboBoxHeadersStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHeadersStatistic_ZAA.Name = "comboBoxHeadersStatistic_ZAA";
            this.comboBoxHeadersStatistic_ZAA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeadersStatistic_ZAA.TabIndex = 10;
            this.toolTipStatistics_ZAA.SetToolTip(this.comboBoxHeadersStatistic_ZAA, "Выберите поле, для которого строится статистика");
            this.comboBoxHeadersStatistic_ZAA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelHeadersStatistic_ZAA
            // 
            this.labelHeadersStatistic_ZAA.AutoSize = true;
            this.labelHeadersStatistic_ZAA.Location = new System.Drawing.Point(35, 217);
            this.labelHeadersStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadersStatistic_ZAA.Name = "labelHeadersStatistic_ZAA";
            this.labelHeadersStatistic_ZAA.Size = new System.Drawing.Size(117, 20);
            this.labelHeadersStatistic_ZAA.TabIndex = 9;
            this.labelHeadersStatistic_ZAA.Text = "Поле поиска*";
            // 
            // labelEndRange_ZAA
            // 
            this.labelEndRange_ZAA.AutoSize = true;
            this.labelEndRange_ZAA.Location = new System.Drawing.Point(35, 127);
            this.labelEndRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndRange_ZAA.Name = "labelEndRange_ZAA";
            this.labelEndRange_ZAA.Size = new System.Drawing.Size(171, 20);
            this.labelEndRange_ZAA.TabIndex = 8;
            this.labelEndRange_ZAA.Text = "Конечное значение*";
            // 
            // textBoxEndRange_ZAA
            // 
            this.textBoxEndRange_ZAA.Location = new System.Drawing.Point(245, 127);
            this.textBoxEndRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEndRange_ZAA.Name = "textBoxEndRange_ZAA";
            this.textBoxEndRange_ZAA.Size = new System.Drawing.Size(160, 27);
            this.textBoxEndRange_ZAA.TabIndex = 7;
            this.toolTipStatistics_ZAA.SetToolTip(this.textBoxEndRange_ZAA, "Максимальное значение диапазона");
            this.textBoxEndRange_ZAA.TextChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelBeginRange_ZAA
            // 
            this.labelBeginRange_ZAA.AutoSize = true;
            this.labelBeginRange_ZAA.Location = new System.Drawing.Point(35, 87);
            this.labelBeginRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeginRange_ZAA.Name = "labelBeginRange_ZAA";
            this.labelBeginRange_ZAA.Size = new System.Drawing.Size(180, 20);
            this.labelBeginRange_ZAA.TabIndex = 6;
            this.labelBeginRange_ZAA.Text = "Начальное значение*";
            // 
            // textBoxBeginRange_ZAA
            // 
            this.textBoxBeginRange_ZAA.Location = new System.Drawing.Point(245, 87);
            this.textBoxBeginRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBeginRange_ZAA.Name = "textBoxBeginRange_ZAA";
            this.textBoxBeginRange_ZAA.Size = new System.Drawing.Size(160, 27);
            this.textBoxBeginRange_ZAA.TabIndex = 5;
            this.toolTipStatistics_ZAA.SetToolTip(this.textBoxBeginRange_ZAA, "Введите минимальное значение диапазона");
            this.textBoxBeginRange_ZAA.TextChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // comboBoxHeadersRange_ZAA
            // 
            this.comboBoxHeadersRange_ZAA.FormattingEnabled = true;
            this.comboBoxHeadersRange_ZAA.Location = new System.Drawing.Point(245, 27);
            this.comboBoxHeadersRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHeadersRange_ZAA.Name = "comboBoxHeadersRange_ZAA";
            this.comboBoxHeadersRange_ZAA.Size = new System.Drawing.Size(160, 27);
            this.comboBoxHeadersRange_ZAA.TabIndex = 4;
            this.toolTipStatistics_ZAA.SetToolTip(this.comboBoxHeadersRange_ZAA, "Выберите поле для периода статистики");
            this.comboBoxHeadersRange_ZAA.SelectedIndexChanged += new System.EventHandler(this.statisticParameterChange);
            // 
            // labelHeadersRange_ZAA
            // 
            this.labelHeadersRange_ZAA.AutoSize = true;
            this.labelHeadersRange_ZAA.Location = new System.Drawing.Point(35, 27);
            this.labelHeadersRange_ZAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadersRange_ZAA.Name = "labelHeadersRange_ZAA";
            this.labelHeadersRange_ZAA.Size = new System.Drawing.Size(126, 20);
            this.labelHeadersRange_ZAA.TabIndex = 3;
            this.labelHeadersRange_ZAA.Text = "Поле периода*";
            // 
            // chartStatistic_ZAA
            // 
            this.chartStatistic_ZAA.BorderlineWidth = 0;
            this.chartStatistic_ZAA.BorderSkin.BorderWidth = 0;
            chartArea8.Name = "ChartArea1";
            this.chartStatistic_ZAA.ChartAreas.Add(chartArea8);
            this.chartStatistic_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.chartStatistic_ZAA.Legends.Add(legend8);
            this.chartStatistic_ZAA.Location = new System.Drawing.Point(0, 0);
            this.chartStatistic_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartStatistic_ZAA.Name = "chartStatistic_ZAA";
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series_ZAA";
            series8.ToolTip = "#VALY, #VALX";
            this.chartStatistic_ZAA.Series.Add(series8);
            this.chartStatistic_ZAA.Size = new System.Drawing.Size(660, 554);
            this.chartStatistic_ZAA.TabIndex = 0;
            this.chartStatistic_ZAA.Text = "chart1";
            // 
            // panelMenuStatistics_ZAA
            // 
            this.panelMenuStatistics_ZAA.Controls.Add(this.groupBoxMenuStatistics_ZAA);
            this.panelMenuStatistics_ZAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuStatistics_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenuStatistics_ZAA.Location = new System.Drawing.Point(0, 0);
            this.panelMenuStatistics_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuStatistics_ZAA.Name = "panelMenuStatistics_ZAA";
            this.panelMenuStatistics_ZAA.Size = new System.Drawing.Size(596, 554);
            this.panelMenuStatistics_ZAA.TabIndex = 1;
            // 
            // splitterMenuStatistics_ZAA
            // 
            this.splitterMenuStatistics_ZAA.Location = new System.Drawing.Point(596, 0);
            this.splitterMenuStatistics_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitterMenuStatistics_ZAA.Name = "splitterMenuStatistics_ZAA";
            this.splitterMenuStatistics_ZAA.Size = new System.Drawing.Size(4, 554);
            this.splitterMenuStatistics_ZAA.TabIndex = 2;
            this.splitterMenuStatistics_ZAA.TabStop = false;
            // 
            // panelStatistics_ZAA
            // 
            this.panelStatistics_ZAA.Controls.Add(this.chartStatistic_ZAA);
            this.panelStatistics_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatistics_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStatistics_ZAA.Location = new System.Drawing.Point(600, 0);
            this.panelStatistics_ZAA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStatistics_ZAA.Name = "panelStatistics_ZAA";
            this.panelStatistics_ZAA.Size = new System.Drawing.Size(660, 554);
            this.panelStatistics_ZAA.TabIndex = 3;
            // 
            // toolTipStatistics_ZAA
            // 
            this.toolTipStatistics_ZAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipStatistics_ZAA.ToolTipTitle = "Информация";
            // 
            // FormStatistics_ZAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 554);
            this.Controls.Add(this.panelStatistics_ZAA);
            this.Controls.Add(this.splitterMenuStatistics_ZAA);
            this.Controls.Add(this.panelMenuStatistics_ZAA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1275, 591);
            this.Name = "FormStatistics_ZAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика с графиком";
            this.groupBoxMenuStatistics_ZAA.ResumeLayout(false);
            this.groupBoxMenuStatistics_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic_ZAA)).EndInit();
            this.panelMenuStatistics_ZAA.ResumeLayout(false);
            this.panelStatistics_ZAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenuStatistics_ZAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic_ZAA;
        private System.Windows.Forms.TextBox textBoxBeginRange_ZAA;
        private System.Windows.Forms.ComboBox comboBoxHeadersRange_ZAA;
        private System.Windows.Forms.Label labelHeadersRange_ZAA;
        private System.Windows.Forms.ComboBox comboBoxStatisticAction_ZAA;
        private System.Windows.Forms.Label labelStatisticAction_ZAA;
        private System.Windows.Forms.Label labelSearchStatistic_ZAA;
        private System.Windows.Forms.TextBox textBoxSearchStatistic_ZAA;
        private System.Windows.Forms.ComboBox comboBoxHeadersStatistic_ZAA;
        private System.Windows.Forms.Label labelHeadersStatistic_ZAA;
        private System.Windows.Forms.Label labelEndRange_ZAA;
        private System.Windows.Forms.TextBox textBoxEndRange_ZAA;
        private System.Windows.Forms.Label labelBeginRange_ZAA;
        private System.Windows.Forms.Button buttonSearchStatistic_ZAA;
        private System.Windows.Forms.Panel panelMenuStatistics_ZAA;
        private System.Windows.Forms.Splitter splitterMenuStatistics_ZAA;
        private System.Windows.Forms.Panel panelStatistics_ZAA;
        private System.Windows.Forms.ToolTip toolTipStatistics_ZAA;
    }
}