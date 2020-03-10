using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloVjezbaOO2
{
    class Vozilo
    {
        string vrata;
        int maxBrzina;
        int brojKotaca;

        public Vozilo(string vrata, int maxBrzina, int brojKotaca)
        {
            this.vrata = vrata;
            this.maxBrzina = maxBrzina;
            this.brojKotaca = brojKotaca;
        }

        public Vozilo(string vrata, int brojKotaca)
        {
            this.vrata = vrata;
            this.brojKotaca = brojKotaca;
        }

        public void setmaxBrzina(int maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }


    }
}
