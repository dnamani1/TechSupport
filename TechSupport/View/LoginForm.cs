using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Represents a login form for user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the LoginForm class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Handles the Click event of the Login button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;

            IncidentController incidentController = new IncidentController();
            {
                var username = incidentController.GetUsername();
                var password = incidentController.GetPassword();

                bool credentialsValid = ValidateCredentials(username, password);

                if (credentialsValid)
                {
                    HandleSuccessfulLogin();
                }
                else
                {
                    HandleInvalidLogin();
                }
            }
        }
        /// <summary>
        /// Validates the credentials entered by the user.
        /// </summary>
        /// <param name="username">The expected username.</param>
        /// <param name="password">The expected password.</param>
        /// <returns>true if credentials are valid; otherwise, false.</returns>
        private bool ValidateCredentials(string username, string password)
        {
            return username == usernameTextBox.Text && password == passwordMaskedTextBox.Text;
        }

        /// <summary>
        /// Handles successful login by the user.
        /// </summary>
        private void HandleSuccessfulLogin()
        {

            this.Hide();
            var mainForm = new MainForm();
            var dialogResult = mainForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                this.Show();
                ClearCredentials();
            }
            else
            {
 
                this.Close();
            }
        }

        /// <summary>
        /// Handles invalid login attempt.
        /// </summary>
        private void HandleInvalidLogin()
        {
            ClearCredentials();
            errorMessageLabel.Text = "Invalid Username or Password";
            errorMessageLabel.ForeColor = Color.Red;
            errorMessageLabel.Visible = true;
        }

        /// <summary>
        /// Clears the credential inputs.
        /// </summary>
        private void ClearCredentials()
        {
            usernameTextBox.Clear();
            passwordMaskedTextBox.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the UsernameTextBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
        }

        /// <summary>
        /// Handles the MaskInputRejected event of the PasswordMaskedTextBox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MaskInputRejectedEventArgs"/> instance containing the event data.</param>
        private void PasswordMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorMessageLabel.Visible = false;
        }
    }
}
