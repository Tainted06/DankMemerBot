using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading;

namespace DankMemerBot
{
    public partial class runnin : Form
    {
        public runnin()
        {
            InitializeComponent();
        }

        private void runnin_Load(object sender, EventArgs e)
        {
            if (String.Equals(File.ReadLines("settings.hi").Skip(1), "true"))
            {
                MessageBox.Show("Some text", "Some title");
            }
            else
            {
                Thread.Sleep(1);
            }
            
        }
    }
}
