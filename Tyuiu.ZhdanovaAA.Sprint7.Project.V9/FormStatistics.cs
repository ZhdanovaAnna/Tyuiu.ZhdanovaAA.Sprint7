using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.ZhdanovaAA.Sprint7.Project.V9.Lib;

namespace WindowsFormsApp1
{
    public partial class FormStatistics_ZAA : Form
    {
        FormMain_ZAA parent;
        DataService ds = new DataService();

        public FormStatistics_ZAA(FormMain_ZAA p)
        {
            InitializeComponent();
            parent = p;
            comboBoxHeadersRange_ZAA.Items.AddRange(parent.dataGridViewheaders.ToArray());
            comboBoxHeadersStatistic_ZAA.Items.AddRange(parent.dataGridViewheaders.ToArray());
            comboBoxStatisticAction_ZAA.Items.AddRange(new string[] { "Сумма", "Среднее значение", "Количество упоминаний", "Количество записей", "Минимальное значение", "Максимальное значение" });
            chartStatistic_ZAA.Series[0].Points.Clear();
            chartStatistic_ZAA.Series[0].IsValueShownAsLabel = true;

        }
        private void statisticParameterChange(object sender, EventArgs e)
        {
            if (textBoxBeginRange_ZAA.Text != "" && textBoxBeginRange_ZAA.Text != null
                && textBoxEndRange_ZAA.Text != "" && textBoxEndRange_ZAA.Text != null
                && comboBoxHeadersRange_ZAA.SelectedItem != null
                && comboBoxHeadersStatistic_ZAA.SelectedItem != null
                && comboBoxStatisticAction_ZAA.SelectedItem != null)
            {
                buttonSearchStatistic_ZAA.Enabled = true;
            }
            else
            {
                buttonSearchStatistic_ZAA.Enabled = false;
            }
        }

        private void buttonSearchStatistic_ZAA_Click(object sender, EventArgs e)
        {
            string header = comboBoxHeadersStatistic_ZAA.SelectedItem.ToString();
            string headerRange = comboBoxHeadersRange_ZAA.SelectedItem.ToString();

            #region Получение начального и конечного значения
            double temp;
            double beginRange, endRange;
            if (Double.TryParse(textBoxBeginRange_ZAA.Text, out temp))
            {
                beginRange = temp;
            }
            else
            {
                MessageBox.Show($"Невозможно конвертировать значение \"{textBoxBeginRange_ZAA.Text}\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(textBoxEndRange_ZAA.Text, out temp))
            {
                endRange = temp;
            }
            else
            {
                MessageBox.Show($"Невозможно конвертировать значение \"{textBoxEndRange_ZAA.Text}\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            List<object[]> list = new List<object[]>();
            for (int x = 0; x < parent.dataGridViewData_ZAA.Rows.Count; x++)
            {
                if (parent.dataGridViewData_ZAA.Rows[x].Cells[header].Value == null || parent.dataGridViewData_ZAA.Rows[x].Cells[headerRange].Value == null)
                {
                    continue;
                }
                else 
                {
                    string tempValue = parent.dataGridViewData_ZAA.Rows[x].Cells[headerRange].Value.ToString();
                    if (Double.TryParse(tempValue, out temp))
                    {
                        if (temp <= endRange && temp >= beginRange)
                        {
                            list.Add(new object[] { temp, parent.dataGridViewData_ZAA.Rows[x].Cells[header].Value });
                        }
                    }
                }
            }
            list.OrderBy(x => x[0]);
            var groupedList = list.GroupBy(x => x[0]);

            string action = comboBoxStatisticAction_ZAA.SelectedItem.ToString();

            chartStatistic_ZAA.Titles.Clear();
            chartStatistic_ZAA.Series[0].Points.Clear();
            chartStatistic_ZAA.Titles.Add($"За период {beginRange}-{endRange}, поле \"{header}\", поиск: \"{action}\"");
            chartStatistic_ZAA.ChartAreas[0].AxisX.Title = headerRange;
            chartStatistic_ZAA.ChartAreas[0].AxisY.Title = $"{action} по {header}";


            double result = 0;

            foreach (var o in groupedList)
            {
                switch (action)
                {
                    case "Сумма":
                        result = ds.GetSummColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Среднее значение":
                        result = ds.GetAverageColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Количество упоминаний":
                        if (textBoxSearchStatistic_ZAA.Text == "" || textBoxSearchStatistic_ZAA.Text == null)
                            return;
                        result = ds.GetCountTargetColumn(o.Select(x => x[1]).ToList(), textBoxSearchStatistic_ZAA.Text);
                        break;
                    case "Количество записей":
                        result = ds.GetCountColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Минимальное значение":
                        result = ds.GetMinValueColumn(o.Select(x => x[1]).ToList());
                        break;
                    case "Максимальное значение":
                        result = ds.GetMaxValueColumn(o.Select(x => x[1]).ToList());
                        break;
                    default: break;
                }
                chartStatistic_ZAA.Series[0].Points.AddXY(Convert.ToDouble(o.Key.ToString()), result);
            }
            
        }
    }
}
