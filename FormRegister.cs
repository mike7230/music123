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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void register_Click( object sender , EventArgs e )
        {
            message.Text = Account.Register( email.Text , password.Text );
            if ( message.Text.Equals( "Success" ) )
                this.Close();
        }

        private void cancel_Click( object sender , EventArgs e )
        {
            this.Close();
        }

        private void FormRegister_KeyDown( object sender , KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                register_Click( null , null );
        }
    }
}
