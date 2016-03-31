using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Encuestador.Utiles
{
    public static class Comunes
    {
        public static void GetLargestTextExtent(ComboBox cbo, ref int largestWidth)
        {
            int maxLen = -1;
            if (cbo.Items.Count >= 1)
            {
                using (Graphics g = cbo.CreateGraphics())
                {
                    int vertScrollBarWidth = 0;
                    if (cbo.Items.Count > cbo.MaxDropDownItems)
                    {
                        vertScrollBarWidth = SystemInformation.VerticalScrollBarWidth;
                    }
                    for (int nLoopCnt = 0; nLoopCnt < cbo.Items.Count; nLoopCnt++)
                    {
                        int newWidth = (int)g.MeasureString(cbo.Items[nLoopCnt].ToString(), cbo.Font).Width + vertScrollBarWidth;
                        if (newWidth > maxLen)
                        {
                            maxLen = newWidth;
                        }
                    }
                }
            }
            largestWidth = maxLen;
        }

        public static int GetCountControls(Control.ControlCollection controls)
        {
            int tbCount = 0;
            foreach (Control wc in controls)
            {
                if (wc is Panel)
                    tbCount++;                
            }
            return tbCount;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
