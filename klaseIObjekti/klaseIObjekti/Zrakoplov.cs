using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    class Zrakoplov
    {
        private string naziv;
        private int snagaMotora;
        private int dosegLeta;

        public override string ToString()
        {
            string ispis = "\nNaziv: " + naziv + "\nSnaga: " + snagaMotora + "kW"
                + "\nDoseg leta: " + dosegLeta + "km";
            return ispis;
        }
        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        public Zrakoplov(string naziv, int snagaMotora)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
        }

        public string getNaziv()
        {
            return naziv;
        }
        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public int getSnagaMotora()
        {
            return snagaMotora;
        }
        public void setSnagaMotora(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public int getDosegLeta()
        {
            return dosegLeta;
        }
        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
    }
}
