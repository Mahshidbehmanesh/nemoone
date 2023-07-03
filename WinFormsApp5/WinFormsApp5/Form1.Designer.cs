namespace WinFormsApp5
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
            label1 = new Label();
            txtfadavy = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtbehmanesh = new TextBox();
            textBox2 = new TextBox();
            txtnamjou = new TextBox();
            txtmusavi = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 64);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 0;
            label1.Text = "مهشید بهمنش";
            // 
            // txtfadavy
            // 
            txtfadavy.BackColor = Color.FromArgb(192, 255, 255);
            txtfadavy.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtfadavy.Location = new Point(333, 119);
            txtfadavy.Name = "txtfadavy";
            txtfadavy.Size = new Size(100, 23);
            txtfadavy.TabIndex = 1;
            txtfadavy.Text = "مونا  فدوی";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 181);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "فرح نامجو";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(301, 232);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 3;
            label4.Text = " رضا موسوی";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(73, 283);
            button1.Name = "button1";
            button1.Size = new Size(235, 37);
            button1.TabIndex = 4;
            button1.Text = " ثبت نمرات";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbehmanesh
            // 
            txtbehmanesh.Location = new Point(51, 65);
            txtbehmanesh.Name = "txtbehmanesh";
            txtbehmanesh.Size = new Size(178, 23);
            txtbehmanesh.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 6;
            // 
            // txtnamjou
            // 
            txtnamjou.Location = new Point(51, 182);
            txtnamjou.Name = "txtnamjou";
            txtnamjou.Size = new Size(178, 23);
            txtnamjou.TabIndex = 7;
            // 
            // txtmusavi
            // 
            txtmusavi.Location = new Point(51, 232);
            txtmusavi.Name = "txtmusavi";
            txtmusavi.Size = new Size(178, 23);
            txtmusavi.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(283, 18);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 9;
            label5.Text = " نمرات دانشجویان";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(513, 385);
            Controls.Add(label5);
            Controls.Add(txtmusavi);
            Controls.Add(txtnamjou);
            Controls.Add(textBox2);
            Controls.Add(txtbehmanesh);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtfadavy);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtfadavy;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtbehmanesh;
        private TextBox textBox2;
        private TextBox txtnamjou;
        private TextBox txtmusavi;
        private Label label5;
    }
}