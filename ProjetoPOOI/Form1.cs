using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOOI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        int result = 0;
        bool isValid = false;

        string flowControl;

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                result = result + Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(result) + "+";
                txt_valor.Text = "";
                flowControl = "+";
            }else
            {
                label1.Text = txt_valor.Text + btn_adicao.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                flowControl = "+";
                isValid = true;
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                result = result - Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(result) + "-";
                txt_valor.Text = "";
                flowControl = "-";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_subtracao.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                flowControl = "-";
                isValid = true;
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                result = result * Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(result) + "*";
                txt_valor.Text = "";
                flowControl = "*";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_multiplicacao.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                flowControl = "*";
                isValid = true;
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                result = result / Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(result) + "/";
                txt_valor.Text = "";
                flowControl = "/";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_divisao.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                flowControl = "/";
                isValid = true;
            }
        }

        private void btn_porcento_Click(object sender, EventArgs e)
        {
            double b = 0;
            if (isValid)
            {
                b = (b / Convert.ToDouble(txt_valor.Text)) / 100;
                label1.Text = Convert.ToString(b) + "%";
                txt_valor.Text = "";
                flowControl = "%";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_porcento.Text;
                b = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                flowControl = "%";
                isValid = true;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (flowControl == "+")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result + Convert.ToInt32(txt_valor.Text));

            }
            else if (flowControl == "-")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result - Convert.ToInt32(txt_valor.Text));

            }
            else if (flowControl == "*")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result * Convert.ToInt32(txt_valor.Text));

            }
            else if (flowControl == "/")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result / Convert.ToInt32(txt_valor.Text));

            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            result = 0;
            isValid = false;
        }
    }
}
