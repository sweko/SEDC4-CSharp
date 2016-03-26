using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            richTextBox1.Text = await wc.DownloadStringTaskAsync("http://tclhost.com/tv1madj.gif");
            MessageBox.Show("Done");

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            richTextBox2.Text = await wc.DownloadStringTaskAsync("http://tclhost.com/tv1madj.gif");
            MessageBox.Show("Done 2");
        }
    }
}
