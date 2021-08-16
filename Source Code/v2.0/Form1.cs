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
        private void Form1_Load(object sender, EventArgs e) 
        {
            if (File.Exists("STOP.STOP"))
            {
                try { File.Delete("STOP.STOP"); } catch { }
            }
        }
        private void metroLink1_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("cmd", "/C start" + " " + "https://github.com/Tainted06/DankMemerBot"); }
        private void metroButton1_Click(object sender, EventArgs e) { MessageBox.Show("pls beg is a currency command which can give the user coins. The amount given can range from 50 coins to 300 coins. There is also a slight chance that items can be given.", "pls beg",MessageBoxButtons.OK); }
        private void metroButton2_Click(object sender, EventArgs e) { MessageBox.Show("This command is a virtual fishing game! You cast out your pole (which you can buy in the shop for ⏣ 20,000. ) and have a chance to catch a fish!", "pls fish", MessageBoxButtons.OK); }
        private void metroButton3_Click(object sender, EventArgs e) { MessageBox.Show("Pls hunt is a command that gives items, these are the items, Skunk, Duck, Deer, Boar, Rabbit, Dragon. Note: The dragon can only be obtained in special events", "pls hunt", MessageBoxButtons.OK); }
        private void metroButton4_Click(object sender, EventArgs e) { MessageBox.Show("Pls postmeme is a command that allows the user to post a meme, they can choose between different types of memes and the response of the meme will determine how many coins they will get.", "pls postmeme", MessageBoxButtons.OK); }
        private void metroButton5_Click(object sender, EventArgs e) { MessageBox.Show("You need a job for this command, the command doesn't actually answer the question correctly, it doesn't give an answer but it still gives the amount of money for getting it wrong and it increases the size of the bank.", "pls work", MessageBoxButtons.OK); }
       
        private void metroButton8_Click(object sender, EventArgs e)
        {
            Thread trd = new Thread(new ThreadStart(this.Bot));
            trd.IsBackground = false;
            trd.Start();
            Thread.Sleep(1500);
        }

        private void Bot ()
        {
            timer1.Start();
            End f2 = new End();
            f2.ShowDialog(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                SendKeys.Send("pls beg");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox2.Checked)
            {
                SendKeys.Send("pls fish");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox3.Checked)
            {
                SendKeys.Send("pls hunt");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox4.Checked)
            {
                SendKeys.Send("pls pm");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(3000);
                SendKeys.Send("f");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (metroCheckBox5.Checked)
            {
                SendKeys.Send("pls work");
                SendKeys.Send("{ENTER}");
                SendKeys.Send("i d k");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }
            else { }
            if (File.Exists("STOP.STOP")) {
                ((System.Windows.Forms.Timer)sender).Stop();
                Thread.Sleep(1000);
                try { File.Delete("STOP.STOP"); } catch { } 
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
            if (File.Exists("STOP.STOP"))
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                try { File.Delete("STOP.STOP"); } catch { }
            }
            Thread.Sleep(5000);
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            FileStream fs = File.Create("STOP.STOP");
        }
    }
}
