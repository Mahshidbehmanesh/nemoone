namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_Nume.Text != "")
            { 
                string txt = txt_Nume.Text;
                MessageBox.Show(txt);
            }
            else
            {
                MessageBox.Show("نام وارد نشده");
            }
            


        }

        private void txt_Nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}