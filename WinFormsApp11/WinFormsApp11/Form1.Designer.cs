namespace WinFormsApp11
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
            txt_Y1 = new TextBox();
            txt_X1 = new TextBox();
            txt_X2 = new TextBox();
            txt_Y2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(332, 360);
            button1.Name = "button1";
            button1.Size = new Size(157, 56);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_Y1
            // 
            txt_Y1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Y1.Location = new Point(583, 7);
            txt_Y1.Name = "txt_Y1";
            txt_Y1.Size = new Size(100, 26);
            txt_Y1.TabIndex = 1;
            // 
            // txt_X1
            // 
            txt_X1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_X1.Location = new Point(249, 12);
            txt_X1.Name = "txt_X1";
            txt_X1.Size = new Size(100, 26);
            txt_X1.TabIndex = 2;
            // 
            // txt_X2
            // 
            txt_X2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_X2.Location = new Point(249, 82);
            txt_X2.Name = "txt_X2";
            txt_X2.Size = new Size(100, 26);
            txt_X2.TabIndex = 3;
            txt_X2.TextChanged += textBox3_TextChanged;
            // 
            // txt_Y2
            // 
            txt_Y2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Y2.Location = new Point(583, 87);
            txt_Y2.Name = "txt_Y2";
            txt_Y2.Size = new Size(100, 26);
            txt_Y2.TabIndex = 4;
            txt_Y2.TextChanged += txt_Y2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 15);
            label1.Name = "label1";
            label1.Size = new Size(33, 18);
            label1.TabIndex = 5;
            label1.Text = "X1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(477, 12);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 6;
            label2.Text = "Y1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(175, 90);
            label3.Name = "label3";
            label3.Size = new Size(33, 18);
            label3.TabIndex = 7;
            label3.Text = "X2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(477, 90);
            label4.Name = "label4";
            label4.Size = new Size(34, 18);
            label4.TabIndex = 8;
            label4.Text = "Y2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Y2);
            Controls.Add(txt_X2);
            Controls.Add(txt_X1);
            Controls.Add(txt_Y1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_Y1;
        private TextBox txt_X1;
        private TextBox txt_X2;
        private TextBox txt_Y2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}