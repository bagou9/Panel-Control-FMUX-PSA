/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 12/08/2024
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FMUX_arduino_CAN_Serial
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBoxCom;
		private System.Windows.Forms.Button buttonSerial;
		private System.Windows.Forms.Button buttonEject;
		private System.Windows.Forms.Button Mode;
		private System.Windows.Forms.Button Source;
		private System.Windows.Forms.Button Band;
		private System.Windows.Forms.Button Audio;
		private System.Windows.Forms.Button Liste;
		private System.Windows.Forms.Button Esc;
		private System.Windows.Forms.Button Menu;
		private System.Windows.Forms.Button Haut;
		private System.Windows.Forms.Button Gauche;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Droite;
		private System.Windows.Forms.Button Bas;
		private System.Windows.Forms.Button TA;
		private System.Windows.Forms.Button volmoins;
		private System.Windows.Forms.Button volplus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		
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
			this.comboBoxCom = new System.Windows.Forms.ComboBox();
			this.buttonSerial = new System.Windows.Forms.Button();
			this.buttonEject = new System.Windows.Forms.Button();
			this.Mode = new System.Windows.Forms.Button();
			this.Source = new System.Windows.Forms.Button();
			this.Band = new System.Windows.Forms.Button();
			this.Audio = new System.Windows.Forms.Button();
			this.Liste = new System.Windows.Forms.Button();
			this.Esc = new System.Windows.Forms.Button();
			this.Menu = new System.Windows.Forms.Button();
			this.Haut = new System.Windows.Forms.Button();
			this.Gauche = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.Droite = new System.Windows.Forms.Button();
			this.Bas = new System.Windows.Forms.Button();
			this.TA = new System.Windows.Forms.Button();
			this.volmoins = new System.Windows.Forms.Button();
			this.volplus = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxCom
			// 
			this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCom.FormattingEnabled = true;
			this.comboBoxCom.Location = new System.Drawing.Point(12, 12);
			this.comboBoxCom.Name = "comboBoxCom";
			this.comboBoxCom.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCom.TabIndex = 0;
			// 
			// buttonSerial
			// 
			this.buttonSerial.Location = new System.Drawing.Point(159, 12);
			this.buttonSerial.Name = "buttonSerial";
			this.buttonSerial.Size = new System.Drawing.Size(115, 23);
			this.buttonSerial.TabIndex = 1;
			this.buttonSerial.Text = "Arduino Connect";
			this.buttonSerial.UseVisualStyleBackColor = true;
			this.buttonSerial.Click += new System.EventHandler(this.ButtonSerialClick);
			// 
			// buttonEject
			// 
			this.buttonEject.Location = new System.Drawing.Point(12, 63);
			this.buttonEject.Name = "buttonEject";
			this.buttonEject.Size = new System.Drawing.Size(52, 23);
			this.buttonEject.TabIndex = 2;
			this.buttonEject.Tag = "122|02";
			this.buttonEject.Text = "Eject";
			this.buttonEject.UseVisualStyleBackColor = true;
			this.buttonEject.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Mode
			// 
			this.Mode.Location = new System.Drawing.Point(36, 124);
			this.Mode.Name = "Mode";
			this.Mode.Size = new System.Drawing.Size(61, 23);
			this.Mode.TabIndex = 3;
			this.Mode.Tag = "122|00:80";
			this.Mode.Text = "Mode";
			this.Mode.UseVisualStyleBackColor = true;
			this.Mode.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Source
			// 
			this.Source.Location = new System.Drawing.Point(124, 110);
			this.Source.Name = "Source";
			this.Source.Size = new System.Drawing.Size(59, 23);
			this.Source.TabIndex = 4;
			this.Source.Tag = "122|00:20";
			this.Source.Text = "Source";
			this.Source.UseVisualStyleBackColor = true;
			this.Source.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Band
			// 
			this.Band.Location = new System.Drawing.Point(189, 110);
			this.Band.Name = "Band";
			this.Band.Size = new System.Drawing.Size(57, 23);
			this.Band.TabIndex = 5;
			this.Band.Tag = "122|00:02";
			this.Band.Text = "Band";
			this.Band.UseVisualStyleBackColor = true;
			this.Band.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Audio
			// 
			this.Audio.Location = new System.Drawing.Point(252, 110);
			this.Audio.Name = "Audio";
			this.Audio.Size = new System.Drawing.Size(56, 23);
			this.Audio.TabIndex = 6;
			this.Audio.Tag = "122|00:04";
			this.Audio.Text = "Audio";
			this.Audio.UseVisualStyleBackColor = true;
			this.Audio.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Liste
			// 
			this.Liste.Location = new System.Drawing.Point(314, 110);
			this.Liste.Name = "Liste";
			this.Liste.Size = new System.Drawing.Size(50, 23);
			this.Liste.TabIndex = 7;
			this.Liste.Tag = "122|00:08";
			this.Liste.Text = "Liste";
			this.Liste.UseVisualStyleBackColor = true;
			this.Liste.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Esc
			// 
			this.Esc.Location = new System.Drawing.Point(384, 110);
			this.Esc.Name = "Esc";
			this.Esc.Size = new System.Drawing.Size(50, 23);
			this.Esc.TabIndex = 8;
			this.Esc.Tag = "122|01";
			this.Esc.Text = "Esc";
			this.Esc.UseVisualStyleBackColor = true;
			this.Esc.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Menu
			// 
			this.Menu.Location = new System.Drawing.Point(384, 139);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(50, 23);
			this.Menu.TabIndex = 9;
			this.Menu.Tag = "122|00:10";
			this.Menu.Text = "Menu";
			this.Menu.UseVisualStyleBackColor = true;
			this.Menu.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Haut
			// 
			this.Haut.Location = new System.Drawing.Point(510, 95);
			this.Haut.Name = "Haut";
			this.Haut.Size = new System.Drawing.Size(50, 23);
			this.Haut.TabIndex = 10;
			this.Haut.Tag = "122|00:00:40";
			this.Haut.Text = "Haut";
			this.Haut.UseVisualStyleBackColor = true;
			this.Haut.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Gauche
			// 
			this.Gauche.Location = new System.Drawing.Point(454, 124);
			this.Gauche.Name = "Gauche";
			this.Gauche.Size = new System.Drawing.Size(50, 23);
			this.Gauche.TabIndex = 11;
			this.Gauche.Tag = "122|00:01";
			this.Gauche.Text = "<-";
			this.Gauche.UseVisualStyleBackColor = true;
			this.Gauche.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// OK
			// 
			this.OK.Location = new System.Drawing.Point(510, 124);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(50, 23);
			this.OK.TabIndex = 12;
			this.OK.Tag = "122|00:00:10";
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Droite
			// 
			this.Droite.Location = new System.Drawing.Point(566, 124);
			this.Droite.Name = "Droite";
			this.Droite.Size = new System.Drawing.Size(50, 23);
			this.Droite.TabIndex = 13;
			this.Droite.Tag = "122|00:00:80";
			this.Droite.Text = "->";
			this.Droite.UseVisualStyleBackColor = true;
			this.Droite.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// Bas
			// 
			this.Bas.Location = new System.Drawing.Point(510, 153);
			this.Bas.Name = "Bas";
			this.Bas.Size = new System.Drawing.Size(50, 23);
			this.Bas.TabIndex = 14;
			this.Bas.Tag = "122|00:00:20";
			this.Bas.Text = "Bas";
			this.Bas.UseVisualStyleBackColor = true;
			this.Bas.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// TA
			// 
			this.TA.Location = new System.Drawing.Point(566, 63);
			this.TA.Name = "TA";
			this.TA.Size = new System.Drawing.Size(50, 23);
			this.TA.TabIndex = 15;
			this.TA.Tag = "122|00:40";
			this.TA.Text = "TA";
			this.TA.UseVisualStyleBackColor = true;
			this.TA.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// volmoins
			// 
			this.volmoins.Location = new System.Drawing.Point(67, 196);
			this.volmoins.Name = "volmoins";
			this.volmoins.Size = new System.Drawing.Size(30, 23);
			this.volmoins.TabIndex = 16;
			this.volmoins.Text = "-";
			this.volmoins.UseVisualStyleBackColor = true;
			this.volmoins.Click += new System.EventHandler(this.VolmoinsClick);
			// 
			// volplus
			// 
			this.volplus.Location = new System.Drawing.Point(103, 196);
			this.volplus.Name = "volplus";
			this.volplus.Size = new System.Drawing.Size(30, 23);
			this.volplus.TabIndex = 17;
			this.volplus.Text = "+";
			this.volplus.UseVisualStyleBackColor = true;
			this.volplus.Click += new System.EventHandler(this.VolplusClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Volume";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(133, 153);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 23);
			this.button1.TabIndex = 19;
			this.button1.Tag = "122|80";
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(175, 153);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 23);
			this.button2.TabIndex = 20;
			this.button2.Tag = "122|40";
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(214, 153);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(20, 23);
			this.button3.TabIndex = 21;
			this.button3.Tag = "122|20";
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(254, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(20, 23);
			this.button4.TabIndex = 22;
			this.button4.Tag = "122|10";
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(298, 153);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(20, 23);
			this.button5.TabIndex = 23;
			this.button5.Tag = "122|08";
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(344, 153);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(20, 23);
			this.button6.TabIndex = 24;
			this.button6.Tag = "122|04";
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 240);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.volplus);
			this.Controls.Add(this.volmoins);
			this.Controls.Add(this.TA);
			this.Controls.Add(this.Bas);
			this.Controls.Add(this.Droite);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.Gauche);
			this.Controls.Add(this.Haut);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.Esc);
			this.Controls.Add(this.Liste);
			this.Controls.Add(this.Audio);
			this.Controls.Add(this.Band);
			this.Controls.Add(this.Source);
			this.Controls.Add(this.Mode);
			this.Controls.Add(this.buttonEject);
			this.Controls.Add(this.buttonSerial);
			this.Controls.Add(this.comboBoxCom);
			this.Name = "MainForm";
			this.Text = "FMUX_arduino-CAN_Serial";
			this.ResumeLayout(false);

		}
	}
}
