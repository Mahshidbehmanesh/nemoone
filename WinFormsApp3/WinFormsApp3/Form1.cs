namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, m;
            for (i = 1; i <= 4; i++) ;
            {
                for (j = 1; j <= 4; j++) ;
                {
                    m = i * j;
                    listView1.Items.Add(m.ToString());

                }
            }

        
        {
            
            }
        }
    }
}