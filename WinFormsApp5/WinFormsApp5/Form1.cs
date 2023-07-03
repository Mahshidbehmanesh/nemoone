namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] a = new double[4];
            a[0] = Convert.ToDouble(txtbehmanesh.Text);
            a[1] = Convert.ToDouble(txtfadavy.Text);
            a[2] = Convert.ToDouble(txtnamjou.Text);
            a[3] = Convert.ToDouble(txtmusavi.Text);
             foreach (double p in a)
 
            MessageBox.Show(p.ToString(), "contorol");
        }
    }
}