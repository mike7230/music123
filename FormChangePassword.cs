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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void modify_Click( object sender , EventArgs e )
        {
            
            message.Text = Account.ChangePassword( email.Text , password.Text );
            if ( message.Text.Equals( "Success" ) )
                this.Close();
        }

        private void cancel_Click( object sender , EventArgs e )
        {
            this.Close();
        }

        private void FormChangePassword_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                modify_Click( null , null );
        }
    }
}
