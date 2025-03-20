using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxfiguras.Items.Add("quadrado");
            comboBoxfiguras.Items.Add("triangulo");
            comboBoxfiguras.Items.Add("circulo");
            comboBoxfiguras.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string figura = comboBoxfiguras.SelectedIndex.ToString();
            double resultado = 0;
            double valor1, valor2, valor3, valor4, valor5;

            bool valor1Valido = double.TryParse(textboxvalor1.Text, out valor1);
            bool valor2Valido = double.TryParse(textboxvalor2.Text, out valor2);
            bool valor3Valido = double.TryParse(texboxvalor3.Text, out valor3);
            bool valor4Valido = double.TryParse(texboxvalor4.Text, out valor4);
            bool valor5Valido = double.TryParse(texboxvalor5.Text, out valor5);

            if (!valor1Valido)
            {
                labelresultado.Show("insira um valor valido");
                return;
            }

        }

       
      

    }

      
    
}
