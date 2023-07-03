namespace WinFormsApp13
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
            txtnum1 = new TextBox();
            txtop = new TextBox();
            txtnum2 = new TextBox();
            label1 = new Label();
            lblresult = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtnum1
            // 
            txtnum1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum1.Location = new Point(0, 6);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(88, 26);
            txtnum1.TabIndex = 0;
            // 
            // txtop
            // 
            txtop.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtop.Location = new Point(106, 6);
            txtop.Name = "txtop";
            txtop.Size = new Size(42, 26);
            txtop.TabIndex = 1;
            // 
            // txtnum2
            // 
            txtnum2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtnum2.Location = new Point(167, 6);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(94, 26);
            txtnum2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(288, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "=";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblresult
            // 
            lblresult.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblresult.Location = new Point(368, 9);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(59, 23);
            lblresult.TabIndex = 4;
            lblresult.Text = "Result";
            lblresult.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(115, 147);
            button1.Name = "button1";
            button1.Size = new Size(191, 37);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(115, 211);
            button2.Name = "button2";
            button2.Size = new Size(191, 39);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(115, 276);
            button3.Name = "button3";
            button3.Size = new Size(191, 39);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(455, 329);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblresult);
            Controls.Add(label1);
            Controls.Add(txtnum2);
            Controls.Add(txtop);
            Controls.Add(txtnum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtop;
        private TextBox txtnum2;
        private Label label1;
        private Label lblresult;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}