/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 30/11/2022
 * Time: 03:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TP_MUNDIAL
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
	
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
          	MessageBox.Show("Hola " + listaintegrantes.SelectedItem + " Bienvenida al programa de predicción del Mundial Qatar 2022 ");
          	int indice= listaintegrantes.SelectedIndex;
          	switch(indice)
          	{
          		case 0:
          		    textnombre.Text= "Eliana";
                    textApellido.Text="Arias";
                    break;                    
          		case 1:
          			textnombre.Text = "Martina";
          			textApellido.Text= "Larroza";
          			break;
          		case 2:
          			textnombre.Text= "Daiana";
          			textApellido.Text= "Gonzalez";
          			break;
          		
          	}
          	
          
          	
		}
		
		void Button2Click(object sender, EventArgs e){
				Form formulario = new Form1();
          	    formulario.Show();
          	    this.Hide();
		}
	}
}
