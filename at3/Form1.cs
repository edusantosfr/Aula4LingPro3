using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at3
{
    public partial class Form1 : Form
    {

        double maca, valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonResposta_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                maca = double.Parse(textBox1.Text);
                if (maca > 0 && maca <10)
                {
                    valor = maca * 2.2;
                    MessageBox.Show("O valor é de R$" + valor + ".", "Valor Total");
                }

                if (maca <= 0)
                {
                    MessageBox.Show("Nenhum valor foi digitado ou é zero.", "Erro");
                }

                if (maca >= 10)
                {
                    MessageBox.Show("Troque de Opção antes de colocar a quantidade.", "Erro");
                }

            }

            if (comboBox1.SelectedIndex == 1 )
            {
                maca = double.Parse(textBox1.Text);

                if (maca >= 20 || maca <10)
                {
                    MessageBox.Show("Troque de Opção antes de colocar a quantidade.", "Erro");
                }

                else
                {
                    valor = maca * 2;
                    MessageBox.Show("O valor é de R$" + valor + ".", "Valor Total");
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {

                maca = double.Parse(textBox1.Text);

                if (maca >= 30 || maca < 20)
                {
                    MessageBox.Show("Troque de Opção antes de colocar a quantidade.", "Erro");
                }

                else
                {
                    valor = maca * 1.8;
                    MessageBox.Show("O valor é de R$" + valor + ".", "Valor Total");
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                maca = double.Parse(textBox1.Text);

                if (maca < 30)
                {
                    MessageBox.Show("Troque de Opção antes de colocar a quantidade.", "Erro");
                }

                if (maca >= 30)
                {
                    valor = maca * 1.5;
                    MessageBox.Show("O valor é de R$" + valor + ".", "Valor Total");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaca_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}