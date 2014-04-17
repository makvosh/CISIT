using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace cisit
{
    public partial class fMain : Form
    {
        public byte atomic_number_of_atom;
        public int number_of_atoms;
        public int energy_of_cluster;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            cbDefaultParams.SelectedIndex = 0;
        }

        private void cbDefaultParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDefaultParams.SelectedIndex)
            {
                case 0:
                    atomic_number_of_atom = 40;
                    number_of_atoms = 1000;
                    energy_of_cluster = 20000;
                    break;
                case 1:
                    break;
            }
        }

        private void bcalculate_Click(object sender, EventArgs e)
        {
            tStripStatusLabel.BackColor = Color.Yellow;                                                                             //Yellow time
            tsslStatus.Text = "Calculating...";

            CisitProgram CisitCalculation = new CisitProgram(atomic_number_of_atom, number_of_atoms, energy_of_cluster);            //create Main Class
            rTBResult.Lines = CisitCalculation.Calculate();                                                                         //calculating

            Thread.Sleep(500);                                                                                                      //pause

            tStripStatusLabel.BackColor = Color.LimeGreen;                                                                          //Green time again
            tsslStatus.Text = "Finished!";
            timerSetReady.Enabled = true;  //timer for Finished! -> Ready
        }

        private void timerSetReady_Tick(object sender, EventArgs e)
        {
            if (tsslStatus.Text == "Finished") 
            {
                tsslStatus.Text = "Ready";
                timerSetReady.Enabled = false;
            }
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            tStripStatusLabel.BackColor = Color.Yellow;
        }
    }
}
