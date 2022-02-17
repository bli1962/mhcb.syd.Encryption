namespace Encryption.App
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
			this.bEncrypt = new System.Windows.Forms.Button();
			this.tbInput = new System.Windows.Forms.TextBox();
			this.bDecrypt = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bEncrypt
			// 
			this.bEncrypt.Location = new System.Drawing.Point(12, 12);
			this.bEncrypt.Name = "bEncrypt";
			this.bEncrypt.Size = new System.Drawing.Size(119, 37);
			this.bEncrypt.TabIndex = 0;
			this.bEncrypt.Text = "Encrypt";
			this.bEncrypt.UseVisualStyleBackColor = true;
			this.bEncrypt.Click += new System.EventHandler(this.EncryptClick);
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(12, 55);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(322, 20);
			this.tbInput.TabIndex = 2;
			this.tbInput.Text = "Input";
			// 
			// bDecrypt
			// 
			this.bDecrypt.Location = new System.Drawing.Point(235, 12);
			this.bDecrypt.Name = "bDecrypt";
			this.bDecrypt.Size = new System.Drawing.Size(99, 37);
			this.bDecrypt.TabIndex = 3;
			this.bDecrypt.Text = "Decrypt";
			this.bDecrypt.UseVisualStyleBackColor = true;
			this.bDecrypt.Click += new System.EventHandler(this.DecryptClick);
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(12, 84);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(322, 20);
			this.tbOutput.TabIndex = 4;
			this.tbOutput.Text = "Output";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 116);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.bDecrypt);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(this.bEncrypt);
			this.Name = "Form1";
			this.Text = "Mizuho Encryption";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

