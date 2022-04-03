namespace Mubarakov_4
{
    partial class FastPow
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
            this.button_FastPow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_modulus = new System.Windows.Forms.TextBox();
            this.button_FastModPow = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_bi = new System.Windows.Forms.TextBox();
            this.textBox_b_binary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ai_mod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритм быстрого возведения числа а в степень b";
            // 
            // button_FastPow
            // 
            this.button_FastPow.Location = new System.Drawing.Point(205, 140);
            this.button_FastPow.Name = "button_FastPow";
            this.button_FastPow.Size = new System.Drawing.Size(149, 25);
            this.button_FastPow.TabIndex = 9;
            this.button_FastPow.Text = "Возвести a в степень b";
            this.button_FastPow.UseVisualStyleBackColor = true;
            this.button_FastPow.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Натуральное число b";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(274, 82);
            this.textBox_b.Multiline = true;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(264, 22);
            this.textBox_b.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Натуральное число a";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(12, 82);
            this.textBox_a.Multiline = true;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(256, 50);
            this.textBox_a.TabIndex = 5;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 377);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(776, 61);
            this.textBox_result.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Модуль m";
            // 
            // textBox_modulus
            // 
            this.textBox_modulus.Location = new System.Drawing.Point(544, 82);
            this.textBox_modulus.Multiline = true;
            this.textBox_modulus.Name = "textBox_modulus";
            this.textBox_modulus.Size = new System.Drawing.Size(230, 50);
            this.textBox_modulus.TabIndex = 32;
            // 
            // button_FastModPow
            // 
            this.button_FastModPow.Location = new System.Drawing.Point(398, 140);
            this.button_FastModPow.Name = "button_FastModPow";
            this.button_FastModPow.Size = new System.Drawing.Size(227, 25);
            this.button_FastModPow.TabIndex = 35;
            this.button_FastModPow.Text = "Возвести a в степень b по модулю m\r\n";
            this.button_FastModPow.UseVisualStyleBackColor = true;
            this.button_FastModPow.Click += new System.EventHandler(this.button_FastModPow_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Шаг";
            // 
            // textBox_step
            // 
            this.textBox_step.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_step.Location = new System.Drawing.Point(12, 195);
            this.textBox_step.Multiline = true;
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_step.Size = new System.Drawing.Size(60, 128);
            this.textBox_step.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ai";
            // 
            // textBox_ai
            // 
            this.textBox_ai.Location = new System.Drawing.Point(78, 195);
            this.textBox_ai.Multiline = true;
            this.textBox_ai.Name = "textBox_ai";
            this.textBox_ai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ai.Size = new System.Drawing.Size(474, 128);
            this.textBox_ai.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "текущий бит b";
            // 
            // textBox_bi
            // 
            this.textBox_bi.Location = new System.Drawing.Point(730, 195);
            this.textBox_bi.Multiline = true;
            this.textBox_bi.Name = "textBox_bi";
            this.textBox_bi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_bi.Size = new System.Drawing.Size(44, 128);
            this.textBox_bi.TabIndex = 43;
            // 
            // textBox_b_binary
            // 
            this.textBox_b_binary.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_b_binary.Location = new System.Drawing.Point(274, 110);
            this.textBox_b_binary.Multiline = true;
            this.textBox_b_binary.Name = "textBox_b_binary";
            this.textBox_b_binary.ReadOnly = true;
            this.textBox_b_binary.Size = new System.Drawing.Size(264, 22);
            this.textBox_b_binary.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "ai % modulus";
            // 
            // textBox_ai_mod
            // 
            this.textBox_ai_mod.Location = new System.Drawing.Point(571, 195);
            this.textBox_ai_mod.Multiline = true;
            this.textBox_ai_mod.Name = "textBox_ai_mod";
            this.textBox_ai_mod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ai_mod.Size = new System.Drawing.Size(136, 130);
            this.textBox_ai_mod.TabIndex = 47;
            // 
            // FastPow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_ai_mod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_b_binary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_bi);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ai);
            this.Controls.Add(this.button_FastModPow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_modulus);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_FastPow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label1);
            this.Name = "FastPow";
            this.Text = "FastPow";
            this.Load += new System.EventHandler(this.FastPow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_FastPow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_modulus;
        private System.Windows.Forms.Button button_FastModPow;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_bi;
        private System.Windows.Forms.TextBox textBox_b_binary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ai_mod;
    }
}