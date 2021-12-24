
namespace Lab7
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
            this.label1 = new System.Windows.Forms.Label();
            this.browsebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.decryptbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(433, 57);
            this.browsebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(69, 28);
            this.browsebutton.TabIndex = 1;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // encryptbutton
            // 
            this.encryptbutton.Location = new System.Drawing.Point(33, 181);
            this.encryptbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(100, 28);
            this.encryptbutton.TabIndex = 4;
            this.encryptbutton.Text = "Encrypt";
            this.encryptbutton.UseVisualStyleBackColor = true;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // decryptbutton
            // 
            this.decryptbutton.Location = new System.Drawing.Point(175, 181);
            this.decryptbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decryptbutton.Name = "decryptbutton";
            this.decryptbutton.Size = new System.Drawing.Size(100, 28);
            this.decryptbutton.TabIndex = 5;
            this.decryptbutton.Text = "Decrypt";
            this.decryptbutton.UseVisualStyleBackColor = true;
            this.decryptbutton.Click += new System.EventHandler(this.decryptbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files(*.*)|*.*|Encrypted files (*.enc)|*.enc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptbutton);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.Button decryptbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

