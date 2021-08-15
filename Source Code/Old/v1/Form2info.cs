using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DankMemerBot
{
    public partial class Form2info : Form
    {
        public Form2info()
        {
            InitializeComponent();
        }

        private void Form2info_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }
    }
}
