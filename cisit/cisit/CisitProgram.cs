using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cisit
{
    class CisitProgram
    {
        private class Ion
        {
            public double elcharge = 1.60217656535*Math.Pow(10.0,-19.0); //constant, sorry for not CONST
            private byte atomic_number;
            private sbyte charge;
            private double mass;
            private double radius;
            private double speed_x, speed_y, speed_z;
            private double energy; //eV

            public Ion()
            {
                atomic_number = 18; //on the periodic table
                charge = 1; //electrons as units
                mass = 39.948; //amu units
                energy = 20000;
            }
            
            public void ChangeParams(byte atomic_number1, sbyte charge1, double mass1)
            {
                atomic_number = atomic_number1;
                charge = charge1;
                mass = mass1;
            }
                //All methods return values in SI units
            public byte Get_atomic_number()
            {       
                return atomic_number;
            }
            public sbyte Get_charge()
            {
                return charge;
            }
            public double Get_mass()
            {
                return mass*1.6605402*Math.Pow(10.0, -27.0);
            }
            public double Get_energy()
            {
                return energy * elcharge;
            }
        }
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

        //private Cluster firstCluster = new Cluster();
        private Ion Ion1 = new Ion();
        private Ion Ion2 = new Ion();

        public CisitProgram(byte atomic_number_of_atoms, int number_of_atoms, int energy_of_cluster)
        {
            //firstCluster.ChangeParams(atomic_number_of_atoms, number_of_atoms, energy_of_cluster);
            Ion1.ChangeParams(18, 1, 39.948);
            Ion2.ChangeParams(18, 1, 39.948);
        }

        private double CalcDimensionless_energy()
        {
            byte Z1 = Ion1.Get_atomic_number();
            byte Z2 = Ion2.Get_atomic_number();
            double m1 = Ion1.Get_mass();
            double m2 = Ion2.Get_mass();
            double e2 = Ion1.elcharge * Ion1.elcharge;
            double a0 = 0.529*Math.Pow(10.0, -11.0); //meters
            double af = 0.8853 * a0 * (Math.Pow(Z1, 2 / 3) + Math.Pow(Z2, 2 / 3)); //from potential Lindhardt
            double E = Ion1.Get_energy();

            return (af * m2 * E) / (Z1 * Z2 * e2 * (m1 + m2));  //e2 = e^2, af - radius of the Thomas-Fermi screening
        }

        private double CalcMaxTransfElastic_energy() //Maximal transfer energy in elastic collision: Tm = 4*E*m1*m2*(m1+m2)^(-2) 
        {
            double m1 = Ion1.Get_mass();
            double m2 = Ion2.Get_mass();
            double E = Ion1.Get_energy();
            return 4 * E * m1 * m2 * Math.Pow((m1 + m2), -2); 
        }

        public string[] Calculate()
        {   
            string[] result = new string[1];
            result[0] = "Dimensionless energy: " + Convert.ToString(CalcDimensionless_energy());
            /*result[1] = "Cluster consist of Ar";
            result[2] = "Atomic number Ar = " + Convert.ToString(firstCluster.Get_atomic_number_of_atoms())
                        + ", number of atoms in the cluster " + Convert.ToString(firstCluster.Get_number_of_atoms())
                        + ", energy of cluster" + Convert.ToString(firstCluster.Get_energy_of_cluster())
                        + " eV";
            return result;*/
            return result;
        }
    }
}
