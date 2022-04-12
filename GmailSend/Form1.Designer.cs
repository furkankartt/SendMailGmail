namespace GmailSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxKime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBilgi = new System.Windows.Forms.TextBox();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.textBoxIcerik = new System.Windows.Forms.TextBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKime
            // 
            this.textBoxKime.Location = new System.Drawing.Point(75, 12);
            this.textBoxKime.Name = "textBoxKime";
            this.textBoxKime.Size = new System.Drawing.Size(509, 22);
            this.textBoxKime.TabIndex = 0;
            this.textBoxKime.Text = "furkankartt@outlook.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Kime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bilgi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Konu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "*İçerik:";
            // 
            // textBoxBilgi
            // 
            this.textBoxBilgi.Location = new System.Drawing.Point(75, 47);
            this.textBoxBilgi.Name = "textBoxBilgi";
            this.textBoxBilgi.Size = new System.Drawing.Size(509, 22);
            this.textBoxBilgi.TabIndex = 5;
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Location = new System.Drawing.Point(75, 81);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(509, 22);
            this.textBoxKonu.TabIndex = 6;
            this.textBoxKonu.Text = "Deneme";
            // 
            // textBoxIcerik
            // 
            this.textBoxIcerik.Location = new System.Drawing.Point(75, 115);
            this.textBoxIcerik.Multiline = true;
            this.textBoxIcerik.Name = "textBoxIcerik";
            this.textBoxIcerik.Size = new System.Drawing.Size(509, 118);
            this.textBoxIcerik.TabIndex = 7;
            this.textBoxIcerik.Text = "Deneme";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(468, 245);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(116, 59);
            this.buttonGonder.TabIndex = 8;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 319);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.textBoxIcerik);
            this.Controls.Add(this.textBoxKonu);
            this.Controls.Add(this.textBoxBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gmail Mail Gönder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBilgi;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.TextBox textBoxIcerik;
        private System.Windows.Forms.Button buttonGonder;
    }
}

