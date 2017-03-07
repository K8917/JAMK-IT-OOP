using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    public class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> Items;
        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }
        public string Total()
        {
            double tmp = 0;
            foreach (InvoiceItem invo in Items)
            {
                tmp += invo.Total();
            }
            return tmp.ToString();
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Customer " + Customer + "'s Invoice: ");
            Console.WriteLine(("").PadRight(30, '='));
            foreach (InvoiceItem invo in Items)
            {
                Console.WriteLine(invo.ToString());
            }
            Console.WriteLine(("").PadRight(30, '='));
            Console.WriteLine("Invoice total: " + Total() + "$");
        }
    }
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public InvoiceItem() { }
        public InvoiceItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return "Name: " + Name + "| Price: " + Price + "$| Quantity: " + Quantity;
        }
    }
}