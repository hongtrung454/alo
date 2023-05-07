using pbl3.BLL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (Account_BLL.Instance.CheckAccount(txtUsername.Text, txtPassword.Text))
            {
                Account a = Account_BLL.Instance.GetAccountByUserName(txtUsername.Text);
                if (a.Type == 0) // 0: Admin, 1: User
                {
                    FAdmin f = new FAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else 
                {
                FUser f = new FUser(txtUsername.Text);
                this.Hide();
                f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }
            //
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FRegister f = new FRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the program?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void NoShowPW1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                ShowPW1.BringToFront();
                txtPassword.PasswordChar = '*';
            }

        }
        private void ShowPW1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                NoShowPW1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
        //
    }
}
