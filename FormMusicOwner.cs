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
    public partial class FormMusicOwner : Form
    {
        public FormMusicOwner()
        {
            Music music = new Music();
            string e = music.email;
            InitializeComponent();
            DataTable result = DB.Select(String.Format("Select name,sex,info from account where account.email='{0}'",e));
            if (result.Rows.Count != 0)
            {
                Owner_name.Text = result.Rows[0][0].ToString();
                Owner_sex.Text = result.Rows[0][1].ToString();
                Owner_info.Text = result.Rows[0][2].ToString();
            }
        }
        private void correct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
