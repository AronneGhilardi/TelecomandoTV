using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomandoTV
{
    internal class TelecomandoTV
    {
        private bool stato;

        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }
        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
        }
        public bool getStato()
        {
            return stato;
        }
    }
}