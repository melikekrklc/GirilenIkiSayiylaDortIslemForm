
namespace Form_uygörn5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textsayi1 = new System.Windows.Forms.TextBox();
            this.textsayi2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texttoplam = new System.Windows.Forms.TextBox();
            this.textfark = new System.Windows.Forms.TextBox();
            this.textçarpım = new System.Windows.Forms.TextBox();
            this.textbölme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "sayi2";
            // 
            // textsayi1
            // 
            this.textsayi1.Location = new System.Drawing.Point(81, 30);
            this.textsayi1.Name = "textsayi1";
            this.textsayi1.Size = new System.Drawing.Size(100, 22);
            this.textsayi1.TabIndex = 2;
            // 
            // textsayi2
            // 
            this.textsayi2.Location = new System.Drawing.Point(81, 89);
            this.textsayi2.Name = "textsayi2";
            this.textsayi2.Size = new System.Drawing.Size(100, 22);
            this.textsayi2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "fark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "çarpım";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "bölme";
            // 
            // texttoplam
            // 
            this.texttoplam.Location = new System.Drawing.Point(198, 50);
            this.texttoplam.Name = "texttoplam";
            this.texttoplam.Size = new System.Drawing.Size(100, 22);
            this.texttoplam.TabIndex = 9;
            // 
            // textfark
            // 
            this.textfark.Location = new System.Drawing.Point(198, 93);
            this.textfark.Name = "textfark";
            this.textfark.Size = new System.Drawing.Size(100, 22);
            this.textfark.TabIndex = 10;
            // 
            // textçarpım
            // 
            this.textçarpım.Location = new System.Drawing.Point(198, 135);
            this.textçarpım.Name = "textçarpım";
            this.textçarpım.Size = new System.Drawing.Size(100, 22);
            this.textçarpım.TabIndex = 11;
            // 
            // textbölme
            // 
            this.textbölme.Location = new System.Drawing.Point(198, 172);
            this.textbölme.Name = "textbölme";
            this.textbölme.Size = new System.Drawing.Size(100, 22);
            this.textbölme.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textsayi1);
            this.groupBox1.Controls.Add(this.textsayi2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 316);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textbölme);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textçarpım);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textfark);
            this.groupBox2.Controls.Add(this.texttoplam);
            this.groupBox2.Location = new System.Drawing.Point(450, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 350);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsayi1;
        private System.Windows.Forms.TextBox textsayi2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texttoplam;
        private System.Windows.Forms.TextBox textfark;
        private System.Windows.Forms.TextBox textçarpım;
        private System.Windows.Forms.TextBox textbölme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

