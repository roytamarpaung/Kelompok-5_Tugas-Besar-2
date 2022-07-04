using System.ComponentModel;

namespace APL
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "label - username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "label - fullname";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "label - email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "label - user info";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "label - saldo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "label - pengeluaran";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "label - pemasukan";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(136, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(136, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(136, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(31, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 160);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "label - balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(381, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "label - tarik saldo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(381, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "label - topup";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        protected System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}