/*
 * User: fjstavares
 * Date: 16/09/2024
 * Time: 15:17
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_ClipBoard
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void BtnCopiarClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox_Content.Text);
			textBox_Content.Clear();
		}
		void BtnApagarClick(object sender, EventArgs e)
		{
			textBox_Content.Clear();
		}
	}
}
