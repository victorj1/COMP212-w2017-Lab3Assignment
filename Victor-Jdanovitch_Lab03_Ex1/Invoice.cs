using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victor_Jdanovitch_Lab03_Ex1
{


    public class Invoice
    {

        private int quantityValue;
        private double priceValue;


        public int PartNumber { get; set; }


        public string PartDescription { get; set; }


        public Invoice(int part, string description,
        int count, double pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            Price = pricePerItem;
        }


        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if (value > 0)
                    quantityValue = value;
            }
        }


        public double Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0.0)
                    priceValue = value;
            }
        }


        public override string ToString()
        {


            return string.Format("{0,-5} {1,-20} {2,-5} {3,6:C}",
            PartNumber, PartDescription, Quantity, Price);
        }
    }

}