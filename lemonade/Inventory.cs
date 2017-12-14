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

        public List<Ice> GetIceList
        {
            get
            {
                return ices;
            }
        }
        public void AddIce()
        {
            Ice ice = new Ice();
            ices.Add(ice);
        }
        public void RemoveIce()
        {
            lemons.RemoveAt(0);
        }

        public List<Sugar> GetSugarList
        {
           get
            {
                return sugars;
            }
        }
        public void AddSugar()
        {
            Sugar sugar = new Sugar();
            sugars.Add(sugar);
        }
        public void RemoveSugar()
        {
            sugars.RemoveAt(0);
        }

        public List<Cup> GetCupList
        {
            get
            {
                return cups;
            }
        }
        public void AddCups()
        {
            Cup cup = new Cup();
            cups.Add(cup);
        }
        public void RemoveCup()
        {
            cups.RemoveAt(0);
        }




    }
}
