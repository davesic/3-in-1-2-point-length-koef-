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
    public partial class Show : Form
    {
        Thread th;
        string path = @"C:\Users\webda\source\repos\lab1\Show.txt";

        public Show()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    result.Text += $"{line}\n";
                }
            }

        }


        public string result_str
        {
            get { return result.Text; }
            set { result.Text = value; }
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            th = new Thread(home);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        public void home(Object obj)
        {
            Application.Run(new Form1());
        }
    }
}
