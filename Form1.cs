using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valorX, valorY, valorZ;
        string triangulo;


        private void button1_Click(object sender, EventArgs e)
        {
            valorX = Convert.ToInt32(textBox1.Text);
            valorY = Convert.ToInt32(textBox2.Text);
            valorZ = Convert.ToInt32(textBox3.Text);

            if (valorX < (valorY + valorZ) && valorY < (valorX + valorZ) && valorZ < (valorX + valorY))
            {
                if (valorX == valorY && valorY == valorZ && valorX == valorZ)
                {
                    triangulo = "Um triângulo equilátero!";
                }
                else if (valorX != valorY && valorX != valorZ && valorY != valorZ)
                {
                    triangulo = "Um triângulo escaleno!";
                }
                else if (valorX == valorY || valorX == valorZ || valorY == valorZ)
                {
                    triangulo = "Um triângulo isóceles!";
                }
            }
            else
            {
                triangulo = "Não é um triângulo";
            }

            MessageBox.Show("Seu triângulo é: " + triangulo, "Resultado do Cálculo");
        }
    }
}
