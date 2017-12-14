using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade
{
    public class Player
    {
        private double wallet;
        private string name;
        private double profit;
        private double loss;
        private double netProfitLoss;
        Inventory inventory = new Inventory();

        public Player()
        {

        }

        public string GetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double GetWallet
        {
            get
            {
                return wallet;
            }

        }
        public double AddRemoveMoney
        {
            get
            {
                return wallet;
            }
            set
            {

            }
        }
        public void GetPlayer()
        {
            Console.WriteLine("Please enter your name");
            GetName = Console.ReadLine();
            AddRemoveMoney += 25;
        }

        public string Buy(double amount, double price)
        {
            double total = price * amount;
            string walletamount = "";

            if (wallet < total)
            {
                walletamount = "Not enough money";
            }
            else
            {
                walletamount = "You have enough money";
                AddRemoveMoney -= total;
            }

            return walletamount;
        }
        public double BuyAmount()
        {
            double amountToBuy = 0;

            try
            {
                amountToBuy = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That is an invalid number. \n Please enter a number.");
                BuyAmount();
            }

            if (amountToBuy < 1)
            {
                Console.WriteLine("You entered a number lower than 1.  Your amount has reset to 0.");
                amountToBuy = 0;
            }

            return amountToBuy;
        }

        
    }
}
