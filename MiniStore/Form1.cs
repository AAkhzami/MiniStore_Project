using MiniStore.Global;
using MiniStoreDB_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MiniStore
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ClosePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Move to Create New User Panel
        private void lblCreateNewUser_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pCreateNewUser.Visible = true;
            txtNewUserName.Focus();
        }

        // Move back to Login Panel
        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            pCreateNewUser.Visible = false;
            pLogin.Visible = true;
            txtUserName.Focus();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtNewUserName.Text.Trim();
            string password = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsUsers.IsUserNameExist(username))
            {
                MessageBox.Show($"User Name '{username}' was exist !","Not Allow",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return ;
            }

            clsUsers newUser = new clsUsers();
            newUser.UserName = username;

            string hashedPassword = ComputeHash(password);
            newUser.Password = hashedPassword;
            
            newUser.IsActive = true;

            if (newUser.Save())
            {
                MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = username;
                txtPassword.Text = password;

                clsCurrentUser.CurrentUser = newUser;
                clsCurrentUser.CurrentUser.Password = password;

                pCreateNewUser.Visible = false;
                pLogin.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            string password = txtPassword.Text.Trim();
            string hashedPassword = ComputeHash(password);

            int userID = clsUsers.IsValidUser(txtUserName.Text.Trim(), hashedPassword);
            if (userID > 0)
            {
                clsUsers currentUser = clsUsers.Find(userID);

                if (currentUser.IsActive == false)
                {
                    MessageBox.Show("This user account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"Login successful. UserName: {currentUser.UserName} and Password: {password}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                clsCurrentUser.CurrentUser = currentUser;
                clsCurrentUser.CurrentUser.Password = password;

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
