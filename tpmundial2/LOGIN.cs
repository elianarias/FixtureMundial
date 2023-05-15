using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmundial2
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        
        
          
private void button1_Click(object sender, EventArgs e)
        {

            int indice = listaintegrantes.SelectedIndex;
            switch (indice)
            {
                case 0:
                    textnombre.Text = "Eliana";
                    textApellido.Text = "Arias";
                    break;
                case 1:
                    textnombre.Text = "Martina";
                    textApellido.Text = "Larroza";
                    break;
                case 2:
                    textnombre.Text = "Daiana";
                    textApellido.Text = "Gonzalez";
                    break;

            }

            MessageBox.Show("Hola " + listaintegrantes.SelectedItem + " Bienvenida al programa de predicción del Mundial Qatar 2022 ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form formulario = new Form1();
                formulario.Show();
                this.Hide();
            
        }

        
    }
    }

