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
    public partial class FormMusicInfo : Form
    {
        public FormMusicInfo()
        {
            InitializeComponent();
            Music music = new Music();
            Singer.Text = music.singer;
            Type.Text = music.tag;
            Info.Text = music.info;
        }

        private void correct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
