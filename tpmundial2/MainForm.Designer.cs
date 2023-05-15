/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 30/11/2022
 * Time: 03:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TP_MUNDIAL
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textnombre = new System.Windows.Forms.TextBox();
			this.textApellido = new System.Windows.Forms.TextBox();
			this.listaintegrantes = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(170, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(264, 231);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FloralWhite;
			this.button1.Location = new System.Drawing.Point(309, 418);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Saludar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FloralWhite;
			this.label1.Location = new System.Drawing.Point(153, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 54);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mundial Qatar 2022";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textnombre
			// 
			this.textnombre.Location = new System.Drawing.Point(136, 313);
			this.textnombre.Name = "textnombre";
			this.textnombre.Size = new System.Drawing.Size(100, 20);
			this.textnombre.TabIndex = 3;
			// 
			// textApellido
			// 
			this.textApellido.Location = new System.Drawing.Point(360, 313);
			this.textApellido.Name = "textApellido";
			this.textApellido.Size = new System.Drawing.Size(100, 20);
			this.textApellido.TabIndex = 4;
			// 
			// listaintegrantes
			// 
			this.listaintegrantes.FormattingEnabled = true;
			this.listaintegrantes.Items.AddRange(new object[] {
									"Eliana Arias",
									"Martina Larroza",
									"Daiana Gonzalez"});
			this.listaintegrantes.Location = new System.Drawing.Point(206, 366);
			this.listaintegrantes.Name = "listaintegrantes";
			this.listaintegrantes.Size = new System.Drawing.Size(179, 21);
			this.listaintegrantes.TabIndex = 5;
			this.listaintegrantes.Text = "Selecciona un integrante";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(136, 293);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(360, 293);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Apellido";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(438, 418);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 27);
			this.button2.TabIndex = 8;
			this.button2.Text = "Ingresar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(564, 467);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listaintegrantes);
			this.Controls.Add(this.textApellido);
			this.Controls.Add(this.textnombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "TP MUNDIAL";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox listaintegrantes;
		private System.Windows.Forms.TextBox textApellido;
		private System.Windows.Forms.TextBox textnombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}}
		
	
		
		
		
	
	
