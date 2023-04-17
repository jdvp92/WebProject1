using System;
using System.Collections.Generic;
using WebProject1.Models.Enums;

namespace WebProject1.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = new DateTime();
        public double Amount { get; set; }
        public Seller Seller { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, Seller seller, Product product, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Product = product;
            Status = status;
        }
    }
}
