/*
 * Created by SharpDevelop.
 * User: dfj24
 * Date: 02/05/2023
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Civica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Box_nome;
		private System.Windows.Forms.TextBox Box_cognome;
		private System.Windows.Forms.Label Anno;
		private System.Windows.Forms.TextBox Box_anno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Combo_sesso;
		private System.Windows.Forms.ComboBox Combo_mese;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Box_giorno;
		private System.Windows.Forms.Button Conferma;
		private System.Windows.Forms.Button Annulla;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Box_comuni;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Box_nome = new System.Windows.Forms.TextBox();
			this.Box_cognome = new System.Windows.Forms.TextBox();
			this.Anno = new System.Windows.Forms.Label();
			this.Box_anno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Combo_sesso = new System.Windows.Forms.ComboBox();
			this.Combo_mese = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Box_giorno = new System.Windows.Forms.TextBox();
			this.Conferma = new System.Windows.Forms.Button();
			this.Annulla = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.Box_comuni = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(71, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(70, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cognome";
			// 
			// Box_nome
			// 
			this.Box_nome.Location = new System.Drawing.Point(178, 93);
			this.Box_nome.Name = "Box_nome";
			this.Box_nome.Size = new System.Drawing.Size(100, 22);
			this.Box_nome.TabIndex = 2;
			// 
			// Box_cognome
			// 
			this.Box_cognome.Location = new System.Drawing.Point(177, 154);
			this.Box_cognome.Name = "Box_cognome";
			this.Box_cognome.Size = new System.Drawing.Size(100, 22);
			this.Box_cognome.TabIndex = 3;
			// 
			// Anno
			// 
			this.Anno.Location = new System.Drawing.Point(72, 72);
			this.Anno.Name = "Anno";
			this.Anno.Size = new System.Drawing.Size(100, 23);
			this.Anno.TabIndex = 4;
			this.Anno.Text = "Anno";
			// 
			// Box_anno
			// 
			this.Box_anno.Location = new System.Drawing.Point(179, 72);
			this.Box_anno.Name = "Box_anno";
			this.Box_anno.Size = new System.Drawing.Size(100, 22);
			this.Box_anno.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mese";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(72, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sesso";
			// 
			// Combo_sesso
			// 
			this.Combo_sesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Combo_sesso.FormattingEnabled = true;
			this.Combo_sesso.Items.AddRange(new object[] {
			"Maschio",
			"Femmina"});
			this.Combo_sesso.Location = new System.Drawing.Point(179, 248);
			this.Combo_sesso.Name = "Combo_sesso";
			this.Combo_sesso.Size = new System.Drawing.Size(121, 24);
			this.Combo_sesso.TabIndex = 9;
			// 
			// Combo_mese
			// 
			this.Combo_mese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Combo_mese.FormattingEnabled = true;
			this.Combo_mese.Items.AddRange(new object[] {
			"Gennaio",
			"Febbraio",
			"Marzo",
			"Aprile",
			"Maggio",
			"Giugno",
			"Luglio",
			"Agosto",
			"Settembre",
			"Ottobre",
			"Novembre",
			"Dicembre"});
			this.Combo_mese.Location = new System.Drawing.Point(178, 134);
			this.Combo_mese.Name = "Combo_mese";
			this.Combo_mese.Size = new System.Drawing.Size(121, 24);
			this.Combo_mese.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(71, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Giorno";
			// 
			// Box_giorno
			// 
			this.Box_giorno.Location = new System.Drawing.Point(178, 192);
			this.Box_giorno.Name = "Box_giorno";
			this.Box_giorno.Size = new System.Drawing.Size(100, 22);
			this.Box_giorno.TabIndex = 12;
			// 
			// Conferma
			// 
			this.Conferma.ForeColor = System.Drawing.Color.MediumPurple;
			this.Conferma.Location = new System.Drawing.Point(400, 548);
			this.Conferma.Name = "Conferma";
			this.Conferma.Size = new System.Drawing.Size(86, 23);
			this.Conferma.TabIndex = 13;
			this.Conferma.Text = "Conferma";
			this.Conferma.UseVisualStyleBackColor = true;
			this.Conferma.Click += new System.EventHandler(this.ConfermaClick);
			// 
			// Annulla
			// 
			this.Annulla.ForeColor = System.Drawing.Color.MediumPurple;
			this.Annulla.Location = new System.Drawing.Point(549, 548);
			this.Annulla.Name = "Annulla";
			this.Annulla.Size = new System.Drawing.Size(84, 23);
			this.Annulla.TabIndex = 14;
			this.Annulla.Text = "Annulla";
			this.Annulla.UseVisualStyleBackColor = true;
			this.Annulla.Click += new System.EventHandler(this.AnnullaClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(70, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 34);
			this.label6.TabIndex = 15;
			this.label6.Text = "Comune di nascita";
			// 
			// Box_comuni
			// 
			this.Box_comuni.Location = new System.Drawing.Point(177, 216);
			this.Box_comuni.Name = "Box_comuni";
			this.Box_comuni.Size = new System.Drawing.Size(100, 22);
			this.Box_comuni.TabIndex = 16;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Box_nome);
			this.groupBox1.Controls.Add(this.Box_comuni);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.Box_cognome);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(110, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 348);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Utente";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Anno);
			this.groupBox2.Controls.Add(this.Box_anno);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.Box_giorno);
			this.groupBox2.Controls.Add(this.Combo_sesso);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.Combo_mese);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(549, 105);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 348);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dati Utente";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(410, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(211, 45);
			this.label7.TabIndex = 19;
			this.label7.Text = "Codice Fiscale";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumPurple;
			this.ClientSize = new System.Drawing.Size(1156, 613);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Annulla);
			this.Controls.Add(this.Conferma);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Civica";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
