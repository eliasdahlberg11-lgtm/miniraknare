using static System.Runtime.InteropServices.JavaScript.JSType;

namespace miniräknare
{
    public partial class Form1 : Form
    {
        double forsta_talet = 0;
        string raknesatt = "";
        double minne = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e) //clear knapp
        {
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)// +
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "+";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)//-
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "-";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)//*
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "*";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)//delat
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "/";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)//lika med
        {
            if (raknesatt == "+")
                textBox1.Text = (forsta_talet + Convert.ToDouble(textBox1.Text)).ToString();
            if (raknesatt == "-")
            {
                textBox1.Text = (forsta_talet - Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (raknesatt == "*")
            {
                textBox1.Text = (forsta_talet * Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (raknesatt == "/")
            {
                textBox1.Text = (forsta_talet / Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)//,
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//pi
        {
            textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3,141";
        }

        private void button11_Click(object sender, EventArgs e)//m+
        {
            minne = Convert.ToDouble(textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)//MR
        {
            if (minne != 0)
            {
                textBox1.Text = minne.ToString();
            }
            else
            {
                textBox1.Text = "";
            }


        }

        private void button22_Click(object sender, EventArgs e)//MC
        {
            minne = 0;
        }

        private void button21_Click(object sender, EventArgs e)// upphöjt till
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString(); ;
        }

        private void button23_Click(object sender, EventArgs e)//roten ur
        {
            if (Convert.ToDouble(textBox1.Text) <= 0)
            {
                textBox1.Text = "ERROR";
            }
            else
            {
                double result = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = result.ToString();
            }

        }

        private void button24_Click(object sender, EventArgs e)//DEC
        {

            textBox1.Text = Convert.ToInt32(textBox1.Text, 2).ToString();

        }

        private void button25_Click(object sender, EventArgs e)//BIN
        {
            int dec = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(dec, 2);
        }

        private void button26_Click(object sender, EventArgs e)//%
        {
            double procent = Convert.ToDouble(textBox1.Text) / 100;

            if (raknesatt == "+")
            {
                textBox1.Text = (forsta_talet * (1 + procent)).ToString();
            }
            if (raknesatt == "-")
            {
                textBox1.Text = (forsta_talet * (1 - procent)).ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)//sin
        {
            double grader = Convert.ToDouble(textBox1.Text);
            double radianer = grader * Math.PI / 180;
            double sin = Math.Sin(radianer);

            textBox1.Text = sin.ToString();
        }

        private void button28_Click(object sender, EventArgs e)//cos
        {
            double grader = Convert.ToDouble(textBox1.Text);
            double radianer = grader * Math.PI / 180;
            double cos = Math.Cos(radianer);

            textBox1.Text = cos.ToString();
        }

        private void button29_Click(object sender, EventArgs e)//tan
        {
            double grader = Convert.ToDouble(textBox1.Text);
            double radianer = grader * Math.PI / 180;
            double tan = Math.Tan(radianer);

            textBox1.Text = tan.ToString();
        }

        private void button30_Click(object sender, EventArgs e)//byta tecken
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * -1).ToString();
        }
    }
}
