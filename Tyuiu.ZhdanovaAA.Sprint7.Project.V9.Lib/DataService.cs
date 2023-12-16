using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Tyuiu.ZhdanovaAA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public List<DataGridViewRow> GetSearchRows(List<DataGridViewRow> data, string header, string search)
        {
            List<DataGridViewRow> result = new List<DataGridViewRow>();
            foreach (DataGridViewRow item in data)
            {
                object cell = item.Cells[header].Value;
                if (cell != null)
                {
                    if (cell.ToString().Contains(search))
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        public double GetSummColumn(List<object> data)
        {
            double summ = 0;
            double temp;
            foreach (object item in data)
            {
                if (item == null)
                {
                    continue;
                }
                if (Double.TryParse(item.ToString(), out temp))
                {
                    summ += temp;
                }
            }
            return summ;
        }
        public int GetCountTargetColumn(List<object> data, object target)
        {
            return data.Where(x => x.ToString() == target.ToString()).Count();  
        }

        public double GetAverageColumn(List<object> data)
        {
            double summ = 0;
            double temp;
            int count = 0;
            foreach (object item in data)
            {
                if (item == null)
                {
                    continue;
                }
                if (Double.TryParse(item.ToString(), out temp))
                {
                    summ += temp;
                    count++;
                }
            }
            if (count > 0)
            {
                return Math.Round(summ /= count, 3);
            }
            else
            {
                return 0;
            }
        }

        public double GetMinValueColumn(List<object> data)
        {
            bool flag = true;
            double min = 0;
            double temp;

            foreach (object item in data)
            {
                if (item == null)
                {
                    continue;
                }
                if (Double.TryParse(item.ToString(), out temp))
                {
                    if (flag)
                    {
                        min = temp;
                        flag = false;
                    }
                    else if (temp<min)
                    {
                        min = temp;
                    }
                }
            }
            return min;
        }
        public double GetMaxValueColumn(List<object> data)
        {
            bool flag = true;
            double max = 0;
            double temp;

            foreach (object item in data)
            {
                if (item == null)
                {
                    continue;
                }
                if (Double.TryParse(item.ToString(), out temp))
                {
                    if (flag)
                    {
                        max = temp;
                        flag = false;
                    }
                    else if (temp > max)
                    {
                        max = temp;
                    }
                }
            }
            return max;
        }
    }
}
