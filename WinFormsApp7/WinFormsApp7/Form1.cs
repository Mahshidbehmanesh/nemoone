namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = new string[3];
            a[0] = Convert.ToString(textBox1.Text);
            a[1] = Convert.ToString(textBox2.Text);
            a[2] = Convert.ToString(textBox3.Text);
            foreach (string s in a)
                MessageBox.Show(s.ToString(), "کنترل کتاب");


        }
    }
}