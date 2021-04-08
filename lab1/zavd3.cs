using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class zavd3 : Form
    {
        public zavd3()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox4.Text);
            if (textBox1.Text == "К" || textBox1.Text == "к")
            {
                mybutton(x, y);
            }
            else if (textBox1.Text == "М" || textBox1.Text == "м")
            {
                mylabel(x, y);
            }
            else if (textBox1.Text == "П" || textBox1.Text == "п")
            {
                mytext(x, y);
            }
        }

        public void mybutton(int x, int y)
        {
            y = y + 65;
            Button b1 = new Button();
            b1.Location = new System.Drawing.Point(x, y);
            b1.Size = new Size(40, 20);
            b1.TabIndex = 0;
            b1.Text = "test";
            Controls.Add(b1);
        }
        public void mylabel(int x, int y)
        {
            Label b2 = new Label();
            b2.Location = new System.Drawing.Point(x, y);
            b2.Size = new Size(40, 20);
            b2.TabIndex = 0;
            b2.Text = "test";
            Controls.Add(b2);
        }
        public void mytext(int x, int y)
        {

            TextBox s = new TextBox();
            s.Size = new Size(250, 25);
            s.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
            s.Location = new Point(20, 50);

            this.Controls.Add(s);
        }
    }
}
