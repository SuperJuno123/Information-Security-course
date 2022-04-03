namespace Mubarakov_4
{
    partial class MillerRabin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MillerRabin));
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_steps = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_result_wolfram = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_start_one_number = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_n_rounds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_length_in_bit = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button_start_random_one_number = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_start_many_iteration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(360, 255);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 13);
            this.label22.TabIndex = 77;
            this.label22.Text = "Шаги алгоритма:";
            // 
            // textBox_steps
            // 
            this.textBox_steps.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_steps.Location = new System.Drawing.Point(14, 271);
            this.textBox_steps.Multiline = true;
            this.textBox_steps.Name = "textBox_steps";
            this.textBox_steps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_steps.Size = new System.Drawing.Size(817, 128);
            this.textBox_steps.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(580, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 13);
            this.label19.TabIndex = 73;
            this.label19.Text = "А wolfram alpha говорит:";
            // 
            // textBox_result_wolfram
            // 
            this.textBox_result_wolfram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_result_wolfram.Location = new System.Drawing.Point(876, 337);
            this.textBox_result_wolfram.Multiline = true;
            this.textBox_result_wolfram.Name = "textBox_result_wolfram";
            this.textBox_result_wolfram.Size = new System.Drawing.Size(165, 41);
            this.textBox_result_wolfram.TabIndex = 72;
            this.textBox_result_wolfram.TextChanged += new System.EventHandler(this.textBox_result_b_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(171, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Тест говорит:";
            // 
            // textBox_result
            // 
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_result.Location = new System.Drawing.Point(116, 428);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(189, 41);
            this.textBox_result.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(819, 66);
            this.label3.TabIndex = 44;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_start_one_number
            // 
            this.button_start_one_number.Location = new System.Drawing.Point(623, 192);
            this.button_start_one_number.Name = "button_start_one_number";
            this.button_start_one_number.Size = new System.Drawing.Size(208, 43);
            this.button_start_one_number.TabIndex = 43;
            this.button_start_one_number.Text = "Запустить проверку конкретного числа";
            this.button_start_one_number.UseVisualStyleBackColor = true;
            this.button_start_one_number.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Количество раундов (по умолчанию log(n))\r\n";
            // 
            // textBox_n_rounds
            // 
            this.textBox_n_rounds.Location = new System.Drawing.Point(400, 192);
            this.textBox_n_rounds.Multiline = true;
            this.textBox_n_rounds.Name = "textBox_n_rounds";
            this.textBox_n_rounds.Size = new System.Drawing.Size(187, 43);
            this.textBox_n_rounds.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Проверяемое на простоту число";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(14, 192);
            this.textBox_p.Multiline = true;
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_p.Size = new System.Drawing.Size(340, 43);
            this.textBox_p.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(28, 102);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(326, 37);
            this.label23.TabIndex = 79;
            this.label23.Text = "Если вы хотите получить случайное простое число, задайте длину этого числа в бита" +
    "х\r\n";
            // 
            // textBox_length_in_bit
            // 
            this.textBox_length_in_bit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_length_in_bit.Location = new System.Drawing.Point(379, 125);
            this.textBox_length_in_bit.Multiline = true;
            this.textBox_length_in_bit.Name = "textBox_length_in_bit";
            this.textBox_length_in_bit.Size = new System.Drawing.Size(74, 21);
            this.textBox_length_in_bit.TabIndex = 78;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(379, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 15);
            this.label24.TabIndex = 80;
            this.label24.Text = "Длина p, бит\r\n";
            // 
            // button_start_random_one_number
            // 
            this.button_start_random_one_number.Location = new System.Drawing.Point(459, 91);
            this.button_start_random_one_number.Name = "button_start_random_one_number";
            this.button_start_random_one_number.Size = new System.Drawing.Size(330, 24);
            this.button_start_random_one_number.TabIndex = 83;
            this.button_start_random_one_number.Text = "Сгенерировать случайное число и проверить его на простоту\r\n";
            this.button_start_random_one_number.UseVisualStyleBackColor = true;
            this.button_start_random_one_number.Click += new System.EventHandler(this.button_start_random_one_number_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 83);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_start_many_iteration
            // 
            this.button_start_many_iteration.Location = new System.Drawing.Point(459, 121);
            this.button_start_many_iteration.Name = "button_start_many_iteration";
            this.button_start_many_iteration.Size = new System.Drawing.Size(330, 24);
            this.button_start_many_iteration.TabIndex = 85;
            this.button_start_many_iteration.Text = "Генерировать числа, пока не найдется простое";
            this.button_start_many_iteration.UseVisualStyleBackColor = true;
            this.button_start_many_iteration.Click += new System.EventHandler(this.button_start_many_iteration_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 28);
            this.button1.TabIndex = 86;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 87;
            this.button2.Text = "Проверить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MillerRabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_start_many_iteration);
            this.Controls.Add(this.button_start_random_one_number);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox_length_in_bit);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox_steps);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_start_one_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_n_rounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_result_wolfram);
            this.Name = "MillerRabin";
            this.Text = "MillerRabin";
            this.Load += new System.EventHandler(this.MillerRabin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_steps;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_result_wolfram;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_start_one_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_n_rounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_length_in_bit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_start_random_one_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start_many_iteration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}