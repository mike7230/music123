using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void login_Click( object sender , EventArgs e )
        {
            message.Text = Account.Login( email.Text , password.Text );
            if ( message.Text.Equals( "Success" ) )
            {
                this.Close();
                if (Account.name == "")
                    FormMain.main.account.Text = Account.email;
                else
                    FormMain.main.account.Text = Account.name;
            }
            FormMain.main.refreshPlaylist();
        }

        private void forget_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.TopLevel = false;
            formChangePassword.Dock = DockStyle.Fill;
            formChangePassword.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formChangePassword );
            formChangePassword.BringToFront();
            formChangePassword.Show();
        }

        private void register_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            FormRegister formRegister = new FormRegister();
            formRegister.TopLevel = false;
            formRegister.Dock = DockStyle.Fill;
            formRegister.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formRegister );
            formRegister.BringToFront();
            formRegister.Show();
        }

        private void cancel_Click( object sender , EventArgs e )
        {
            this.Close();
        }

        private void FormLogin_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                login_Click( null , null );
        }
    }
}
