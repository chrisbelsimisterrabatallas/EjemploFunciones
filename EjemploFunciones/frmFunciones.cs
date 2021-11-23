using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFunciones
{
    public partial class frmFunciones : Form
    {
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int contador = cuenta_letras(this.txtFrase.Text);
            this.txtResultado.Text = contador.ToString();
        }

        /// <summary>
        /// Cuanta la cantidad de 'a' que existe en una frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>

        private int cuenta_letras(string frase, string letra)
        {
            int cont = 0;
            for(int i=0; i<=frase.Length; i++)
            {
                if (frase[i].ToString().ToLower() == letra.ToLower())
                    cont++;
            }
            return cont;
        }
    }
}
