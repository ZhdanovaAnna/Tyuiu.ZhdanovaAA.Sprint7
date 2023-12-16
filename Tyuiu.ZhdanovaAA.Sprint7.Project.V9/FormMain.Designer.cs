namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMenu_ZAA = new System.Windows.Forms.GroupBox();
            this.buttonSave_ZAA = new System.Windows.Forms.Button();
            this.buttonOpen_ZAA = new System.Windows.Forms.Button();
            this.buttonInfo_ZAA = new System.Windows.Forms.Button();
            this.groupBoxData_ZAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_ZAA = new System.Windows.Forms.DataGridView();
            this.buttonReset_ZAA = new System.Windows.Forms.Button();
            this.buttonSearchLine_ZAA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHeaders_ZAA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchline_ZAA = new System.Windows.Forms.TextBox();
            this.groupBoxStatistic_ZAA = new System.Windows.Forms.GroupBox();
            this.buttonStatisticSearch_ZAA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatisticAction_ZAA = new System.Windows.Forms.ComboBox();
            this.comboBoxHeadersStatistic_ZAA = new System.Windows.Forms.ComboBox();
            this.toolTip_ZAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_ZAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_ZAA = new System.Windows.Forms.SaveFileDialog();
            this.buttonDeleteRow_ZAA = new System.Windows.Forms.Button();
            this.textBoxStatisticResult_ZAA = new System.Windows.Forms.TextBox();
            this.comboBoxSearchStatistic_ZAA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMenu_ZAA.SuspendLayout();
            this.groupBoxData_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZAA)).BeginInit();
            this.groupBoxStatistic_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu_ZAA
            // 
            this.groupBoxMenu_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonSave_ZAA);
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonOpen_ZAA);
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonInfo_ZAA);
            this.groupBoxMenu_ZAA.Location = new System.Drawing.Point(12, 5);
            this.groupBoxMenu_ZAA.Name = "groupBoxMenu_ZAA";
            this.groupBoxMenu_ZAA.Size = new System.Drawing.Size(921, 71);
            this.groupBoxMenu_ZAA.TabIndex = 0;
            this.groupBoxMenu_ZAA.TabStop = false;
            this.groupBoxMenu_ZAA.Text = "Меню";
            // 
            // buttonSave_ZAA
            // 
            this.buttonSave_ZAA.Location = new System.Drawing.Point(87, 19);
            this.buttonSave_ZAA.Name = "buttonSave_ZAA";
            this.buttonSave_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonSave_ZAA.TabIndex = 2;
            this.buttonSave_ZAA.Text = "Сохранить";
            this.toolTip_ZAA.SetToolTip(this.buttonSave_ZAA, "Сохранить файл в формате .csv");
            this.buttonSave_ZAA.UseVisualStyleBackColor = true;
            this.buttonSave_ZAA.Click += new System.EventHandler(this.buttonSave_ZAA_Click);
            // 
            // buttonOpen_ZAA
            // 
            this.buttonOpen_ZAA.Location = new System.Drawing.Point(6, 19);
            this.buttonOpen_ZAA.Name = "buttonOpen_ZAA";
            this.buttonOpen_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen_ZAA.TabIndex = 1;
            this.buttonOpen_ZAA.Text = "Открыть";
            this.toolTip_ZAA.SetToolTip(this.buttonOpen_ZAA, "Открыть файл CSV");
            this.buttonOpen_ZAA.UseVisualStyleBackColor = true;
            this.buttonOpen_ZAA.Click += new System.EventHandler(this.buttonOpen_ZAA_Click);
            // 
            // buttonInfo_ZAA
            // 
            this.buttonInfo_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_ZAA.Location = new System.Drawing.Point(835, 19);
            this.buttonInfo_ZAA.Name = "buttonInfo_ZAA";
            this.buttonInfo_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo_ZAA.TabIndex = 0;
            this.buttonInfo_ZAA.Text = "Инфо";
            this.toolTip_ZAA.SetToolTip(this.buttonInfo_ZAA, "О программе");
            this.buttonInfo_ZAA.UseVisualStyleBackColor = true;
            // 
            // groupBoxData_ZAA
            // 
            this.groupBoxData_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_ZAA.Controls.Add(this.buttonDeleteRow_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.dataGridViewData_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.buttonReset_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.buttonSearchLine_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.label2);
            this.groupBoxData_ZAA.Controls.Add(this.comboBoxHeaders_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.label1);
            this.groupBoxData_ZAA.Controls.Add(this.textBoxSearchline_ZAA);
            this.groupBoxData_ZAA.Location = new System.Drawing.Point(12, 92);
            this.groupBoxData_ZAA.Name = "groupBoxData_ZAA";
            this.groupBoxData_ZAA.Size = new System.Drawing.Size(617, 346);
            this.groupBoxData_ZAA.TabIndex = 0;
            this.groupBoxData_ZAA.TabStop = false;
            this.groupBoxData_ZAA.Text = "Данные";
            // 
            // dataGridViewData_ZAA
            // 
            this.dataGridViewData_ZAA.AllowUserToOrderColumns = true;
            this.dataGridViewData_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData_ZAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_ZAA.Location = new System.Drawing.Point(10, 49);
            this.dataGridViewData_ZAA.Name = "dataGridViewData_ZAA";
            this.dataGridViewData_ZAA.Size = new System.Drawing.Size(595, 291);
            this.dataGridViewData_ZAA.TabIndex = 5;
            // 
            // buttonReset_ZAA
            // 
            this.buttonReset_ZAA.Location = new System.Drawing.Point(370, 19);
            this.buttonReset_ZAA.Name = "buttonReset_ZAA";
            this.buttonReset_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonReset_ZAA.TabIndex = 4;
            this.buttonReset_ZAA.Text = "Сбросить";
            this.toolTip_ZAA.SetToolTip(this.buttonReset_ZAA, "Сбросить поиск");
            this.buttonReset_ZAA.UseVisualStyleBackColor = true;
            this.buttonReset_ZAA.Click += new System.EventHandler(this.buttonReset_ZAA_Click);
            // 
            // buttonSearchLine_ZAA
            // 
            this.buttonSearchLine_ZAA.Enabled = false;
            this.buttonSearchLine_ZAA.Location = new System.Drawing.Point(316, 19);
            this.buttonSearchLine_ZAA.Name = "buttonSearchLine_ZAA";
            this.buttonSearchLine_ZAA.Size = new System.Drawing.Size(48, 23);
            this.buttonSearchLine_ZAA.TabIndex = 1;
            this.buttonSearchLine_ZAA.Text = "Найти";
            this.toolTip_ZAA.SetToolTip(this.buttonSearchLine_ZAA, "Найти записи по выбранным параметрам");
            this.buttonSearchLine_ZAA.UseVisualStyleBackColor = true;
            this.buttonSearchLine_ZAA.Click += new System.EventHandler(this.buttonSearchLine_ZAA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поле";
            // 
            // comboBoxHeaders_ZAA
            // 
            this.comboBoxHeaders_ZAA.FormattingEnabled = true;
            this.comboBoxHeaders_ZAA.Location = new System.Drawing.Point(189, 21);
            this.comboBoxHeaders_ZAA.Name = "comboBoxHeaders_ZAA";
            this.comboBoxHeaders_ZAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHeaders_ZAA.TabIndex = 2;
            this.toolTip_ZAA.SetToolTip(this.comboBoxHeaders_ZAA, "Выбор поля для поиска");
            this.comboBoxHeaders_ZAA.SelectedValueChanged += new System.EventHandler(this.comboBoxHeaders_ZAA_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // textBoxSearchline_ZAA
            // 
            this.textBoxSearchline_ZAA.Location = new System.Drawing.Point(52, 22);
            this.textBoxSearchline_ZAA.Name = "textBoxSearchline_ZAA";
            this.textBoxSearchline_ZAA.Size = new System.Drawing.Size(93, 20);
            this.textBoxSearchline_ZAA.TabIndex = 0;
            this.toolTip_ZAA.SetToolTip(this.textBoxSearchline_ZAA, "Текст, который необходимо найти");
            // 
            // groupBoxStatistic_ZAA
            // 
            this.groupBoxStatistic_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistic_ZAA.Controls.Add(this.label5);
            this.groupBoxStatistic_ZAA.Controls.Add(this.comboBoxSearchStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.textBoxStatisticResult_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.buttonStatisticSearch_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.label4);
            this.groupBoxStatistic_ZAA.Controls.Add(this.label3);
            this.groupBoxStatistic_ZAA.Controls.Add(this.comboBoxStatisticAction_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.comboBoxHeadersStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Location = new System.Drawing.Point(635, 92);
            this.groupBoxStatistic_ZAA.Name = "groupBoxStatistic_ZAA";
            this.groupBoxStatistic_ZAA.Size = new System.Drawing.Size(297, 345);
            this.groupBoxStatistic_ZAA.TabIndex = 1;
            this.groupBoxStatistic_ZAA.TabStop = false;
            this.groupBoxStatistic_ZAA.Text = "Статистика";
            // 
            // buttonStatisticSearch_ZAA
            // 
            this.buttonStatisticSearch_ZAA.Enabled = false;
            this.buttonStatisticSearch_ZAA.Location = new System.Drawing.Point(114, 205);
            this.buttonStatisticSearch_ZAA.Name = "buttonStatisticSearch_ZAA";
            this.buttonStatisticSearch_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonStatisticSearch_ZAA.TabIndex = 6;
            this.buttonStatisticSearch_ZAA.Text = "Найти";
            this.buttonStatisticSearch_ZAA.UseVisualStyleBackColor = true;
            this.buttonStatisticSearch_ZAA.Click += new System.EventHandler(this.buttonStatisticSearch_ZAA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Значение\r\nстатистики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поле";
            // 
            // comboBoxStatisticAction_ZAA
            // 
            this.comboBoxStatisticAction_ZAA.FormattingEnabled = true;
            this.comboBoxStatisticAction_ZAA.Location = new System.Drawing.Point(88, 178);
            this.comboBoxStatisticAction_ZAA.Name = "comboBoxStatisticAction_ZAA";
            this.comboBoxStatisticAction_ZAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatisticAction_ZAA.TabIndex = 4;
            this.comboBoxStatisticAction_ZAA.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeadersStatistic_ZAA_SelectedIndexChanged);
            // 
            // comboBoxHeadersStatistic_ZAA
            // 
            this.comboBoxHeadersStatistic_ZAA.FormattingEnabled = true;
            this.comboBoxHeadersStatistic_ZAA.Location = new System.Drawing.Point(88, 25);
            this.comboBoxHeadersStatistic_ZAA.Name = "comboBoxHeadersStatistic_ZAA";
            this.comboBoxHeadersStatistic_ZAA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHeadersStatistic_ZAA.TabIndex = 3;
            this.comboBoxHeadersStatistic_ZAA.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeadersStatistic_ZAA_SelectedIndexChanged);
            // 
            // toolTip_ZAA
            // 
            this.toolTip_ZAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_ZAA.ToolTipTitle = "Информация";
            // 
            // openFileDialog_ZAA
            // 
            this.openFileDialog_ZAA.FileName = "openFileDialog_ZAA";
            this.openFileDialog_ZAA.Filter = "CSV|*.csv";
            // 
            // saveFileDialog_ZAA
            // 
            this.saveFileDialog_ZAA.Filter = "CSV|*.csv";
            // 
            // buttonDeleteRow_ZAA
            // 
            this.buttonDeleteRow_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRow_ZAA.Location = new System.Drawing.Point(522, 18);
            this.buttonDeleteRow_ZAA.Name = "buttonDeleteRow_ZAA";
            this.buttonDeleteRow_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRow_ZAA.TabIndex = 6;
            this.buttonDeleteRow_ZAA.Text = "Удалить";
            this.toolTip_ZAA.SetToolTip(this.buttonDeleteRow_ZAA, "Удаление выбранной строки");
            this.buttonDeleteRow_ZAA.UseVisualStyleBackColor = true;
            this.buttonDeleteRow_ZAA.Click += new System.EventHandler(this.buttonDeleteRow_ZAA_Click);
            // 
            // textBoxStatisticResult_ZAA
            // 
            this.textBoxStatisticResult_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatisticResult_ZAA.Location = new System.Drawing.Point(7, 234);
            this.textBoxStatisticResult_ZAA.Multiline = true;
            this.textBoxStatisticResult_ZAA.Name = "textBoxStatisticResult_ZAA";
            this.textBoxStatisticResult_ZAA.ReadOnly = true;
            this.textBoxStatisticResult_ZAA.Size = new System.Drawing.Size(280, 105);
            this.textBoxStatisticResult_ZAA.TabIndex = 8;
            // 
            // comboBoxSearchStatistic_ZAA
            // 
            this.comboBoxSearchStatistic_ZAA.Location = new System.Drawing.Point(88, 55);
            this.comboBoxSearchStatistic_ZAA.Name = "comboBoxSearchStatistic_ZAA";
            this.comboBoxSearchStatistic_ZAA.Size = new System.Drawing.Size(121, 20);
            this.comboBoxSearchStatistic_ZAA.TabIndex = 7;
            this.toolTip_ZAA.SetToolTip(this.comboBoxSearchStatistic_ZAA, "Текст, который необходимо найти");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Значение";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.groupBoxStatistic_ZAA);
            this.Controls.Add(this.groupBoxData_ZAA);
            this.Controls.Add(this.groupBoxMenu_ZAA);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxMenu_ZAA.ResumeLayout(false);
            this.groupBoxData_ZAA.ResumeLayout(false);
            this.groupBoxData_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZAA)).EndInit();
            this.groupBoxStatistic_ZAA.ResumeLayout(false);
            this.groupBoxStatistic_ZAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu_ZAA;
        private System.Windows.Forms.GroupBox groupBoxData_ZAA;
        private System.Windows.Forms.Button buttonInfo_ZAA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHeaders_ZAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchline_ZAA;
        private System.Windows.Forms.Button buttonReset_ZAA;
        private System.Windows.Forms.Button buttonSearchLine_ZAA;
        private System.Windows.Forms.Button buttonSave_ZAA;
        private System.Windows.Forms.Button buttonOpen_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewData_ZAA;
        private System.Windows.Forms.GroupBox groupBoxStatistic_ZAA;
        private System.Windows.Forms.Button buttonStatisticSearch_ZAA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatisticAction_ZAA;
        private System.Windows.Forms.ComboBox comboBoxHeadersStatistic_ZAA;
        private System.Windows.Forms.ToolTip toolTip_ZAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ZAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ZAA;
        private System.Windows.Forms.Button buttonDeleteRow_ZAA;
        private System.Windows.Forms.TextBox textBoxStatisticResult_ZAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comboBoxSearchStatistic_ZAA;
    }
}

