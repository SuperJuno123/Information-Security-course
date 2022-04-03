namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputTextBinary = new System.Windows.Forms.TextBox();
            this.buttonKeyEncrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRandomEncrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxResultBinary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKeyBinary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDecryptedBinary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.buttonKeyDecrypt = new System.Windows.Forms.Button();
            this.buttonRandomDecrypt = new System.Windows.Forms.Button();
            this.textBoxRandomKey = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRandomKeyBinary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(12, 38);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputText.Size = new System.Drawing.Size(177, 145);
            this.textBoxInputText.TabIndex = 0;
            this.textBoxInputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Двоичный вид";
            // 
            // textBoxInputTextBinary
            // 
            this.textBoxInputTextBinary.Location = new System.Drawing.Point(12, 290);
            this.textBoxInputTextBinary.Multiline = true;
            this.textBoxInputTextBinary.Name = "textBoxInputTextBinary";
            this.textBoxInputTextBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputTextBinary.Size = new System.Drawing.Size(171, 112);
            this.textBoxInputTextBinary.TabIndex = 3;
            // 
            // buttonKeyEncrypt
            // 
            this.buttonKeyEncrypt.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonKeyEncrypt.Location = new System.Drawing.Point(277, 151);
            this.buttonKeyEncrypt.Name = "buttonKeyEncrypt";
            this.buttonKeyEncrypt.Size = new System.Drawing.Size(171, 42);
            this.buttonKeyEncrypt.TabIndex = 4;
            this.buttonKeyEncrypt.Text = "Зашифровать на основе ключа";
            this.buttonKeyEncrypt.UseVisualStyleBackColor = false;
            this.buttonKeyEncrypt.Click += new System.EventHandler(this.buttonKeyEncrypt_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxKey.Location = new System.Drawing.Point(218, 41);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxKey.Size = new System.Drawing.Size(137, 104);
            this.textBoxKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ключ";
            // 
            // buttonRandomEncrypt
            // 
            this.buttonRandomEncrypt.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRandomEncrypt.Location = new System.Drawing.Point(223, 204);
            this.buttonRandomEncrypt.Name = "buttonRandomEncrypt";
            this.buttonRandomEncrypt.Size = new System.Drawing.Size(289, 36);
            this.buttonRandomEncrypt.TabIndex = 7;
            this.buttonRandomEncrypt.Text = "Зашифровать на основе случайной последовательности:";
            this.buttonRandomEncrypt.UseVisualStyleBackColor = false;
            this.buttonRandomEncrypt.Click += new System.EventHandler(this.buttonRandomEncrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInfo.Location = new System.Drawing.Point(18, 439);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(976, 83);
            this.textBoxInfo.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxResultBinary
            // 
            this.textBoxResultBinary.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxResultBinary.Location = new System.Drawing.Point(528, 294);
            this.textBoxResultBinary.Multiline = true;
            this.textBoxResultBinary.Name = "textBoxResultBinary";
            this.textBoxResultBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultBinary.Size = new System.Drawing.Size(171, 112);
            this.textBoxResultBinary.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxResult.Location = new System.Drawing.Point(518, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(180, 145);
            this.textBoxResult.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Двоичный вид ";
            // 
            // textBoxKeyBinary
            // 
            this.textBoxKeyBinary.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxKeyBinary.Location = new System.Drawing.Point(376, 43);
            this.textBoxKeyBinary.Multiline = true;
            this.textBoxKeyBinary.Name = "textBoxKeyBinary";
            this.textBoxKeyBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxKeyBinary.Size = new System.Drawing.Size(136, 102);
            this.textBoxKeyBinary.TabIndex = 15;
            this.textBoxKeyBinary.TextChanged += new System.EventHandler(this.textBoxKeyBinary_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Двоичный вид";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(869, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Двоичный вид";
            // 
            // textBoxDecryptedBinary
            // 
            this.textBoxDecryptedBinary.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDecryptedBinary.Location = new System.Drawing.Point(823, 295);
            this.textBoxDecryptedBinary.Multiline = true;
            this.textBoxDecryptedBinary.Name = "textBoxDecryptedBinary";
            this.textBoxDecryptedBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecryptedBinary.Size = new System.Drawing.Size(171, 108);
            this.textBoxDecryptedBinary.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Расшифрованный текст";
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxDecrypted.Location = new System.Drawing.Point(814, 43);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecrypted.Size = new System.Drawing.Size(180, 140);
            this.textBoxDecrypted.TabIndex = 18;
            // 
            // buttonKeyDecrypt
            // 
            this.buttonKeyDecrypt.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonKeyDecrypt.Location = new System.Drawing.Point(720, 38);
            this.buttonKeyDecrypt.Name = "buttonKeyDecrypt";
            this.buttonKeyDecrypt.Size = new System.Drawing.Size(75, 86);
            this.buttonKeyDecrypt.TabIndex = 23;
            this.buttonKeyDecrypt.Text = "Расшифровать на основе ключа";
            this.buttonKeyDecrypt.UseVisualStyleBackColor = false;
            this.buttonKeyDecrypt.Click += new System.EventHandler(this.buttonKeyDecrypt_Click);
            // 
            // buttonRandomDecrypt
            // 
            this.buttonRandomDecrypt.BackColor = System.Drawing.Color.LightGreen;
            this.buttonRandomDecrypt.Location = new System.Drawing.Point(720, 326);
            this.buttonRandomDecrypt.Name = "buttonRandomDecrypt";
            this.buttonRandomDecrypt.Size = new System.Drawing.Size(75, 55);
            this.buttonRandomDecrypt.TabIndex = 24;
            this.buttonRandomDecrypt.Text = "Расшифровать\r\n";
            this.buttonRandomDecrypt.UseVisualStyleBackColor = false;
            this.buttonRandomDecrypt.Click += new System.EventHandler(this.buttonRandomDecrypt_Click);
            // 
            // textBoxRandomKey
            // 
            this.textBoxRandomKey.Location = new System.Drawing.Point(218, 277);
            this.textBoxRandomKey.Multiline = true;
            this.textBoxRandomKey.Name = "textBoxRandomKey";
            this.textBoxRandomKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRandomKey.Size = new System.Drawing.Size(127, 125);
            this.textBoxRandomKey.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(641, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 204);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Случайная гамма:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Двоичный вид:";
            // 
            // textBoxRandomKeyBinary
            // 
            this.textBoxRandomKeyBinary.Location = new System.Drawing.Point(371, 281);
            this.textBoxRandomKeyBinary.Multiline = true;
            this.textBoxRandomKeyBinary.Name = "textBoxRandomKeyBinary";
            this.textBoxRandomKeyBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRandomKeyBinary.Size = new System.Drawing.Size(127, 125);
            this.textBoxRandomKeyBinary.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 534);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRandomKeyBinary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxRandomKey);
            this.Controls.Add(this.buttonRandomDecrypt);
            this.Controls.Add(this.buttonKeyDecrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDecryptedBinary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKeyBinary);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxResultBinary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRandomEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonKeyEncrypt);
            this.Controls.Add(this.textBoxInputTextBinary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputTextBinary;
        private System.Windows.Forms.Button buttonKeyEncrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRandomEncrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxResultBinary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeyBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDecryptedBinary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Button buttonKeyDecrypt;
        private System.Windows.Forms.Button buttonRandomDecrypt;
        private System.Windows.Forms.TextBox textBoxRandomKey;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRandomKeyBinary;
    }
}

