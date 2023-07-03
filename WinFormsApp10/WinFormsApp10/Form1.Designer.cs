namespace WinFormsApp10
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
            btn_ok = new Button();
            txt_Nume = new TextBox();
            label1 = new Label();
            txt_Address = new TextBox();
            txt_Age = new TextBox();
            txt_Family = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.Location = new Point(192, 299);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(142, 40);
            btn_ok.TabIndex = 0;
            btn_ok.Text = " Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txt_Nume
            // 
            txt_Nume.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Nume.Location = new Point(240, 37);
            txt_Nume.Multiline = true;
            txt_Nume.Name = "txt_Nume";
            txt_Nume.Size = new Size(138, 35);
            txt_Nume.TabIndex = 1;
            txt_Nume.TextChanged += txt_Nume_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = " Nume:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Address.Location = new Point(240, 194);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(138, 30);
            txt_Address.TabIndex = 3;
            // 
            // txt_Age
            // 
            txt_Age.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Age.Location = new Point(240, 144);
            txt_Age.Multiline = true;
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(138, 31);
            txt_Age.TabIndex = 4;
            // 
            // txt_Family
            // 
            txt_Family.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Family.Location = new Point(240, 90);
            txt_Family.Multiline = true;
            txt_Family.Name = "txt_Family";
            txt_Family.Size = new Size(138, 33);
            txt_Family.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(115, 95);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 6;
            label2.Tag = "Family:";
            label2.Text = "Family:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(115, 144);
            label3.Name = "label3";
            label3.Size = new Size(41, 18);
            label3.TabIndex = 7;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(115, 199);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 8;
            label4.Text = "Address:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 380);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Family);
            Controls.Add(txt_Age);
            Controls.Add(txt_Address);
            Controls.Add(label1);
            Controls.Add(txt_Nume);
            Controls.Add(btn_ok);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private TextBox txt_Nume;
        private Label label1;
        private TextBox txt_Address;
        private TextBox txt_Age;
        private TextBox txt_Family;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}