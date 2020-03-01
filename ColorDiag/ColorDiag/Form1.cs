using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDiag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }
        /// <summary>
        /// ShowDialog() Este método se invoca para poder mostrar el cuadro de dialogo.
        /// Color Retorna el color Seleccionado por el Usuario
        /// </summary>
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btnCambiarBG_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.BackColor = colorDialog1.Color;
            }
        }

        private void btnCambiarBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnAgregar.BackColor = colorDialog1.Color;
                btnCambiarBtn.BackColor = colorDialog1.Color;
                btnCambiarBG.BackColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;

            }
        }
    }

    
}
