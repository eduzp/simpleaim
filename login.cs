using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UNC_FF
{
    public partial class LoginPainel : Form
    {
        public LoginPainel()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        public static api KeyAuthApp = new api(
            name: "UNC FF", // App name
            ownerid: "x65xDpT4Jf", // Account ID
            secret: "2de85893630ad44afc724cb4e1ca6c45babf3f98a06ba8cb589b7d091b8982ba",
            version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButon_Click_1(object sender, EventArgs e)
        {
            {
                KeyAuthApp.login(UsuarioLogin.Text, SenhaLogin.Text);
                if (KeyAuthApp.response.success)
                {
                    LabelVerificação.Text = KeyAuthApp.response.message;
                    MainPainel main = new MainPainel();
                    main.StartPosition = FormStartPosition.Manual;
                    main.Location = this.Location;
                    main.Show();
                    this.Hide();
                }
                else
                {
                    LabelVerificação.Text = KeyAuthApp.response.message;
                }
            }
        }
    }
}
