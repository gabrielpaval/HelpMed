using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMed
{
    class Medicament
    {
        private int cod;
        private string denumire;
        private string producator;
        private float pret;
        private int stoc;
        private DateTime data_exp;
        private bool compensat;

        public Medicament()
        {
            cod = 0;
            denumire = string.Empty;
            producator = string.Empty;
            pret = 0;
            stoc = 0;
            data_exp = DateTime.Now;
            compensat = false;
        }

        public int GetCod()
        {
            return this.cod;
        }

        public int SetCod(int cod) => this.cod = cod;

        public string GetDenumire()
        {
            return this.denumire;
        }

        public string SetDenumire(string denumire) => this.denumire = denumire;

        public string GetProducator()
        {
            return this.producator;
        }

        public string SetProducator(string producator) => this.producator = producator;




    }
}
