using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_Szilagyi_Dominik_wpf
{
     public class Fuvar
    {
        int taxi_id;
        string indulas;
        int idotartam;
        double tavolsag;
        double viteldij;
        double borravalo;
        string fizetes_modja;


        public Fuvar(int taxi_id, string indulas, int idotartam, double tavolsag, double viteldij, double borravalo, string fizetes_modja)
        {
            this.taxi_id = taxi_id;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetes_modja = fizetes_modja;
        }

        public int Taxi_id { get => taxi_id; }
        public string Indulas { get => indulas; }
        public int Idotartam { get => idotartam; }
        public double Tavolsag { get => tavolsag; }
        public double Viteldij { get => viteldij; }
        public double Borravalo { get => borravalo; }
        public string Fizetes_modja { get => fizetes_modja; }
    }
}
