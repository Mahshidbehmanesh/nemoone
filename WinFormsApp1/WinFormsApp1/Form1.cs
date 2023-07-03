using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double num1, num2;
                string op;
                num1 = Convert.ToDouble(txtnume1.Text);
                op = txtop.Text;
                num2 = Convert.ToDouble(txtnume2.Text);
                switch (op)
                {
                    case "+": lblresult.Text = Convert.ToString(num1 + num2); break;
                    case "-": lblresult.Text = Convert.ToString(num1 - num2); break;
                    case "*": lblresult.Text = Convert.ToString(num1 * num2); break;
                    case "/":
                        lblresult.Text = Convert.ToString(num1 / num2); break;
                    defult: lblresult.Text = "invalid Empty";

                }
                Catch
                 {
                    MessageBox.Show("عملیات با خطا مواجه شد " و "اخطار");

                }

                private void button2_Click(object sender, EventArgs e)
                {
                    txtnume1.Text = "";
                    txtop.Text = "";
                    txtnume2.Text = "";
                    lblresult.Text = "";
                }

                private void button3_Click(object sender, EventArgs e)
                {
                    Application.Exit();
                }
            }
}
    }