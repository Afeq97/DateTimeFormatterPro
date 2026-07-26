using System.Drawing;
using System.Windows.Forms;

namespace DateTimeFormatterPro.Helpers
{
    public static class DataGridViewHelper
    {
        public static void Style(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = false;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(52, 73, 94);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgv.ColumnHeadersHeight = 35;

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgv.BorderStyle = BorderStyle.None;
        }
    }
}