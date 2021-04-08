using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace lab1
{
    public partial class Input : Form
    {
        Thread th;
        string writePath = @"C:\Users\webda\source\repos\lab1\Show.txt";
        string str_add = "";

        public Input()
        {
            InitializeComponent();
        }

        private void OK_MouseClick(object sender, MouseEventArgs e)
        {
            Show sh = new Show();
            label3.Text = "";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") label3.Text = "Одно из полей пустое , проверьте заново";
            else
            {
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox3.Text);
                double y1 = Convert.ToDouble(textBox2.Text);
                double y2 = Convert.ToDouble(textBox4.Text);

                double length_result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double koef_result = (y1 - y2) / (x1 - x2);
                if (length.Checked == true && koef.Checked == false)
                {

                    label3.Text = length_result.ToString();
                    str_add += $"{DateTime.Now} | Lenghth: {this.label3.Text}\n";
                    write(str_add);
                    /* str_add = $"{DateTime.Now} | Lenghth: {this.label3.Text}";
                     *//*sh.result.Text */
                }
                else if (length.Checked == false && koef.Checked == true)
                {

                    label3.Text = koef_result.ToString();
                    str_add += $"{DateTime.Now} | Lenghth: {koef_result.ToString()}\n";
                    write(str_add);
                }
                else if (length.Checked == true && koef.Checked == true)
                {

                    label3.Text = $"Length: {length_result.ToString()} \nKoef: {koef_result.ToString()}";
                    str_add += $"{DateTime.Now} | Lenghth: {length_result.ToString()} | Koef: {koef_result}\n";
                    write(str_add);
                }
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Show sh = new Show();
            sh.ShowDialog();
        }
        private void write(string str_add)
        {
            using (System.IO.StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(str_add);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (e.KeyChar == 46 || e.KeyChar == 44 || e.KeyChar == 8) e.Handled = false;
            else if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (e.KeyChar == 46 || e.KeyChar == 44 || e.KeyChar == 8) e.Handled = false;
            else if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (e.KeyChar == 46 || e.KeyChar == 44 || e.KeyChar == 8) e.Handled = false;
            else if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar == 46 || e.KeyChar == 44 || e.KeyChar == 8) e.Handled = false;
            else if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
