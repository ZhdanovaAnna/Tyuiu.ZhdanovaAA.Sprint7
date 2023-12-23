namespace WindowsFormsApp1
{
    partial class FormMain_ZAA
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
            this.buttonInstructions_ZAA = new System.Windows.Forms.Button();
            this.buttonOpenInfo_ZAA = new System.Windows.Forms.Button();
            this.groupBoxData_ZAA = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRow_ZAA = new System.Windows.Forms.Button();
            this.dataGridViewData_ZAA = new System.Windows.Forms.DataGridView();
            this.buttonReset_ZAA = new System.Windows.Forms.Button();
            this.buttonSearchLine_ZAA = new System.Windows.Forms.Button();
            this.labelHeaders_ZAA = new System.Windows.Forms.Label();
            this.comboBoxHeaders_ZAA = new System.Windows.Forms.ComboBox();
            this.labelSearchline_ZAA = new System.Windows.Forms.Label();
            this.textBoxSearchline_ZAA = new System.Windows.Forms.TextBox();
            this.groupBoxStatistic_ZAA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFormStatistic_ZAA = new System.Windows.Forms.Button();
            this.labelSearchStatistic_ZAA = new System.Windows.Forms.Label();
            this.textBoxSearchStatistic_ZAA = new System.Windows.Forms.TextBox();
            this.textBoxStatisticResult_ZAA = new System.Windows.Forms.TextBox();
            this.buttonStatisticSearch_ZAA = new System.Windows.Forms.Button();
            this.labelStatisticAction_ZAA = new System.Windows.Forms.Label();
            this.labelHeadersStatistic_ZAA = new System.Windows.Forms.Label();
            this.comboBoxStatisticAction_ZAA = new System.Windows.Forms.ComboBox();
            this.comboBoxHeadersStatistic_ZAA = new System.Windows.Forms.ComboBox();
            this.toolTip_ZAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_ZAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_ZAA = new System.Windows.Forms.SaveFileDialog();
            this.panelMenu_ZAA = new System.Windows.Forms.Panel();
            this.panelData_ZAA = new System.Windows.Forms.Panel();
            this.panelStatistic_ZAA = new System.Windows.Forms.Panel();
            this.groupBoxMenu_ZAA.SuspendLayout();
            this.groupBoxData_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZAA)).BeginInit();
            this.groupBoxStatistic_ZAA.SuspendLayout();
            this.panelMenu_ZAA.SuspendLayout();
            this.panelData_ZAA.SuspendLayout();
            this.panelStatistic_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu_ZAA
            // 
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonSave_ZAA);
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonOpen_ZAA);
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonInstructions_ZAA);
            this.groupBoxMenu_ZAA.Controls.Add(this.buttonOpenInfo_ZAA);
            this.groupBoxMenu_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenu_ZAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu_ZAA.Name = "groupBoxMenu_ZAA";
            this.groupBoxMenu_ZAA.Size = new System.Drawing.Size(945, 86);
            this.groupBoxMenu_ZAA.TabIndex = 0;
            this.groupBoxMenu_ZAA.TabStop = false;
            this.groupBoxMenu_ZAA.Text = "Меню";
            // 
            // buttonSave_ZAA
            // 
            this.buttonSave_ZAA.Location = new System.Drawing.Point(87, 19);
            this.buttonSave_ZAA.Name = "buttonSave_ZAA";
            this.buttonSave_ZAA.Size = new System.Drawing.Size(80, 23);
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
            // buttonInstructions_ZAA
            // 
            this.buttonInstructions_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstructions_ZAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstructions_ZAA.Location = new System.Drawing.Point(821, 19);
            this.buttonInstructions_ZAA.Name = "buttonInstructions_ZAA";
            this.buttonInstructions_ZAA.Size = new System.Drawing.Size(32, 23);
            this.buttonInstructions_ZAA.TabIndex = 0;
            this.buttonInstructions_ZAA.Text = "?";
            this.buttonInstructions_ZAA.UseVisualStyleBackColor = true;
            this.buttonInstructions_ZAA.Click += new System.EventHandler(this.buttonInstructions_ZAA_Click);
            // 
            // buttonOpenInfo_ZAA
            // 
            this.buttonOpenInfo_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenInfo_ZAA.Location = new System.Drawing.Point(859, 19);
            this.buttonOpenInfo_ZAA.Name = "buttonOpenInfo_ZAA";
            this.buttonOpenInfo_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenInfo_ZAA.TabIndex = 0;
            this.buttonOpenInfo_ZAA.Text = "Инфо";
            this.toolTip_ZAA.SetToolTip(this.buttonOpenInfo_ZAA, "О программе");
            this.buttonOpenInfo_ZAA.UseVisualStyleBackColor = true;
            this.buttonOpenInfo_ZAA.Click += new System.EventHandler(this.buttonOpenInfo_ZAA_Click);
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
            this.groupBoxData_ZAA.Controls.Add(this.labelHeaders_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.comboBoxHeaders_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.labelSearchline_ZAA);
            this.groupBoxData_ZAA.Controls.Add(this.textBoxSearchline_ZAA);
            this.groupBoxData_ZAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData_ZAA.Name = "groupBoxData_ZAA";
            this.groupBoxData_ZAA.Size = new System.Drawing.Size(939, 364);
            this.groupBoxData_ZAA.TabIndex = 0;
            this.groupBoxData_ZAA.TabStop = false;
            this.groupBoxData_ZAA.Text = "Данные";
            // 
            // buttonDeleteRow_ZAA
            // 
            this.buttonDeleteRow_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRow_ZAA.Location = new System.Drawing.Point(844, 18);
            this.buttonDeleteRow_ZAA.Name = "buttonDeleteRow_ZAA";
            this.buttonDeleteRow_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRow_ZAA.TabIndex = 6;
            this.buttonDeleteRow_ZAA.Text = "Удалить";
            this.toolTip_ZAA.SetToolTip(this.buttonDeleteRow_ZAA, "Удаление выбранной строки");
            this.buttonDeleteRow_ZAA.UseVisualStyleBackColor = true;
            this.buttonDeleteRow_ZAA.Click += new System.EventHandler(this.buttonDeleteRow_ZAA_Click);
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
            this.dataGridViewData_ZAA.Size = new System.Drawing.Size(613, 309);
            this.dataGridViewData_ZAA.TabIndex = 5;
            // 
            // buttonReset_ZAA
            // 
            this.buttonReset_ZAA.Location = new System.Drawing.Point(378, 19);
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
            this.buttonSearchLine_ZAA.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchLine_ZAA.TabIndex = 1;
            this.buttonSearchLine_ZAA.Text = "Найти";
            this.toolTip_ZAA.SetToolTip(this.buttonSearchLine_ZAA, "Найти записи по выбранным параметрам");
            this.buttonSearchLine_ZAA.UseVisualStyleBackColor = true;
            this.buttonSearchLine_ZAA.Click += new System.EventHandler(this.buttonSearchLine_ZAA_Click);
            // 
            // labelHeaders_ZAA
            // 
            this.labelHeaders_ZAA.AutoSize = true;
            this.labelHeaders_ZAA.Location = new System.Drawing.Point(7, 22);
            this.labelHeaders_ZAA.Name = "labelHeaders_ZAA";
            this.labelHeaders_ZAA.Size = new System.Drawing.Size(35, 15);
            this.labelHeaders_ZAA.TabIndex = 3;
            this.labelHeaders_ZAA.Text = "Поле";
            // 
            // comboBoxHeaders_ZAA
            // 
            this.comboBoxHeaders_ZAA.FormattingEnabled = true;
            this.comboBoxHeaders_ZAA.Location = new System.Drawing.Point(46, 19);
            this.comboBoxHeaders_ZAA.Name = "comboBoxHeaders_ZAA";
            this.comboBoxHeaders_ZAA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHeaders_ZAA.TabIndex = 2;
            this.toolTip_ZAA.SetToolTip(this.comboBoxHeaders_ZAA, "Выбор поля для поиска");
            this.comboBoxHeaders_ZAA.SelectedValueChanged += new System.EventHandler(this.comboBoxHeaders_ZAA_SelectedValueChanged);
            // 
            // labelSearchline_ZAA
            // 
            this.labelSearchline_ZAA.AutoSize = true;
            this.labelSearchline_ZAA.Location = new System.Drawing.Point(169, 22);
            this.labelSearchline_ZAA.Name = "labelSearchline_ZAA";
            this.labelSearchline_ZAA.Size = new System.Drawing.Size(42, 15);
            this.labelSearchline_ZAA.TabIndex = 1;
            this.labelSearchline_ZAA.Text = "Поиск";
            // 
            // textBoxSearchline_ZAA
            // 
            this.textBoxSearchline_ZAA.Location = new System.Drawing.Point(217, 20);
            this.textBoxSearchline_ZAA.Name = "textBoxSearchline_ZAA";
            this.textBoxSearchline_ZAA.Size = new System.Drawing.Size(93, 23);
            this.textBoxSearchline_ZAA.TabIndex = 0;
            this.toolTip_ZAA.SetToolTip(this.textBoxSearchline_ZAA, "Текст, который необходимо найти");
            // 
            // groupBoxStatistic_ZAA
            // 
            this.groupBoxStatistic_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistic_ZAA.Controls.Add(this.buttonOpenFormStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.labelSearchStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.textBoxSearchStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.textBoxStatisticResult_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.buttonStatisticSearch_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.labelStatisticAction_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.labelHeadersStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.comboBoxStatisticAction_ZAA);
            this.groupBoxStatistic_ZAA.Controls.Add(this.comboBoxHeadersStatistic_ZAA);
            this.groupBoxStatistic_ZAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStatistic_ZAA.Name = "groupBoxStatistic_ZAA";
            this.groupBoxStatistic_ZAA.Size = new System.Drawing.Size(322, 364);
            this.groupBoxStatistic_ZAA.TabIndex = 1;
            this.groupBoxStatistic_ZAA.TabStop = false;
            this.groupBoxStatistic_ZAA.Text = "Статистика";
            // 
            // buttonOpenFormStatistic_ZAA
            // 
            this.buttonOpenFormStatistic_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFormStatistic_ZAA.Location = new System.Drawing.Point(88, 313);
            this.buttonOpenFormStatistic_ZAA.Name = "buttonOpenFormStatistic_ZAA";
            this.buttonOpenFormStatistic_ZAA.Size = new System.Drawing.Size(159, 45);
            this.buttonOpenFormStatistic_ZAA.TabIndex = 10;
            this.buttonOpenFormStatistic_ZAA.Text = "Открыть статистику\r\nс диаграммами";
            this.buttonOpenFormStatistic_ZAA.UseVisualStyleBackColor = true;
            this.buttonOpenFormStatistic_ZAA.Click += new System.EventHandler(this.buttonOpenFormStatistic_ZAA_Click);
            // 
            // labelSearchStatistic_ZAA
            // 
            this.labelSearchStatistic_ZAA.AutoSize = true;
            this.labelSearchStatistic_ZAA.Location = new System.Drawing.Point(6, 58);
            this.labelSearchStatistic_ZAA.Name = "labelSearchStatistic_ZAA";
            this.labelSearchStatistic_ZAA.Size = new System.Drawing.Size(63, 15);
            this.labelSearchStatistic_ZAA.TabIndex = 9;
            this.labelSearchStatistic_ZAA.Text = "Значение";
            this.toolTip_ZAA.SetToolTip(this.labelSearchStatistic_ZAA, "Используется для статистики \"Количество упоминаний\"");
            // 
            // textBoxSearchStatistic_ZAA
            // 
            this.textBoxSearchStatistic_ZAA.Location = new System.Drawing.Point(88, 55);
            this.textBoxSearchStatistic_ZAA.Name = "textBoxSearchStatistic_ZAA";
            this.textBoxSearchStatistic_ZAA.Size = new System.Drawing.Size(121, 23);
            this.textBoxSearchStatistic_ZAA.TabIndex = 7;
            this.toolTip_ZAA.SetToolTip(this.textBoxSearchStatistic_ZAA, "Используется для статистики \"Количество упоминаний\"");
            // 
            // textBoxStatisticResult_ZAA
            // 
            this.textBoxStatisticResult_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatisticResult_ZAA.Location = new System.Drawing.Point(7, 183);
            this.textBoxStatisticResult_ZAA.Multiline = true;
            this.textBoxStatisticResult_ZAA.Name = "textBoxStatisticResult_ZAA";
            this.textBoxStatisticResult_ZAA.ReadOnly = true;
            this.textBoxStatisticResult_ZAA.Size = new System.Drawing.Size(305, 124);
            this.textBoxStatisticResult_ZAA.TabIndex = 8;
            // 
            // buttonStatisticSearch_ZAA
            // 
            this.buttonStatisticSearch_ZAA.Enabled = false;
            this.buttonStatisticSearch_ZAA.Location = new System.Drawing.Point(114, 154);
            this.buttonStatisticSearch_ZAA.Name = "buttonStatisticSearch_ZAA";
            this.buttonStatisticSearch_ZAA.Size = new System.Drawing.Size(75, 23);
            this.buttonStatisticSearch_ZAA.TabIndex = 6;
            this.buttonStatisticSearch_ZAA.Text = "Найти";
            this.buttonStatisticSearch_ZAA.UseVisualStyleBackColor = true;
            this.buttonStatisticSearch_ZAA.Click += new System.EventHandler(this.buttonStatisticSearch_ZAA_Click);
            // 
            // labelStatisticAction_ZAA
            // 
            this.labelStatisticAction_ZAA.AutoSize = true;
            this.labelStatisticAction_ZAA.Location = new System.Drawing.Point(6, 124);
            this.labelStatisticAction_ZAA.Name = "labelStatisticAction_ZAA";
            this.labelStatisticAction_ZAA.Size = new System.Drawing.Size(77, 30);
            this.labelStatisticAction_ZAA.TabIndex = 7;
            this.labelStatisticAction_ZAA.Text = "Значение\r\nстатистики";
            this.toolTip_ZAA.SetToolTip(this.labelStatisticAction_ZAA, "Выбор статистики");
            // 
            // labelHeadersStatistic_ZAA
            // 
            this.labelHeadersStatistic_ZAA.AutoSize = true;
            this.labelHeadersStatistic_ZAA.Location = new System.Drawing.Point(6, 28);
            this.labelHeadersStatistic_ZAA.Name = "labelHeadersStatistic_ZAA";
            this.labelHeadersStatistic_ZAA.Size = new System.Drawing.Size(35, 15);
            this.labelHeadersStatistic_ZAA.TabIndex = 6;
            this.labelHeadersStatistic_ZAA.Text = "Поле";
            this.toolTip_ZAA.SetToolTip(this.labelHeadersStatistic_ZAA, "Выбор поля, по которому будет поиск статистики");
            // 
            // comboBoxStatisticAction_ZAA
            // 
            this.comboBoxStatisticAction_ZAA.FormattingEnabled = true;
            this.comboBoxStatisticAction_ZAA.Location = new System.Drawing.Point(88, 127);
            this.comboBoxStatisticAction_ZAA.Name = "comboBoxStatisticAction_ZAA";
            this.comboBoxStatisticAction_ZAA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStatisticAction_ZAA.TabIndex = 4;
            this.toolTip_ZAA.SetToolTip(this.comboBoxStatisticAction_ZAA, "Выбор статистики");
            this.comboBoxStatisticAction_ZAA.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeadersStatistic_ZAA_SelectedIndexChanged);
            // 
            // comboBoxHeadersStatistic_ZAA
            // 
            this.comboBoxHeadersStatistic_ZAA.FormattingEnabled = true;
            this.comboBoxHeadersStatistic_ZAA.Location = new System.Drawing.Point(88, 25);
            this.comboBoxHeadersStatistic_ZAA.Name = "comboBoxHeadersStatistic_ZAA";
            this.comboBoxHeadersStatistic_ZAA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHeadersStatistic_ZAA.TabIndex = 3;
            this.toolTip_ZAA.SetToolTip(this.comboBoxHeadersStatistic_ZAA, "Выбор поля, по которому будет поиск статистики");
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
            // panelMenu_ZAA
            // 
            this.panelMenu_ZAA.Controls.Add(this.groupBoxMenu_ZAA);
            this.panelMenu_ZAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenu_ZAA.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_ZAA.Name = "panelMenu_ZAA";
            this.panelMenu_ZAA.Size = new System.Drawing.Size(945, 86);
            this.panelMenu_ZAA.TabIndex = 2;
            // 
            // panelData_ZAA
            // 
            this.panelData_ZAA.Controls.Add(this.groupBoxData_ZAA);
            this.panelData_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelData_ZAA.Location = new System.Drawing.Point(0, 86);
            this.panelData_ZAA.Name = "panelData_ZAA";
            this.panelData_ZAA.Size = new System.Drawing.Size(945, 364);
            this.panelData_ZAA.TabIndex = 3;
            // 
            // panelStatistic_ZAA
            // 
            this.panelStatistic_ZAA.Controls.Add(this.groupBoxStatistic_ZAA);
            this.panelStatistic_ZAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatistic_ZAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelStatistic_ZAA.Location = new System.Drawing.Point(623, 86);
            this.panelStatistic_ZAA.Name = "panelStatistic_ZAA";
            this.panelStatistic_ZAA.Size = new System.Drawing.Size(322, 364);
            this.panelStatistic_ZAA.TabIndex = 4;
            // 
            // FormMain_ZAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.panelStatistic_ZAA);
            this.Controls.Add(this.panelData_ZAA);
            this.Controls.Add(this.panelMenu_ZAA);
            this.MinimumSize = new System.Drawing.Size(961, 489);
            this.Name = "FormMain_ZAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление статистик киннолент";
            this.groupBoxMenu_ZAA.ResumeLayout(false);
            this.groupBoxData_ZAA.ResumeLayout(false);
            this.groupBoxData_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_ZAA)).EndInit();
            this.groupBoxStatistic_ZAA.ResumeLayout(false);
            this.groupBoxStatistic_ZAA.PerformLayout();
            this.panelMenu_ZAA.ResumeLayout(false);
            this.panelData_ZAA.ResumeLayout(false);
            this.panelStatistic_ZAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu_ZAA;
        private System.Windows.Forms.GroupBox groupBoxData_ZAA;
        private System.Windows.Forms.Button buttonOpenInfo_ZAA;
        private System.Windows.Forms.Label labelHeaders_ZAA;
        private System.Windows.Forms.ComboBox comboBoxHeaders_ZAA;
        private System.Windows.Forms.Label labelSearchline_ZAA;
        private System.Windows.Forms.TextBox textBoxSearchline_ZAA;
        private System.Windows.Forms.Button buttonReset_ZAA;
        private System.Windows.Forms.Button buttonSearchLine_ZAA;
        private System.Windows.Forms.Button buttonSave_ZAA;
        private System.Windows.Forms.Button buttonOpen_ZAA;
        private System.Windows.Forms.GroupBox groupBoxStatistic_ZAA;
        private System.Windows.Forms.Button buttonStatisticSearch_ZAA;
        private System.Windows.Forms.Label labelStatisticAction_ZAA;
        private System.Windows.Forms.Label labelHeadersStatistic_ZAA;
        private System.Windows.Forms.ComboBox comboBoxStatisticAction_ZAA;
        private System.Windows.Forms.ComboBox comboBoxHeadersStatistic_ZAA;
        private System.Windows.Forms.ToolTip toolTip_ZAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ZAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ZAA;
        private System.Windows.Forms.Button buttonDeleteRow_ZAA;
        private System.Windows.Forms.TextBox textBoxStatisticResult_ZAA;
        private System.Windows.Forms.Label labelSearchStatistic_ZAA;
        private System.Windows.Forms.TextBox textBoxSearchStatistic_ZAA;
        private System.Windows.Forms.Button buttonOpenFormStatistic_ZAA;
        public System.Windows.Forms.DataGridView dataGridViewData_ZAA;
        private System.Windows.Forms.Panel panelMenu_ZAA;
        private System.Windows.Forms.Panel panelData_ZAA;
        private System.Windows.Forms.Panel panelStatistic_ZAA;
        private System.Windows.Forms.Button buttonInstructions_ZAA;
    }
}

