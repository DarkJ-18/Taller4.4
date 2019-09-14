using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnlistar_Click(object sender, EventArgs e)
        {
            int desde = int.Parse(txtdesde.Text);
            int hasta = int.Parse(txthasta.Text);
            int multiplo = int.Parse(txtmultiplo.Text);

            lista.Items.Clear();

            for (int i = desde; i <= hasta; i++ )
            {

                if (i % multiplo == 0)
                {
                    lista.Items.Add(i);

                }
                      
            }



        }
    }
}
