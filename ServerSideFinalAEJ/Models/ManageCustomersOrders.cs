using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSideFinalAEJ.Models
{
    

    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEMail { get; set; }

    }

    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public float ProdPrice { get; set; }
        
    }

    public class Order
    {
        public int orderId { get; set; }
        public int CustId { get; set; }
        public int ProdId { get; set; }
        public float ProdPrice { get; set; }
        public ICollection<Product> Products { get; set; }
        public virtual Product
        public virtual Customer

    }
}