using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Inventory_System
{
    internal class UIDesign
    {
        public static void DGVTheme(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(34, 34, 34);

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(34, 34, 34);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgv.ColumnHeadersDefaultCellStyle.ForeColor;

            dgv.EnableHeadersVisualStyles = false;
        }
    }
}
