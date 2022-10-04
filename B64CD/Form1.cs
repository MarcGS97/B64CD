using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B64CD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnAbrirArchivo_Click(object sender, EventArgs e)
		{
			var fileContent = string.Empty;
			var filePath = string.Empty;
			String file64 = "";
			String extension = "";
			Byte[] bytes = null;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				//openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt|jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg|gif files (*.gif)|*.gif|webp files (*.webp)|*.webp|svg files (*.svg)|*.svg|bmp files (*.bmp)|*.bmp";
				//openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = false;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;

					//Read the contents of the file into a stream
					//var fileStream = openFileDialog.OpenFile();

					try
					{
						bytes = File.ReadAllBytes(filePath);
						file64 = Convert.ToBase64String(bytes);
					}
					catch(Exception Ex1) { }
					extension = Path.GetExtension(filePath).ToLower();
					extension = extension.Replace(".","");
					TbOriginal.Text = Encoding.UTF8.GetString(bytes);

					if (extension == "jpg" || extension == "png" || extension == "jpeg" || extension == "gif" || extension == "webp" || extension == "svg" || extension == "bmp")
					{
						if(extension == "jpg")
						{
							TbCodificado.Text = "data:image/jpg;base64," + file64;
						}
						if(extension == "png")
						{
							TbCodificado.Text = "data:image/png;base64," + file64;
						}
						if(extension == "jpeg")
						{
							TbCodificado.Text = "data:image/jpeg;base64," + file64;
						}
						if(extension == "bmp")
						{
							TbCodificado.Text = "data:image/bmp;base64," + file64;
						}
						if (extension == "gif")
						{
							TbCodificado.Text = "data:image/png;base64," + file64;
						}
						if (extension == "svg")
						{
							TbCodificado.Text = "data:image/svg+xml;base64," + file64;
						}
						if (extension == "webp")
						{
							TbCodificado.Text = "data:image/webp;base64," + file64;
						}
					}
					else
					{
						TbCodificado.Text = file64;
					}
				}
			}
		}

		private void BtnCodificar_Click(object sender, EventArgs e)
		{
			byte[] texto_bytes = Encoding.UTF8.GetBytes(TbOriginal.Text);
			TbCodificado.Text = Convert.ToBase64String(texto_bytes);
		}

		private void BtnDecodificar_Click(object sender, EventArgs e)
		{
			byte[] texto_byte = Convert.FromBase64String(TbOriginal.Text);
			TbCodificado.Text = Encoding.UTF8.GetString(texto_byte);
		}
	}
}
