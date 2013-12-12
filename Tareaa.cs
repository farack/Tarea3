using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WTF
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string usuario="fernando";
		string password="texto";
		
		public MainForm()
		{
			
			InitializeComponent();
				
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
                void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(fernando.Text== usuario&& texto.Text== password)
			{
				MessageBox.Show("B I E N V E N I D O");
			}
			else
			{
				MessageBox.Show("E R R O R");
			}
		}
	}
}
