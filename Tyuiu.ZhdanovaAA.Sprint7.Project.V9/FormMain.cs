using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tyuiu.ZhdanovaAA.Sprint7.Project.V9.Lib;

namespace WindowsFormsApp1
{
    public partial class FormMain_ZAA : Form
    {
        public List<DataGridViewRow> dataGridViewRowsOriginals = new List<DataGridViewRow>();
        public List<DataGridViewRow> dataGridViewRowsSearched = new List<DataGridViewRow>();
        public List<string> dataGridViewheaders = new List<string>();
        DataService ds = new DataService();

        public FormMain_ZAA()
        {
            InitializeComponent();
            ClearDatagrid();
            comboBoxStatisticAction_ZAA.Items.AddRange(new string[] { "Сумма", "Среднее значение", "Количество упоминаний", "Минимальное значение", "Максимальное значение" });
        }

        private void ClearDatagrid()
        {
            dataGridViewData_ZAA.Rows.Clear();
            dataGridViewData_ZAA.Columns.Clear();
            comboBoxHeaders_ZAA.Items.Clear();
            comboBoxHeadersStatistic_ZAA.Items.Clear();
            dataGridViewheaders.Clear();
            comboBoxHeaders_ZAA.SelectedValue = comboBoxHeadersStatistic_ZAA.SelectedValue = null;
            buttonStatisticSearch_ZAA.Enabled = buttonSearchLine_ZAA.Enabled = false;
        }

        //Чтение из файла
        private void buttonOpen_ZAA_Click(object sender, EventArgs e)
        {
            if(openFileDialog_ZAA.ShowDialog() == DialogResult.OK)
            {
                ClearDatagrid();
                try
                {
                    using (StreamReader f = new StreamReader(openFileDialog_ZAA.FileName))
                {
                    string s;
                    
                        if (MessageBox.Show("В Вашем файле присутствуют заголовки?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (string column in f.ReadLine().Split(';'))
                            {
                                dataGridViewData_ZAA.Columns.Add(column, column);
                                comboBoxHeaders_ZAA.Items.Add(column);
                                comboBoxHeadersStatistic_ZAA.Items.Add(column);
                                dataGridViewheaders.Add(column);
                            }
                        }
                        else
                        {
                            dataGridViewData_ZAA.ColumnCount = f.ReadLine().Split(';').Length;
                            f.DiscardBufferedData();
                            f.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
                        }
                        int index = 0;
                        while ((s = f.ReadLine()) != null && s != "")
                        {
                            dataGridViewData_ZAA.Rows.Add(s.Split(';'));

                            dataGridViewRowsOriginals.Add((DataGridViewRow)dataGridViewData_ZAA.Rows[index].Clone());
                            foreach (DataGridViewCell cell in dataGridViewData_ZAA.Rows[index].Cells)
                            {
                                dataGridViewRowsOriginals[dataGridViewRowsOriginals.Count - 1].Cells[cell.ColumnIndex].Value = cell.Value;
                            }
                            index++;
                        }
                        //dataGridViewRowsOriginals = dataGridViewData_ZAA.Rows.OfType<DataGridViewRow>().ToList();
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка чтения данных из файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearDatagrid();
                    dataGridViewRowsOriginals.Clear();
                }
            }
        }

        //Сохранение в файл
        private void buttonSave_ZAA_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_ZAA.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog_ZAA.FileName;
                string data = "";
                if (MessageBox.Show("Сохранять заголовки в файл?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    data += String.Join(";", dataGridViewData_ZAA.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText).ToArray());
                    data += Environment.NewLine;
                }

                foreach (DataGridViewRow row in dataGridViewData_ZAA.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    data += string.Join(";", cells.Select(cell => cell.Value).ToArray());
                    data += Environment.NewLine;
                }
                File.WriteAllText(filename, data, Encoding.Default);
                MessageBox.Show("Файл сохранен", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBoxHeaders_ZAA_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxHeaders_ZAA.SelectedItem != null)
            {
                buttonSearchLine_ZAA.Enabled = true;
            }
            else
            {
                buttonSearchLine_ZAA.Enabled = false;
            }
        }

        private void buttonSearchLine_ZAA_Click(object sender, EventArgs e)
        {
            string searchline = textBoxSearchline_ZAA.Text;
            if (dataGridViewRowsSearched.Count()==0)
            {
                dataGridViewRowsOriginals.Clear();
                foreach (var row in dataGridViewData_ZAA.Rows.OfType<DataGridViewRow>().ToList())
                {
                    dataGridViewRowsOriginals.Add(row);
                }
            }
            
            dataGridViewRowsSearched.Clear();
            dataGridViewRowsSearched = ds.GetSearchRows(dataGridViewData_ZAA.Rows.OfType<DataGridViewRow>().ToList(), 
                                                        comboBoxHeaders_ZAA.SelectedItem.ToString(), searchline);
            dataGridViewData_ZAA.Rows.Clear();
            foreach(var row in dataGridViewRowsSearched)
            {
                dataGridViewData_ZAA.Rows.Add(row);
            }
        }

        private void buttonReset_ZAA_Click(object sender, EventArgs e)
        {
            comboBoxHeaders_ZAA.SelectedValue = null;
            dataGridViewData_ZAA.Rows.Clear();
            dataGridViewRowsSearched.Clear();
            foreach (DataGridViewRow row in dataGridViewRowsOriginals)
            {
                dataGridViewData_ZAA.Rows.Add(row);
            }
        }

        private void buttonDeleteRow_ZAA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewData_ZAA.SelectedRows)
            {
                dataGridViewData_ZAA.Rows.RemoveAt(row.Index);
                dataGridViewRowsOriginals.Remove(row);
            }
        }

        private void comboBoxHeadersStatistic_ZAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHeadersStatistic_ZAA.SelectedItem != null && comboBoxStatisticAction_ZAA.SelectedItem != null)
            {
                buttonStatisticSearch_ZAA.Enabled = true;
            }
            else
            {
                buttonStatisticSearch_ZAA.Enabled = false;
            }
        }

        private void buttonStatisticSearch_ZAA_Click(object sender, EventArgs e)
        {
            string result = "";
            string header = comboBoxHeadersStatistic_ZAA.SelectedItem.ToString();
            List<object> list = new List<object>();
            for (int x = 0; x < dataGridViewData_ZAA.Rows.Count; x++)
            {
                if (dataGridViewData_ZAA.Rows[x].Cells[header].Value == null)
                {
                    continue;
                }
                list.Add(dataGridViewData_ZAA.Rows[x].Cells[header].Value);
            }
            string action = comboBoxStatisticAction_ZAA.SelectedItem.ToString();
            switch (action)
            {
                case "Сумма":
                    result = ds.GetSummColumn(list).ToString();
                    break;
                case "Среднее значение":
                    result = ds.GetAverageColumn(list).ToString();
                    break;
                case "Количество упоминаний":
                    if (textBoxSearchStatistic_ZAA.Text == "" || textBoxSearchStatistic_ZAA.Text == null)
                        return;
                    result = ds.GetCountTargetColumn(list, textBoxSearchStatistic_ZAA.Text).ToString();
                    break;
                case "Минимальное значение":
                    result = ds.GetMinValueColumn(list).ToString();
                    break;
                case "Максимальное значение":
                    result = ds.GetMaxValueColumn(list).ToString();
                    break;
                default: return;
            }
            textBoxStatisticResult_ZAA.Text = action + " по полю " + "\"" + header + "\" ";
            if (action == "Количество упоминаний")
            {
                textBoxStatisticResult_ZAA.Text += "по значению " + "\"" + textBoxSearchStatistic_ZAA.Text + "\" ";
            }
            textBoxStatisticResult_ZAA.Text += ": " + result;
        }

        private void buttonOpenFormStatistic_ZAA_Click(object sender, EventArgs e)
        {
            FormStatistics_ZAA formStatistics = new FormStatistics_ZAA(this);
            formStatistics.Show();
        }

        private void buttonOpenInfo_ZAA_Click(object sender, EventArgs e)
        {
            FormInfo_ZAA formInfo = new FormInfo_ZAA();
            formInfo.ShowDialog();
        }

        private void buttonInstructions_ZAA_Click(object sender, EventArgs e)
        {
            FormInstruction_ZAA formHelp = new FormInstruction_ZAA();
            formHelp.Show();
        }
    }
}
