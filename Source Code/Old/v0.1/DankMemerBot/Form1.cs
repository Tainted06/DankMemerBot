﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using MetroFramework;


namespace DankMemerBot
{

    public partial class DankMemerSpammer : Form
    {

        public DankMemerSpammer()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

            button7.TabStop = false;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            button8.TabStop = false;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

            button9.TabStop = false;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //how to use
            Form2h2u f2 = new Form2h2u();
            f2.ShowDialog(); //
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //pls work info
            MessageBox.Show("You need a job for this command, the command dosent acctually answer the question correctly, it dosent give an answer but it still gives the amount of money for getting it wrong and it increases the size of the bank.", "pls work",MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //pls beg info
            MessageBox.Show("pls beg is a currency command which can give the user coins. The amount given can range from 50 coins to 300 coins. There is also a slight chance that items can be given.", "pls beg",
            MessageBoxButtons.OK);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //pls fish info
            MessageBox.Show("This command is a virtual fishing game! You cast out your pole (which you can buy in the shop for ⏣ 20,000. ) and have a chance to catch a fish!", "pls fish",MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //pls hunt info
            MessageBox.Show("Pls hunt is a command that gives items, these are the items, Skunk, Duck, Deer, Boar, Rabbit, Dragon. Note: The dragon can only be obtained in special events", "pls hunt",MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //pls pm info
            MessageBox.Show("Pls postmeme is a command that allows the user to post a meme, they can choose between diffrent types of memes and the response of the meme will determine how many coins they will get.", "pls postmeme",MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //info
            //Form2info f2 = new Form2info();
            //f2.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //stop
            timer1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //start
            timer1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //pls beg
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //pls postmeme
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //pls fish
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //pls hunt
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //pls work
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendKeys.Send("pls beg");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }

            if (checkBox2.Checked)
            {
                SendKeys.Send("pls fish");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }

            if (checkBox3.Checked)
            {
                SendKeys.Send("pls hunt");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }

            if (checkBox4.Checked)
            {
                SendKeys.Send("pls pm");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(3000);
                SendKeys.Send("f");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }

            if (checkBox5.Checked)
            {
                SendKeys.Send("pls work");
                SendKeys.Send("{ENTER}");
                SendKeys.Send("i d k");
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
            }

            Thread.Sleep(58000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
