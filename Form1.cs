namespace DIgitalDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.Hide();
            LoginPanel.Show();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.Show();
            LoginPanel.Hide();
        }

        private void SubmitLoginButton_Click(object sender, EventArgs e)
        {
            var username = LoginUserName.Text.Trim();
            var password = LoginPassword.Text.Trim();
            //Handle the Login Logic and redirect to the MainForm  
            //Send the User As Parameter with the MainForm 

            MessageBox.Show("Incorrect Credentials  ");
            var mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void SubmitSignUpButton_Click(object sender, EventArgs e)
        {
            var name = NameBox.Text.Trim();
            var username = SIngUpUsername.Text.Trim();
            var password = SignUpPassword.Text.Trim();
            //Handle the SignUp Login  then redirect to Main For Or  Show the MessageBox 

            MessageBox.Show("User Already Exists  ");

            var mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
