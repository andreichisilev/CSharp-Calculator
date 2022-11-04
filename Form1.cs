using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public float x,o,y;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<16) textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button3.Text;  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button6.Text; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button7.Text ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button9.Text;
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text=null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text+"+";
            x = Convert.ToSingle(textBox1.Text);
            o = 1;
            textBox1.Clear();

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 16) textBox1.Text += button0.Text;
        }
      
     

        private void buttondivide_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "/";
            x = Convert.ToSingle(textBox1.Text);
            o = 4;
            textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "*";
            x = Convert.ToSingle(textBox1.Text);
            o = 3;
            textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
            x = Convert.ToSingle(textBox1.Text);
            o = 2;
            textBox1.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonDot.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            label2.Text = null;
        }

        private void buttonDelS_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
        }

        private void buttonDivideS_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "/";
            x = Convert.ToSingle(textBox2.Text);
            o = 4;
            textBox2.Clear();
        }

        private void button1S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button1S.Text;
        }

        private void button2S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button2S.Text;
        }

        private void button3S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button3S.Text;
        }

        private void button4S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button4S.Text;
        }

        private void button5S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button5S.Text;
        }

        private void button6S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button6S.Text;
        }

        private void button7S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button7S.Text;
        }

        private void button8S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button8S.Text;
        }

        private void button9S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button9S.Text;
        }

        private void button0S_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 16) textBox2.Text += button0S.Text;
        }

        private void buttonMultiplyS_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "*";
            x = Convert.ToSingle(textBox2.Text);
            o = 3;
            textBox2.Clear();
        }

        private void buttonMinusS_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "-";
            x = Convert.ToSingle(textBox2.Text);
            o = 2;
            textBox2.Clear();
        }

        private void buttonPlusS_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "+";
            x = Convert.ToSingle(textBox2.Text);
            o = 1;
            textBox2.Clear();
        }

        private void buttonEqualS_Click(object sender, EventArgs e)
        {
            label2.Text += textBox2.Text + "=";
            if (o == 1) textBox2.Text = Convert.ToString((x + Convert.ToSingle(textBox2.Text)));
            if (o == 2) textBox2.Text = Convert.ToString((x - Convert.ToSingle(textBox2.Text)));
            if (o == 3) textBox2.Text = Convert.ToString((x * Convert.ToSingle(textBox2.Text)));
            if (o == 4) textBox2.Text = Convert.ToString((x / Convert.ToSingle(textBox2.Text)));
            if (o == 5) textBox2.Text = Convert.ToString((Math.Sin( Convert.ToSingle(textBox2.Text))))+" radians";
            if (o == 6) textBox2.Text = Convert.ToString((Math.Cos(Convert.ToSingle(textBox2.Text)))) + " radians";
            if (o == 7) textBox2.Text = Convert.ToString((Math.Sqrt(Convert.ToSingle(textBox2.Text))));
            if (o == 8) textBox2.Text = Convert.ToString((Math.Pow(x,Convert.ToSingle(textBox2.Text))));
        }

    
        private void buttonPosNegS_Click(object sender, EventArgs e)
        {
            y = Convert.ToSingle(textBox2.Text);
            y = -y;
            textBox2.Text = Convert.ToString(y);
        }

        private void buttonDotS_Click(object sender, EventArgs e)
        {
            textBox2.Text += buttonDotS.Text;
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "sin ";
            
            o = 5;
            textBox2.Clear();
        }

        private void buttoncos_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "cos ";

            o = 6;
            textBox2.Clear();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "√";
            
            o = 7;
            textBox2.Clear();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            float n=Convert.ToSingle(textBox2.Text);
            label2.Text =  textBox2.Text+"!= ";
            float f=1;
            for (int i = 1; i <= n; i++)
                f *= i;
            textBox2.Text = Convert.ToString(f);
                

        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text + "^";
            x = Convert.ToSingle(textBox2.Text);
            o =8;
            textBox2.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            y = Convert.ToSingle(textBox1.Text);
            y = -y;
            textBox1.Text = Convert.ToString(y);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text+ "=";
            if (o == 1) textBox1.Text = Convert.ToString((x + Convert.ToSingle(textBox1.Text)));
            if (o == 2) textBox1.Text = Convert.ToString((x - Convert.ToSingle(textBox1.Text)));
            if (o == 3) textBox1.Text = Convert.ToString((x * Convert.ToSingle(textBox1.Text)));
            if (o == 4) textBox1.Text = Convert.ToString((x / Convert.ToSingle(textBox1.Text)));
            
           
        }
    }
}
