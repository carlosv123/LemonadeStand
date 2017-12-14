using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public  class Inventory
    {
        List<Lemon> lemons = new List<Lemon>();
        List<Ice> ices = new List<Ice>();
        List<Sugar> sugars = new List<Sugar>();
        List<Cup> cups = new List<Cup>();


        public Inventory()
        {

        }

        public List<Lemon> GetLemonList
        {
            get
            {
                return lemons;
            }
        }
        public void AddLemon()
        {
            Lemon lemon = new Lemon();
            lemons.Add(lemon);
        }
        public void RemoveLemon()
        {
            lemons.RemoveAt(0);
        }






    }
}
