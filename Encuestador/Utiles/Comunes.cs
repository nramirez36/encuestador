using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
