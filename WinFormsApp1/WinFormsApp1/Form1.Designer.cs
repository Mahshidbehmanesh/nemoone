namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtnume1 = new TextBox();
            txtop = new TextBox();
            txtnume2 = new TextBox();
            lblresult = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(96, 58);
            button1.Name = "button1";
            button1.Size = new Size(99, 30);
            button1.TabIndex = 0;
            button1.Text = "Calcalute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(96, 106);
            button2.Name = "button2";
            button2.Size = new Size(91, 30);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(96, 155);
            button3.Name = "button3";
            button3.Size = new Size(91, 31);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtnume1
            // 
            txtnume1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnume1.Location = new Point(12, 7);
            txtnume1.Name = "txtnume1";
            txtnume1.Size = new Size(87, 27);
            txtnume1.TabIndex = 3;
            // 
            // txtop
            // 
            txtop.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtop.Location = new Point(124, 7);
            txtop.Name = "txtop";
            txtop.Size = new Size(39, 27);
            txtop.TabIndex = 4;
            // 
            // txtnume2
            // 
            txtnume2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnume2.Location = new Point(190, 7);
            txtnume2.Name = "txtnume2";
            txtnume2.Size = new Size(93, 27);
            txtnume2.TabIndex = 5;
            // 
            // lblresult
            // 
            lblresult.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblresult.Location = new Point(332, 10);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(73, 21);
            lblresult.TabIndex = 6;
            lblresult.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(298, 15);
            label2.Name = "label2";
            label2.Size = new Size(22, 19);
            label2.TabIndex = 7;
            label2.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(448, 198);
            Controls.Add(label2);
            Controls.Add(lblresult);
            Controls.Add(txtnume2);
            Controls.Add(txtop);
            Controls.Add(txtnume1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtnume1;
        private TextBox txtop;
        private TextBox txtnume2;
        private Label lblresult;
        private Label label2;
    }
}