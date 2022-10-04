namespace B64CD
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.BtnAbrirArchivo = new System.Windows.Forms.Button();
			this.TbOriginal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnCodificar = new System.Windows.Forms.Button();
			this.BtnDecodificar = new System.Windows.Forms.Button();
			this.TbCodificado = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Texto 1";
			// 
			// BtnAbrirArchivo
			// 
			this.BtnAbrirArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAbrirArchivo.Location = new System.Drawing.Point(1062, 9);
			this.BtnAbrirArchivo.Name = "BtnAbrirArchivo";
			this.BtnAbrirArchivo.Size = new System.Drawing.Size(127, 28);
			this.BtnAbrirArchivo.TabIndex = 1;
			this.BtnAbrirArchivo.Text = "Abrir archivo";
			this.BtnAbrirArchivo.UseVisualStyleBackColor = true;
			this.BtnAbrirArchivo.Click += new System.EventHandler(this.BtnAbrirArchivo_Click);
			// 
			// TbOriginal
			// 
			this.TbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbOriginal.Location = new System.Drawing.Point(14, 43);
			this.TbOriginal.Multiline = true;
			this.TbOriginal.Name = "TbOriginal";
			this.TbOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbOriginal.Size = new System.Drawing.Size(1175, 236);
			this.TbOriginal.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 329);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Texto 2";
			// 
			// BtnCodificar
			// 
			this.BtnCodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCodificar.Location = new System.Drawing.Point(969, 285);
			this.BtnCodificar.Name = "BtnCodificar";
			this.BtnCodificar.Size = new System.Drawing.Size(94, 33);
			this.BtnCodificar.TabIndex = 4;
			this.BtnCodificar.Text = "Codificar";
			this.BtnCodificar.UseVisualStyleBackColor = true;
			this.BtnCodificar.Click += new System.EventHandler(this.BtnCodificar_Click);
			// 
			// BtnDecodificar
			// 
			this.BtnDecodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDecodificar.Location = new System.Drawing.Point(1069, 285);
			this.BtnDecodificar.Name = "BtnDecodificar";
			this.BtnDecodificar.Size = new System.Drawing.Size(120, 33);
			this.BtnDecodificar.TabIndex = 5;
			this.BtnDecodificar.Text = "Decodificar";
			this.BtnDecodificar.UseVisualStyleBackColor = true;
			this.BtnDecodificar.Click += new System.EventHandler(this.BtnDecodificar_Click);
			// 
			// TbCodificado
			// 
			this.TbCodificado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbCodificado.Location = new System.Drawing.Point(14, 352);
			this.TbCodificado.Multiline = true;
			this.TbCodificado.Name = "TbCodificado";
			this.TbCodificado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbCodificado.Size = new System.Drawing.Size(1175, 236);
			this.TbCodificado.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(1201, 616);
			this.Controls.Add(this.TbCodificado);
			this.Controls.Add(this.BtnDecodificar);
			this.Controls.Add(this.BtnCodificar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TbOriginal);
			this.Controls.Add(this.BtnAbrirArchivo);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "B64 Codificar/Decodificar";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnAbrirArchivo;
		private System.Windows.Forms.TextBox TbOriginal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnCodificar;
		private System.Windows.Forms.Button BtnDecodificar;
		private System.Windows.Forms.TextBox TbCodificado;
	}
}

