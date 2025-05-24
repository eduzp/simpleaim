using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNC_FF
{
    public partial class VisualPainel : Form
    {
        public VisualPainel()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VisualPainel_Load(object sender, EventArgs e)
        {

        }

        private void AimbotLogo_Click(object sender, EventArgs e)
        {
            MainPainel main = new MainPainel();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }
    }
}
