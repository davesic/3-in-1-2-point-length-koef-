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

namespace lab1
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(zavd1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void zavd1(Object obj)
        {
            Application.Run(new zavd1());
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(zavd2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void zavd2(Object obj)
        {
            Application.Run(new zavd2());
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(zavd3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void zavd3(Object obj)
        {
            Application.Run(new zavd3());
        }
    }
}
