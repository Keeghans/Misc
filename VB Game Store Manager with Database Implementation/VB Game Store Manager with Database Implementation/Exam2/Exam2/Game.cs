using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Game
    {
        private string gameID;
        private string title;
        private decimal price;
        private decimal discount;
        public string GameId { get => gameID; set => gameID = value; }
        public string Title { get => title; set => title = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Discount { get => discount; set => discount = value; }
        virtual public decimal GetSalePrice()
        {
            return (price - discount);
        
        }
    }

}
