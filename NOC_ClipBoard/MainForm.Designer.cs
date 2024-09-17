/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 16/09/2024
 * Time: 15:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_ClipBoard
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox textBox_Content;
		private System.Windows.Forms.Button btnCopiar;
		private System.Windows.Forms.Button btnApagar;
		
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
			this.textBox_Content = new System.Windows.Forms.RichTextBox();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.btnApagar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_Content
			// 
			this.textBox_Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Content.ForeColor = System.Drawing.Color.Red;
			this.textBox_Content.Location = new System.Drawing.Point(12, 12);
			this.textBox_Content.Name = "textBox_Content";
			this.textBox_Content.Size = new System.Drawing.Size(402, 234);
			this.textBox_Content.TabIndex = 0;
			this.textBox_Content.Text = "";
			// 
			// btnCopiar
			// 
			this.btnCopiar.Location = new System.Drawing.Point(285, 252);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(129, 53);
			this.btnCopiar.TabIndex = 1;
			this.btnCopiar.Text = "Copiar";
			this.btnCopiar.UseVisualStyleBackColor = true;
			this.btnCopiar.Click += new System.EventHandler(this.BtnCopiarClick);
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(150, 252);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(129, 53);
			this.btnApagar.TabIndex = 2;
			this.btnApagar.Text = "Apagar";
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(426, 314);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.btnCopiar);
			this.Controls.Add(this.textBox_Content);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "NOC ClipBoard";
			this.ResumeLayout(false);

		}
	}
}
