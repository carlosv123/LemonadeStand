using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class userInterface
    {
        Player player = new Player();
        Weather weather = new Weather();
        Store store = new Store();
        List<Customer> customers = new List<Customer>();

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome, You have 7 days to go make that money! Go!");
            Console.ReadLine();
        }
        
            
        
    }
}
