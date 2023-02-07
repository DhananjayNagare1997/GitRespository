using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Order
    {
        public string OrderNo { get; set; }
        public string OrderValue { get; set; }
        public string OrderCounytry { get; set; }
        public object OrderCountry { get; set; }

        public string CreateOrder()
        {
            validateOrderValue();
            validateOrderCountry();

        //Order creation logic.
            return "Oredr Created";
        }
        private bool validateOrderValue()
        {
           // Implimaintion will go hear.     
          return true;
        }
        private bool validateOrderCountry()
        {
           // Implimaintion will go hear. 
          return true;
        }
    }

