using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatePlus;

namespace CalcPlusfoWin
{
    public partial class Form1 : Form
    {
        static double var = 0;
        static bool isLastChar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        ///  button16_ '/'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            if (!isLastChar)
            {
                Monitor.Text += "/";
                isLastChar = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!isLastChar)
            {
                Monitor.Text += "*";
                isLastChar = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!isLastChar)
            {
                Monitor.Text += "-";
                isLastChar = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!isLastChar)
            {
                Monitor.Text += "+";
                isLastChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "1";

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "0";

        }


        /// <summary>
        /// button9 '2'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "2";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "4";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "7";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "";
            Monitor.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Monitor.Text == "0")
                Monitor.Text = "0";
            Monitor.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (isLastChar)
            {
                var = Func.ariphmetikInText(Monitor.Text);
                Monitor.Text = Convert.ToString(var);
                isLastChar = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Monitor.Text != "0")
                Monitor.Text += "00";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Monitor.Text = "0";
            isLastChar = false;

        }
    }
}
