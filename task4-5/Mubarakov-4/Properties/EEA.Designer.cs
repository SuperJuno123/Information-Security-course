namespace Mubarakov_4
{
    partial class EEA
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
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ai_prev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ai_next = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_xi_prev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_yi_prev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_yi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_xi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_result_x = new System.Windows.Forms.TextBox();
            this.textBox_result_y = new System.Windows.Forms.TextBox();
            this.textBox_result_G = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_result_a = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_result_b = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(53, 76);
            this.textBox_a.Multiline = true;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(311, 43);
            this.textBox_a.TabIndex = 0;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Натуральное число a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Натуральное число b";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(370, 76);
            this.textBox_b.Multiline = true;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(329, 43);
            this.textBox_b.TabIndex = 2;
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox_b_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Расширенный алгоритм Евклида - алгоритм, который позволит найти для натуральных ч" +
    "исел a и b коэффициенты x, y (коэффициенты Безу) такие, что ax+by=G, где G - НОД" +
    "(a, b)\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ai-1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_ai_prev
            // 
            this.textBox_ai_prev.Location = new System.Drawing.Point(72, 181);
            this.textBox_ai_prev.Multiline = true;
            this.textBox_ai_prev.Name = "textBox_ai_prev";
            this.textBox_ai_prev.Size = new System.Drawing.Size(86, 128);
            this.textBox_ai_prev.TabIndex = 6;
            this.textBox_ai_prev.TextChanged += new System.EventHandler(this.textBox_ai_prev_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ai";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_ai
            // 
            this.textBox_ai.Location = new System.Drawing.Point(176, 181);
            this.textBox_ai.Multiline = true;
            this.textBox_ai.Name = "textBox_ai";
            this.textBox_ai.Size = new System.Drawing.Size(95, 128);
            this.textBox_ai.TabIndex = 8;
            this.textBox_ai.TextChanged += new System.EventHandler(this.textBox_ai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ai+1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_ai_next
            // 
            this.textBox_ai_next.Location = new System.Drawing.Point(291, 181);
            this.textBox_ai_next.Multiline = true;
            this.textBox_ai_next.Name = "textBox_ai_next";
            this.textBox_ai_next.Size = new System.Drawing.Size(95, 128);
            this.textBox_ai_next.TabIndex = 10;
            this.textBox_ai_next.TextChanged += new System.EventHandler(this.textBox_ai_next_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "q";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(411, 181);
            this.textBox_q.Multiline = true;
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(95, 128);
            this.textBox_q.TabIndex = 12;
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_q_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "xi-1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_xi_prev
            // 
            this.textBox_xi_prev.Location = new System.Drawing.Point(524, 181);
            this.textBox_xi_prev.Multiline = true;
            this.textBox_xi_prev.Name = "textBox_xi_prev";
            this.textBox_xi_prev.Size = new System.Drawing.Size(95, 128);
            this.textBox_xi_prev.TabIndex = 14;
            this.textBox_xi_prev.TextChanged += new System.EventHandler(this.textBox_xi_prev_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "yi-1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_yi_prev
            // 
            this.textBox_yi_prev.Location = new System.Drawing.Point(638, 181);
            this.textBox_yi_prev.Multiline = true;
            this.textBox_yi_prev.Name = "textBox_yi_prev";
            this.textBox_yi_prev.Size = new System.Drawing.Size(95, 128);
            this.textBox_yi_prev.TabIndex = 16;
            this.textBox_yi_prev.TextChanged += new System.EventHandler(this.textBox_yi_prev_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(865, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "yi";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_yi
            // 
            this.textBox_yi.Location = new System.Drawing.Point(865, 181);
            this.textBox_yi.Multiline = true;
            this.textBox_yi.Name = "textBox_yi";
            this.textBox_yi.Size = new System.Drawing.Size(95, 128);
            this.textBox_yi.TabIndex = 20;
            this.textBox_yi.TextChanged += new System.EventHandler(this.textBox_yi_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(748, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "xi";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_xi
            // 
            this.textBox_xi.Location = new System.Drawing.Point(751, 181);
            this.textBox_xi.Multiline = true;
            this.textBox_xi.Name = "textBox_xi";
            this.textBox_xi.Size = new System.Drawing.Size(95, 128);
            this.textBox_xi.TabIndex = 18;
            this.textBox_xi.TextChanged += new System.EventHandler(this.textBox_xi_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Результат";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox_result_x
            // 
            this.textBox_result_x.Location = new System.Drawing.Point(50, 381);
            this.textBox_result_x.Multiline = true;
            this.textBox_result_x.Name = "textBox_result_x";
            this.textBox_result_x.Size = new System.Drawing.Size(144, 41);
            this.textBox_result_x.TabIndex = 22;
            this.textBox_result_x.TextChanged += new System.EventHandler(this.textBox_result_x_TextChanged);
            // 
            // textBox_result_y
            // 
            this.textBox_result_y.Location = new System.Drawing.Point(454, 381);
            this.textBox_result_y.Multiline = true;
            this.textBox_result_y.Name = "textBox_result_y";
            this.textBox_result_y.Size = new System.Drawing.Size(130, 41);
            this.textBox_result_y.TabIndex = 24;
            this.textBox_result_y.TextChanged += new System.EventHandler(this.textBox_result_y_TextChanged);
            // 
            // textBox_result_G
            // 
            this.textBox_result_G.Location = new System.Drawing.Point(820, 381);
            this.textBox_result_G.Multiline = true;
            this.textBox_result_G.Name = "textBox_result_G";
            this.textBox_result_G.Size = new System.Drawing.Size(105, 41);
            this.textBox_result_G.TabIndex = 25;
            this.textBox_result_G.TextChanged += new System.EventHandler(this.textBox_result_G_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "y";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(513, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "x";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(851, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "НОД(a, b)";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(314, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "a";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBox_result_a
            // 
            this.textBox_result_a.Location = new System.Drawing.Point(219, 381);
            this.textBox_result_a.Multiline = true;
            this.textBox_result_a.Name = "textBox_result_a";
            this.textBox_result_a.Size = new System.Drawing.Size(189, 41);
            this.textBox_result_a.TabIndex = 29;
            this.textBox_result_a.TextChanged += new System.EventHandler(this.textBox_result_a_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 395);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "×";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(590, 395);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "×";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(699, 365);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "b";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // textBox_result_b
            // 
            this.textBox_result_b.Location = new System.Drawing.Point(609, 381);
            this.textBox_result_b.Multiline = true;
            this.textBox_result_b.Name = "textBox_result_b";
            this.textBox_result_b.Size = new System.Drawing.Size(165, 41);
            this.textBox_result_b.TabIndex = 33;
            this.textBox_result_b.TextChanged += new System.EventHandler(this.textBox_result_b_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(422, 395);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "+";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(789, 395);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "=";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textBox_step
            // 
            this.textBox_step.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_step.Location = new System.Drawing.Point(6, 181);
            this.textBox_step.Multiline = true;
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(60, 128);
            this.textBox_step.TabIndex = 37;
            this.textBox_step.TextChanged += new System.EventHandler(this.textBox_step_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 162);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "Шаг";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // EEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox_result_b);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_result_a);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_result_G);
            this.Controls.Add(this.textBox_result_y);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_result_x);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_yi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_xi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_yi_prev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_xi_prev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ai_next);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ai_prev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_a);
            this.Name = "EEA";
            this.Text = "Расширенный алгоритм Евклида";
            this.Load += new System.EventHandler(this.EEA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ai_prev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ai_next;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_xi_prev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_yi_prev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_yi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_xi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_result_x;
        private System.Windows.Forms.TextBox textBox_result_y;
        private System.Windows.Forms.TextBox textBox_result_G;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_result_a;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_result_b;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label22;
    }
}