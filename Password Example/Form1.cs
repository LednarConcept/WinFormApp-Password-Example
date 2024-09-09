namespace Password_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_error.Text = ""; // Clear the login error text
        }

        string username = "Lednar"; // Username to login with
        string password = "Admin"; // Password to login with

        private void button1_Click(object sender, EventArgs e)
        {
            if (tf_username.Text == username && tf_password.Text == password)
            {
                OnSuccessfulLogin(); // Ctrl+click this to see what it does
            }
            else
            {
                lbl_error.Text = "Login Error"; // If the login credentials are incorrect
            }
        }

        void OnSuccessfulLogin()
        {
            Form Form2 = new Form2(); // create our game window
            Form2.Show(); // show the game window
            this.Hide(); // hide the login window
        }
    }
}
