using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cisit
{
    class CisitProgram
    {
        private class Cluster
        {
            private byte atomic_number_of_atoms;
            private int number_of_atoms;
            private int energy_of_cluster;

            public Cluster()
            {
                atomic_number_of_atoms = 40;
                number_of_atoms = 1000;
                energy_of_cluster = 30000;
            }

            public void ChangeParams(byte new_atomic_number_of_atoms, int new_number_of_atoms, int new_energy_of_cluster)
            {
                atomic_number_of_atoms = new_atomic_number_of_atoms;
                number_of_atoms = new_number_of_atoms;
                energy_of_cluster = new_energy_of_cluster;
            }

            public byte Get_atomic_number_of_atoms()
            {
                return atomic_number_of_atoms;
            }

            public int Get_number_of_atoms()
            {
                return number_of_atoms;
            }

            public int Get_energy_of_cluster()
            {
                return energy_of_cluster;
            }
        }

        private Cluster firstCluster = new Cluster();

        public CisitProgram(byte atomic_number_of_atoms, int number_of_atoms, int energy_of_cluster)
        {
            firstCluster.ChangeParams(atomic_number_of_atoms, number_of_atoms, energy_of_cluster);
        }

        public string[] Calculate()
        {
            string[] result = new string[3];
            result[0] = "Calculation completed:";
            result[1] = "Cluster consist of Ar";
            result[2] = "Atomic number Ar = " + Convert.ToString(firstCluster.Get_atomic_number_of_atoms())
                        + ", number of atoms in the cluster " + Convert.ToString(firstCluster.Get_number_of_atoms())
                        + ", energy of cluster" + Convert.ToString(firstCluster.Get_energy_of_cluster())
                        + " eV";
            return result;
        }
    }
}
