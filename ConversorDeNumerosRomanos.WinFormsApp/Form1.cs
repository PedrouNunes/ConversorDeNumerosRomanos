using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeNumerosRomanos.WinFormsApp
{

    public partial class Form1 : Form
    {
        Dictionary<char, int> numerosRomanosParaArabicos = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
     };
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            string romano = txRomano.Text;

            var letras = romano.ToUpper().ToCharArray();
            int conversao = 0;

            bool vf = ValidarAlgoritmoRomano(letras);

            if (vf == true)
            {
            for (int i = 0; i <= letras.Length - 1; i++)
            {
                if (i == letras.Length - 1)
                {
                    conversao += numerosRomanosParaArabicos[letras[i]];
                    lbResposta.Text = Convert.ToString(romano);
                    break;
                }
                int atual = numerosRomanosParaArabicos[letras[i]];
                int nextIndex = i + 1;
                int next = numerosRomanosParaArabicos[letras[nextIndex]];

                if (atual < next)
                {
                    conversao -= atual;
                }
                if (atual >= next)
                {
                    conversao += atual;
                }
            }
            lbResposta.Text = Convert.ToString(conversao);
            }
            else
            {
                lbResposta.Text = Convert.ToString("Algoritmos como V, M, C e X não podem ser repetidos mais de 3 vezes, talvez esse seja um caso!");
            }
    }

        private bool ValidarAlgoritmoRomano(char[] letras)
        {
            bool validador = true;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras.Length > i + 3)
                {
                    if (letras[i] == 'I' && letras[i + 1] == 'I' && letras[i + 2] == 'I' && letras[i + 3] == 'I' ||
                        letras[i] == 'X' && letras[i + 1] == 'X' && letras[i + 2] == 'X' && letras[i + 3] == 'X' ||
                        letras[i] == 'C' && letras[i + 1] == 'C' && letras[i + 2] == 'C' && letras[i + 3] == 'C' ||
                        letras[i] == 'M' && letras[i + 1] == 'M' && letras[i + 2] == 'M' && letras[i + 3] == 'M'
                        )
                    {
                        validador = false;
                        break;
                    }
                    else {
                        validador = true;
                        break;
                    }
                }   
            }
                return validador;
        }
    }
    }

