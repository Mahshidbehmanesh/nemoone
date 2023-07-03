namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X1 = Convert.ToDouble(txt_X1.Text);
            double X2 = Convert.ToDouble(txt_X2.Text);
            double Y1 = Convert.ToDouble(txt_Y1.Text);
            double Y2 = Convert.ToDouble(txt_Y2.Text);
            double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            MessageBox.Show(result.ToString());
        }

        private void txt_Y2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}