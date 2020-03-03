namespace KlientiRii
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtMesazhetServeri = new System.Windows.Forms.RichTextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMesazhi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnSendFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMesazhetServeri
			// 
			this.txtMesazhetServeri.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtMesazhetServeri.ForeColor = System.Drawing.Color.Lime;
			this.txtMesazhetServeri.Location = new System.Drawing.Point(12, 172);
			this.txtMesazhetServeri.Name = "txtMesazhetServeri";
			this.txtMesazhetServeri.Size = new System.Drawing.Size(475, 272);
			this.txtMesazhetServeri.TabIndex = 12;
			this.txtMesazhetServeri.Text = "";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(339, 47);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(111, 39);
			this.btnStart.TabIndex = 11;
			this.btnStart.Text = "Lidhu dhe dergo";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(184, 47);
			this.txtPort.Mask = "00000";
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(123, 20);
			this.txtPort.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(193, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Port";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(41, 47);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(104, 20);
			this.txtIP.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "IP e serverit";
			// 
			// txtMesazhi
			// 
			this.txtMesazhi.Location = new System.Drawing.Point(41, 127);
			this.txtMesazhi.Name = "txtMesazhi";
			this.txtMesazhi.Size = new System.Drawing.Size(266, 20);
			this.txtMesazhi.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Shkruaj mesazhin per server";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnSendFile
			// 
			this.btnSendFile.Location = new System.Drawing.Point(339, 108);
			this.btnSendFile.Name = "btnSendFile";
			this.btnSendFile.Size = new System.Drawing.Size(111, 39);
			this.btnSendFile.TabIndex = 17;
			this.btnSendFile.Text = "Dergo Fajll";
			this.btnSendFile.UseVisualStyleBackColor = true;
			this.btnSendFile.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 456);
			this.Controls.Add(this.btnSendFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMesazhi);
			this.Controls.Add(this.txtMesazhetServeri);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMesazhetServeri;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesazhi;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnSendFile;
	}
}

