using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayers;

namespace Moyo_Vincent_PracticalAssignment
{
    //declare delegate
    public delegate void getClientDetails();
    public partial class Login : Form
    {
        //declare event
        public event getClientDetails onClientDetails;

        //Declarations
        Client clientClass = new Client();
        MenuForm MenuForm = new MenuForm();
        Dictionary<string, string> loginList = new Dictionary<string, string>();
        string clientUsername;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            // Condition to check if all textboxes are filled
            if (UsernameTxt.Text == string.Empty || PasswordTxt.Text == string.Empty)
            {
                onClientDetails += new getClientDetails(loginTextboxFail);
                onClientDetails.Invoke();

            }
            else
            {
                username = UsernameTxt.Text;
                password = PasswordTxt.Text;
                bool loginn = false;
                foreach (var item in loginList)
                {
                    if (username == item.Key && password == item.Value)
                    {
                        loginn = true;
                    }

                }
                if (loginn)
                {
                    clientUsername = username;
                    //invoke event that displays success message
                    onClientDetails += new getClientDetails(loginSuccess);
                    onClientDetails.Invoke();

                    MenuForm.Show();
                    this.Hide();
                }
                else
                {
                    //invoke event that displays failed message
                    onClientDetails += new getClientDetails(loginFailed);
                    onClientDetails.Invoke();
                }
            }

            

        }
        private void Label3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginList = clientClass.GetLoginDetails();
        }


        private void UsernameTxt_Click(object sender, EventArgs e)
        {
            //clear out the textbox once you click on it
            UsernameTxt.Text = "";
            UsernameTxt.ForeColor = Color.Black;
        }

        private void PasswordBTN_Click(object sender, EventArgs e)
        {
            //clear out the textbox once you click on it
            PasswordTxt.Text = "";
            PasswordTxt.ForeColor = Color.Black;
            PasswordTxt.UseSystemPasswordChar = true;

        }
         
        public void loginTextboxFail()
        {
            MessageBox.Show("Please fill in the textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void loginFailed()
        {
            MessageBox.Show("Incorrect details, Your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void loginSuccess()
        {
            MessageBox.Show("Welcome " + clientUsername + " to Smart Home System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
