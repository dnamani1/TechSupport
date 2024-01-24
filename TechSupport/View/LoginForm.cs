using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        private readonly IncidentController _incidentController;

         public LoginForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;

            string username = _incidentController.GetUsername();
            string password = _incidentController.GetPassword();

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

        private bool ValidateCredentials(string username, string password)
        {
            return username == usernameTextBox.Text && password == passwordMaskedTextBox.Text;
        }

        private void HandleSuccessfulLogin()
        {
            var mainform = new MainForm();
            mainform.SetController(_incidentController);
            this.Hide();
            var value = mainform.ShowDialog();

            if (value != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

            ClearCredentials();
        }

        private void HandleInvalidLogin()
        {
            ClearCredentials();
            errorMessageLabel.Text = "Invalid Username or Password";
            errorMessageLabel.ForeColor = Color.Red;
            errorMessageLabel.Visible = true;
        }

        private void ClearCredentials()
        {
            usernameTextBox.Clear();
            passwordMaskedTextBox.Clear();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Visible = false;
        }

        private void PasswordMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorMessageLabel.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
