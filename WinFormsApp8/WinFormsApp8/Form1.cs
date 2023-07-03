namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i =30; i<=60; i++)
            {
                if ((i % 3) == 0) 
                listBox1.Items.Add(i);
            }
        }
    }
}