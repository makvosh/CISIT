using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CisitProgram CisitCalculation = new CisitProgram(atomic_number_of_atom, number_of_atoms, energy_of_cluster);
            rTBResult.Lines = CisitCalculation.Calculate();
        }
    }
}
