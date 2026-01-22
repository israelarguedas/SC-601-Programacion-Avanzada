using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraSolucion.Calculadora
{
    public partial class Form1 : Form
    {
        private float numeroUno = 0;
        private float numeroDos = 0;
        private float resultado = 0;

        private string operacion = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else { 
                textBox1.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void Suma()
        {
            numeroDos = float.Parse(textBox1.Text);
            resultado = numeroUno + numeroDos;
            textBox1.Text = resultado.ToString();
        }

        private void Resta()
        {
            numeroDos = float.Parse(textBox1.Text);
            resultado = numeroUno - numeroDos;
            textBox1.Text = resultado.ToString();
        }

        private void Mult()
        {
            numeroDos = float.Parse(textBox1.Text);
            resultado = numeroUno * numeroDos;
            textBox1.Text = resultado.ToString();
        }

        private void Divis()
        {
            numeroDos = float.Parse(textBox1.Text);
            resultado = numeroUno / numeroDos;
            textBox1.Text = resultado.ToString();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            numeroUno = float.Parse(textBox1.Text);
            numeroDos = float.Parse(textBox1.Text);
            operacion = "+";

            textBox1.Text = "0";
        }
        private void buttonResta_Click(object sender, EventArgs e)
        {
            numeroUno = float.Parse(textBox1.Text);
            numeroDos = float.Parse(textBox1.Text);
            operacion = "-";

            textBox1.Text = "0";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            numeroUno = float.Parse(textBox1.Text);
            numeroDos = float.Parse(textBox1.Text);
            operacion = "*";

            textBox1.Text = "0";
        }

        private void buttonDivis_Click(object sender, EventArgs e)
        {
            numeroUno = float.Parse(textBox1.Text);
            numeroDos = float.Parse(textBox1.Text);
            operacion = "/";

            textBox1.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch(operacion)
                {
                case "+":
                    {
                        Suma();
                        break;
                    }
                case "-":
                    {
                        Resta();
                        break;
                    }
                case "*":
                    {
                        Mult();
                        break;
                    }
                case "/":
                    {
                        Divis();
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
