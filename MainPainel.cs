using Guna.UI2.WinForms;
using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UNC_FF
{
    public partial class MainPainel : Form
    {
        public MainPainel()
        {
            InitializeComponent();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPainel_Load(object sender, EventArgs e)
        {

        }

        private void VisualLogo_Click(object sender, EventArgs e)
        {
            VisualPainel main = new VisualPainel();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = this.Location;
            main.Show();
            this.Hide();
        }

        Mem memory = new Mem();
        private async void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (AimbotHeadCheck.Checked)
                {
                    memory.OpenProcess("HD-Player"); //Process

                    var Scan = await memory.AoBScan("", true, true); //Scan Array Of Bytes: Relacionado a Memory da Mira/Entity Location
                    {
                        foreach (var current in Scan)
                        {
                            Int64 rep1 = current + ; //Offset Localização Mira
                            Int64 rep2 = current + ; //Offset Localização Entity
                            ;

                            var Readmem = memory.ReadMemory<int>(rep1.ToString("X"));

                            memory.WriteMemory(rep2.ToString("X"), "int", Readmem.ToString());
                        }
                    }


                    status.Text = " INJETADO ";


                    Console.Beep();
                }
                else
                    Console.Beep();
            }
        }

        private async void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            {
                if (AimbotNeckCheck.Checked)
                {
                    memory.OpenProcess("HD-Player");

                    var Scan = await memory.AoBScan("", true, true);
                    {
                        foreach (var current in Scan)
                        {
                            Int64 rep1 = current + ; //Offset Diferente pois neck < head = Offset neck menor por representar o pescoço
                            Int64 rep2 = current + ;
                            ;

                            var Readmem = memory.ReadMemory<int>(rep1.ToString("X"));

                            memory.WriteMemory(rep2.ToString("X"), "int", Readmem.ToString());
                        }
                    }


                    status.Text = " INJETADO ";


                    Console.Beep();
                }
                else
                    Console.Beep();
            }
        }
    }
}
