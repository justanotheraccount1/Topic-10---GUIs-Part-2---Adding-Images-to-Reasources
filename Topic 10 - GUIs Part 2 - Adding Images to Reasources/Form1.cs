using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___GUIs_Part_2___Adding_Images_to_Reasources
{
    public partial class FormAddResouces : Form
    {
        public FormAddResouces()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioAwake;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioSleep;
        }
    }
}
