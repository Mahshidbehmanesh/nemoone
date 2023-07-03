namespace WinFormsApp2
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 1; i <= 10; i++) 
            if ((i % 2 )!=0)
            {
                listBox2.Items.Add(i);
            }            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 1; i <= 10; i++) 
            if((i % 2) == 0)
            {
                listBox2.Items.Add(i);
            }
                  
        }
    }
}