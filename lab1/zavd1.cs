using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class zavd1 : Form
    {
        Thread th, th1;
        public zavd1()
        {
            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void open(Object obj)
        {
            Application.Run(new Show());
        }

        public void Input(Object obj)
        {
            Application.Run(new Input());
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th1 = new Thread(Input);
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();
        }
    }
}
