using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace v2._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void metroLink1_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("cmd", "/C start" + " " + "https://github.com/Tainted06/DankMemerBot"); }
        private void metroButton1_Click(object sender, EventArgs e) { MessageBox.Show("pls beg is a currency command which can give the user coins. The amount given can range from 50 coins to 300 coins. There is also a slight chance that items can be given.", "pls beg",MessageBoxButtons.OK); }
        private void metroButton2_Click(object sender, EventArgs e) { MessageBox.Show("This command is a virtual fishing game! You cast out your pole (which you can buy in the shop for ⏣ 20,000. ) and have a chance to catch a fish!", "pls fish", MessageBoxButtons.OK); }
        private void metroButton3_Click(object sender, EventArgs e) { MessageBox.Show("Pls hunt is a command that gives items, these are the items, Skunk, Duck, Deer, Boar, Rabbit, Dragon. Note: The dragon can only be obtained in special events", "pls hunt", MessageBoxButtons.OK); }
        private void metroButton4_Click(object sender, EventArgs e) { MessageBox.Show("Pls postmeme is a command that allows the user to post a meme, they can choose between different types of memes and the response of the meme will determine how many coins they will get.", "pls postmeme", MessageBoxButtons.OK); }
        private void metroButton5_Click(object sender, EventArgs e) { MessageBox.Show("You need a job for this command, the command doesn't actually answer the question correctly, it doesn't give an answer but it still gives the amount of money for getting it wrong and it increases the size of the bank.", "pls work", MessageBoxButtons.OK); }
       
        private void metroButton8_Click(object sender, EventArgs e)
        {
            timer1.Start();
            // Thread trd = new Thread(new ThreadStart(this.Bot));
            // trd.IsBackground = true;
            // trd.Start(); 
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Bot ()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                SendKeys.SendWait("pls beg");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox2.Checked)
            {
                SendKeys.SendWait("pls fish");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox3.Checked)
            {
                SendKeys.SendWait("pls hunt");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox4.Checked)
            {
                SendKeys.SendWait("pls pm");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(3000);
                SendKeys.SendWait("f");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox5.Checked)
            {
                SendKeys.SendWait("pls work");
                SendKeys.SendWait("{ENTER}");
                SendKeys.SendWait("i d k");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            Thread.Sleep(57000);
        }
    }
}
