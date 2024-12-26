using Vivs_Ebay.Utilities;

namespace Vivs_Ebay.Views
{
    public partial class FormLogin : Form
    {
        private Login loginHelper = new Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonGuestLogin_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(isGuest: true, username: null);
            formSearch.Show();
            this.Hide();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (checkBoxNewUser.Checked && checkBoxReturning.Checked)
            {
                MessageBox.Show("You can't have both boxes checked. Please try again.");
            }

            else if (checkBoxReturning.Checked)
            {
                bool isAuthenticated = loginHelper.AuthenticateUser(username, password);
                if (isAuthenticated)
                {
                    MessageBox.Show("Login successful!");
                    // Pass the username to the next form
                    FormSearch formSearch = new FormSearch(isGuest: false, username: username);
                    formSearch.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            else if (checkBoxNewUser.Checked)
            {
                bool isRegistered = loginHelper.RegisterUser(username, password);
                if (isRegistered)
                {
                    MessageBox.Show("Registration successful!");
                    // Pass the username to the next form
                    FormSearch formSearch = new FormSearch(isGuest: false, username: username);
                    formSearch.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("There was an error. Please try again.");
            }
        }

    }
}
