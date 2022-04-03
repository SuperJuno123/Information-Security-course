namespace Mubarakov_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.textBoxDimensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_fi_n = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(406, 32);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(95, 53);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(526, 49);
            this.textBoxOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOriginal.Size = new System.Drawing.Size(331, 131);
            this.textBoxOriginal.TabIndex = 1;
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(526, 240);
            this.textBoxEncrypted.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncrypted.Size = new System.Drawing.Size(331, 125);
            this.textBoxEncrypted.TabIndex = 2;
            this.textBoxEncrypted.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(526, 421);
            this.textBoxDecrypted.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecrypted.Size = new System.Drawing.Size(331, 131);
            this.textBoxDecrypted.TabIndex = 3;
            // 
            // textBoxDimensity
            // 
            this.textBoxDimensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxDimensity.Location = new System.Drawing.Point(22, 32);
            this.textBoxDimensity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDimensity.Multiline = true;
            this.textBoxDimensity.Name = "textBoxDimensity";
            this.textBoxDimensity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDimensity.Size = new System.Drawing.Size(330, 53);
            this.textBoxDimensity.TabIndex = 4;
            this.textBoxDimensity.Text = "128";
            this.textBoxDimensity.TextChanged += new System.EventHandler(this.textBoxDimensity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Длина простых чисел p и q (в битах)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "p - простое число";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_p
            // 
            this.textBox_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_p.Location = new System.Drawing.Point(22, 107);
            this.textBox_p.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_p.Multiline = true;
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.ReadOnly = true;
            this.textBox_p.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_p.Size = new System.Drawing.Size(330, 53);
            this.textBox_p.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "q - простое число";
            // 
            // textBox_q
            // 
            this.textBox_q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_q.Location = new System.Drawing.Point(22, 184);
            this.textBox_q.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_q.Multiline = true;
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.ReadOnly = true;
            this.textBox_q.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_q.Size = new System.Drawing.Size(330, 53);
            this.textBox_q.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "n = p*q";
            // 
            // textBox_n
            // 
            this.textBox_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_n.Location = new System.Drawing.Point(22, 259);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_n.Multiline = true;
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.ReadOnly = true;
            this.textBox_n.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_n.Size = new System.Drawing.Size(330, 53);
            this.textBox_n.TabIndex = 10;
            this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "φ(n)";
            // 
            // textBox_fi_n
            // 
            this.textBox_fi_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_fi_n.Location = new System.Drawing.Point(22, 340);
            this.textBox_fi_n.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fi_n.Multiline = true;
            this.textBox_fi_n.Name = "textBox_fi_n";
            this.textBox_fi_n.ReadOnly = true;
            this.textBox_fi_n.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_fi_n.Size = new System.Drawing.Size(330, 53);
            this.textBox_fi_n.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "e - открытая экспонента";
            // 
            // textBox_e
            // 
            this.textBox_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox_e.Location = new System.Drawing.Point(22, 421);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_e.Multiline = true;
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.ReadOnly = true;
            this.textBox_e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_e.Size = new System.Drawing.Size(330, 53);
            this.textBox_e.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 483);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "d - закрытая экспонента";
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox_d.Location = new System.Drawing.Point(22, 499);
            this.textBox_d.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_d.Multiline = true;
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.ReadOnly = true;
            this.textBox_d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_d.Size = new System.Drawing.Size(330, 53);
            this.textBox_d.TabIndex = 16;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(526, 194);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(331, 24);
            this.buttonEncrypt.TabIndex = 18;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(526, 382);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(331, 24);
            this.buttonDecrypt.TabIndex = 19;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Исходный текст";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(406, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 78);
            this.button1.TabIndex = 21;
            this.button1.Text = "Протестировать отдельно тест Миллера-Рабина";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Location = new System.Drawing.Point(406, 339);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 78);
            this.button2.TabIndex = 22;
            this.button2.Text = "Протестировать отдельно быстрое возведение в степень";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(406, 450);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 78);
            this.button3.TabIndex = 23;
            this.button3.Text = "Протестировать отдельно расширенный алгоритм Евклида";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Длина\r\nчисла";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 568);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_fi_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDimensity);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.buttonGenerate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.TextBox textBoxDimensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_fi_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

