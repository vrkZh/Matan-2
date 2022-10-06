using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матан_2
{
    public partial class FormOtvet : Form
    {
        public FormOtvet()
        {
            InitializeComponent();
        }
        public double sv1;
        public double sv2;
        public double sv3;
        public double str11, str12, str13,
                      str21, str22, str23,
                      str31, str32, str33;

        private void FormOtvet_Load(object sender, EventArgs e)
        {
            dgv.Rows.Add(1,0, 0, 0);
            double x1, x2, x3;
            x1 = sv1;
            x2 = sv2;
            x3 = sv3;
            for (int i = 1; i <= i + 1; i++)
            {
                string oldX1 = x1.ToString("0.00"), oldX2 = x2.ToString("0.00"), oldX3 = x3.ToString("0.00");
                dgv.Rows.Add(i, x1.ToString("0.0000"), x2.ToString("0.0000"), x3.ToString("0.0000"));
                x1 = str11 * (x2) + str12 * (x3) + str13;
                x2 = str21 * (x1) + str22 * (x3) + str23;
                x3 = str31 * (x1) + str32 * (x2) + str33;
                if (x1.ToString("0.00") == oldX1 && x2.ToString("0.00") == oldX2 && x3.ToString("0.00") == oldX3)
                {
                    dgv.Rows[dgv.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                    dgv.Rows[dgv.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Green;
                    return;
                }
            }
        }
    }
}
