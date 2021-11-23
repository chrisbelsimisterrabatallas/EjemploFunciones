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
    public partial class Convierte_un_numero_en_binario : Form
    {
        public Convierte_un_numero_en_binario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool esNumcorrecto = int.TryParse(this.txtNumero.Text, out int num);
            if (!esNumcorrecto)
            {
                MessageBox.Show("Debe ingresar un valor numerico...");
                return;
            }
            if (num > 0 && num <= 255)
            {
                MessageBox.Show("Numero fuera de rango...");
                return;
            }
            int[] res = Dec_Binario(num);
            Console.WriteLine("Inicio");
            for (int i = res.Length; i >= 0; i--)
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine("Fin");

            /*
            if (res[0] == 1)
                this.checkBox8.Checked = true;
            else
                this.checkBox8.Checked = false;
            */
            this.checkBox8.Checked = res[7] == 1 ? true : false;
            this.checkBox7.Checked = res[6] == 1 ? true : false;
            this.checkBox6.Checked = res[5] == 1 ? true : false;
            this.checkBox5.Checked = res[4] == 1 ? true : false;
            this.checkBox4.Checked = res[3] == 1 ? true : false;
            this.checkBox3.Checked = res[2] == 1 ? true : false;
            this.checkBox2.Checked = res[1] == 1 ? true : false;
            this.checkBox1.Checked = res[0] == 1 ? true : false;
        }

        private int[] Dec_Binario(int num)
        {
            int[] bin = new int[8];
            int i = 0;
            int res = 0;

            while (num > 0)
            {
                res = num % 2;
                bin[i++] = res;
                num = num / 2;
                //Console.WriteLine("{0}", res);
            }
            return bin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumaBinarioDecimal();
        }
        void sumaBinarioDecimal()
        {
            int num = 0;
            if (checkBox1.Checked) num += 1;
            if (checkBox2.Checked) num += 2;
            if (checkBox3.Checked) num += 4;
            if (checkBox4.Checked) num += 8;
            if (checkBox5.Checked) num += 16;
            if (checkBox6.Checked) num += 32;
            if (checkBox7.Checked) num += 64;
            if (checkBox8.Checked) num += 128;
            this.txtNumero.Text = num.ToString();
        }

        private void ck1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
  
}



