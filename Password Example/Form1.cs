namespace Password_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_error.Text = "";
        }

        string username = "Lednar";
        string password = "Admin";

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_username.Text == username && tf_password.Text == password)
            {
                OnSuccessfulLogin();
            }
            else
            {
                lbl_error.Text = "Login Error";
            }
        }

        void OnSuccessfulLogin()
        {

            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}
