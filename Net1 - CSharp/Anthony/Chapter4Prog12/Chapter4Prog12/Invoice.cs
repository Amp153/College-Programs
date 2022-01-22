

namespace Chapter4Prog12
{
    class Invoice
    {
        //auto-implemented properties
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        //constructors
        public Invoice(string part, string desc, int count, decimal price) 
        {
            //quantity = count;
            Quantity = count;
            PricePerItem = price;
            PartNumber = part;
            PartDescription = desc;
        }

        public Invoice() 
        {
        
        }

        /* private string partNumber;
         * public string partNumber
         * {
         *  get
         *  {
         *      return partNumber;
         *      }
         *      set
         *      {
         *      partNumber = value;
         *      }
         * }*/

        private int quantity;
        //define the perperty procedures for quantity
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }

        private decimal pricePerItem;
        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value >= 0)
                    pricePerItem = value;
            }
        }

        public decimal GetInvoiceAmount()
        {
            return Quantity * PricePerItem;
        }
    }
}
