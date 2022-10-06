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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        List<double> alfa1 = new List<double>();
        List<double> alfa2 = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {           
            alfa1.Add(Math.Abs(Convert.ToDouble(str1X2.Text))+ Math.Abs(Convert.ToDouble(str1X3.Text)));
            alfa1.Add(Math.Abs(Convert.ToDouble(str2X1.Text)) + Math.Abs(Convert.ToDouble(str2X3.Text)));
            alfa1.Add(Math.Abs(Convert.ToDouble(str3X1.Text)) + Math.Abs(Convert.ToDouble(str3X2.Text)));
            double maxA1 = alfa1.Max();

            alfa2.Add(Math.Abs(Convert.ToDouble(str2X1.Text)) + Math.Abs(Convert.ToDouble(str3X1.Text)));
            alfa2.Add(Math.Abs(Convert.ToDouble(str1X2.Text)) + Math.Abs(Convert.ToDouble(str3X2.Text)));
            alfa2.Add(Math.Abs(Convert.ToDouble(str1X3.Text)) + Math.Abs(Convert.ToDouble(str2X3.Text)));
            double maxA2 = alfa2.Max();

            double maxA3 = Math.Sqrt(Math.Pow(Math.Abs(Convert.ToDouble(str1X2.Text)), 2)+ Math.Pow(Math.Abs(Convert.ToDouble(str1X3.Text)), 2)
                          +Math.Pow(Math.Abs(Convert.ToDouble(str2X1.Text)), 2) + Math.Pow(Math.Abs(Convert.ToDouble(str2X3.Text)), 2) 
                          +Math.Pow(Math.Abs(Convert.ToDouble(str3X1.Text)), 2) + Math.Pow(Math.Abs(Convert.ToDouble(str3X2.Text)), 2));
          
            FormOtvet form = new FormOtvet();
            form.a1.Text = maxA1.ToString();
            form.a2.Text = maxA2.ToString();
            form.a3.Text = maxA3.ToString("0.0000");
            form.sv1 = Convert.ToDouble(sv1.Text);
            form.sv2 = Convert.ToDouble(sv3.Text);
            form.sv3 = Convert.ToDouble(sv3.Text);
            form.str11 = Convert.ToDouble(str1X2.Text);
            form.str12 = Convert.ToDouble(str1X3.Text);
            form.str13 = Convert.ToDouble(sv3.Text);
            form.str21 = Convert.ToDouble(str2X1.Text);
            form.str22 = Convert.ToDouble(str2X3.Text);
            form.str23 = Convert.ToDouble(sv2.Text);
            form.str31 = Convert.ToDouble(str3X1.Text);
            form.str32 = Convert.ToDouble(str3X2.Text);
            form.str33 = Convert.ToDouble(sv3.Text);
            form.ShowDialog();
        }
    }
}
