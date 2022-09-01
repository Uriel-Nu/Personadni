using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personadni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona UnaPersona= new Persona();
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar<=47) || (e.KeyChar>=58 && e.KeyChar<=255))
                {
                MessageBox.Show(" Por favor ingrese solo numeros ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            //if(textBox2.Text.Length < 7 || textBox2.Text.Length > 8 )
            //{
               // MessageBox.Show(" El D.N.I debe tener 8 numers");
            //}
       }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            UnaPersona.propNombre = textBox1.Text;
            UnaPersona.propDNI = long.Parse( textBox2.Text);
            UnaPersona.propFechaDeNacimiento = DateTime.Parse(textBox3.Text);
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            lbl_edad.Text = UnaPersona.EdadPersona().ToString();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 7 || textBox2.Text.Length > 8)
            {
                MessageBox.Show(" El D.N.I debe tener 8 numers");
            }

        }
    }
}
