using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DownloadInternetFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = "Working...";
            WebClient Client = new WebClient();
            Client.DownloadFile(textBox1.Text, textBox2.Text + textBox3.Text);
            progressBar1.Value = 100;
            textBox6.Text = "Finished!";
        
        }
    }
}
