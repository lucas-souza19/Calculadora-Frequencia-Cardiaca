using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Frequência_Cardíaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

                try
                {
                    FrequenciaCardiaca freqCardiaca = new FrequenciaCardiaca();
                    IntervaloFcMax interFcMax = new IntervaloFcMax();

                    int idade = int.Parse(txbIdade.Text.Trim());
                    char sexo = btmasc.Checked ? 'm' : 'f';

                    freqCardiaca.setDados(idade, sexo);

                    txbIdade.Text = idade.ToString();
                    txbFCmax.Text = freqCardiaca.CalculaFcMax().ToString() + " bpm";

                    interFcMax = freqCardiaca.CalculaFcMaxCaminhada();
                    txbcammin.Text =  interFcMax.minFc.ToString();

                    interFcMax = freqCardiaca.CalculaFcMaxCaminhada();
                    txbcammax.Text =  interFcMax.maxFc.ToString();

                    interFcMax = freqCardiaca.CalculaFcMaxCorridaLeve();
                    txbcorlmin.Text =  interFcMax.minFc.ToString();

                    interFcMax = freqCardiaca.CalculaFcMaxCorridaLeve();
                    txbcorlmax.Text = interFcMax.maxFc.ToString();

                    interFcMax = freqCardiaca.CalculaFcMaxCorridaIntensa();
                    txbcormin.Text = interFcMax.minFc.ToString();

                    interFcMax = freqCardiaca.CalculaFcMaxCorridaIntensa();
                    txbcormax.Text = interFcMax.maxFc.ToString();
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Formato Incorreto.");
            }
            catch (IdadeException)
            {
                MessageBox.Show("Não são suportados valores negativos.");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
