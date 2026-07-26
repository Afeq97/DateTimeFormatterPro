using System.Drawing;
using System.Windows.Forms;

namespace DateTimeFormatterPro.Helpers
{
    public static class UIStyleHelper
    {
        public static void StyleButtons(params Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                btn.ForeColor = Color.White;

                btn.Cursor = Cursors.Hand;

                btn.Height = 32;

                btn.Width = 90;

                btn.TextAlign = ContentAlignment.MiddleCenter;

                btn.Padding = new Padding(0, -3, 0, 0);
            }

            buttons[0].BackColor = Color.FromArgb(52, 152, 219);
            buttons[1].BackColor = Color.FromArgb(52, 73, 94);
            buttons[2].BackColor = Color.FromArgb(149, 165, 166);
            buttons[3].BackColor = Color.FromArgb(46, 204, 113);
            buttons[4].BackColor = Color.FromArgb(231, 76, 60);
        }
    }
}