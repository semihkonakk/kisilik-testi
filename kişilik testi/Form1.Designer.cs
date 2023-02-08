namespace kişilik_testi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.ee = new System.Windows.Forms.Button();
            this.sorugetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(38, 238);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(174, 54);
            this.a.TabIndex = 0;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.cevaplar);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(105, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 67);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BAŞLA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(297, 238);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(174, 54);
            this.b.TabIndex = 3;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.cevaplar);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(540, 238);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(174, 54);
            this.c.TabIndex = 4;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.cevaplar);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(185, 298);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(174, 54);
            this.d.TabIndex = 5;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.cevaplar);
            // 
            // ee
            // 
            this.ee.Location = new System.Drawing.Point(413, 298);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(174, 54);
            this.ee.TabIndex = 6;
            this.ee.Text = "E";
            this.ee.UseVisualStyleBackColor = true;
            this.ee.Click += new System.EventHandler(this.cevaplar);
            // 
            // sorugetir
            // 
            this.sorugetir.Location = new System.Drawing.Point(297, 79);
            this.sorugetir.Name = "sorugetir";
            this.sorugetir.Size = new System.Drawing.Size(157, 56);
            this.sorugetir.TabIndex = 7;
            this.sorugetir.Text = "BAŞLA";
            this.sorugetir.UseVisualStyleBackColor = true;
            this.sorugetir.Click += new System.EventHandler(this.sorugetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "SONUÇ:";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(109, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(643, 90);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "puan";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(216, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 59);
            this.label4.TabIndex = 11;
            this.label4.Text = "KİŞİLİK TESTİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sorugetir);
            this.Controls.Add(this.ee);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button a;
        private TextBox textBox1;
        private Label label1;
        private Button b;
        private Button c;
        private Button d;
        private Button ee;
        private Button sorugetir;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}