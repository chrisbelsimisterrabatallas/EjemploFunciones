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
            int num = int.Parse(this.txtEntero.Text);
            int[] res = Dec_Binario(num);
            Console.WriteLine("Inicio");
            for(int i=0; i<res.Length; i++)
            {
                Console.WriteLine("{0}", res[i]);
            }
            Console.WriteLine("Fin");
            this.checkBox1.Checked = true;
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
    }
}
