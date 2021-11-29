namespace dynamic_aes
{
    partial class FrmEncrypt
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rbtn128 = new System.Windows.Forms.RadioButton();
            this.rbt192 = new System.Windows.Forms.RadioButton();
            this.rbt256 = new System.Windows.Forms.RadioButton();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(19, 171);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(379, 28);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrpyt_Click);
            // 
            // rbtn128
            // 
            this.rbtn128.AutoSize = true;
            this.rbtn128.Location = new System.Drawing.Point(32, 25);
            this.rbtn128.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn128.Name = "rbtn128";
            this.rbtn128.Size = new System.Drawing.Size(49, 20);
            this.rbtn128.TabIndex = 1;
            this.rbtn128.TabStop = true;
            this.rbtn128.Text = "128";
            this.rbtn128.UseVisualStyleBackColor = true;
            // 
            // rbt192
            // 
            this.rbt192.AutoSize = true;
            this.rbt192.Location = new System.Drawing.Point(32, 53);
            this.rbt192.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt192.Name = "rbt192";
            this.rbt192.Size = new System.Drawing.Size(49, 20);
            this.rbt192.TabIndex = 2;
            this.rbt192.TabStop = true;
            this.rbt192.Text = "192";
            this.rbt192.UseVisualStyleBackColor = true;
            // 
            // rbt256
            // 
            this.rbt256.AutoSize = true;
            this.rbt256.Location = new System.Drawing.Point(32, 81);
            this.rbt256.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt256.Name = "rbt256";
            this.rbt256.Size = new System.Drawing.Size(49, 20);
            this.rbt256.TabIndex = 3;
            this.rbt256.TabStop = true;
            this.rbt256.Text = "256";
            this.rbt256.UseVisualStyleBackColor = true;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(100, 36);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(132, 22);
            this.txtPlainText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Planin Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cipher Text";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(100, 82);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(132, 22);
            this.txtResult.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt256);
            this.groupBox1.Controls.Add(this.rbt192);
            this.groupBox1.Controls.Add(this.rbtn128);
            this.groupBox1.Location = new System.Drawing.Point(241, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(153, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KeySize";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 10;
            // 
            // FrmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnEncrypt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEncrypt";
            this.Text = "Aes Encryption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RadioButton rbtn128;
        private System.Windows.Forms.RadioButton rbt192;
        private System.Windows.Forms.RadioButton rbt256;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

