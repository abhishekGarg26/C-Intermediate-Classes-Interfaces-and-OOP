using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /*public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {
            Orders = new List<Order>();
        }*/
        /* public Customer(int id) 
         {
             this.Id = id;
         }
         public Customer(int id,string name)
             : this(id)
         {
             //this.Id = id;
             this.Name = name;
         }*/


        public void Promote()
        {
            /* var rating = CalculatorRating(excludeOrders: true);
             if (rating == 0)
                 System.Console.WriteLine("Promoted to Level 1");
             else
                 System.Console.WriteLine("Promoted to Level 2");*/

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote Logic Changed.");

        }

        /* protected int CalculatorRating(bool excludeOrders)
         {
             return 0;
         }*/
    }
}
