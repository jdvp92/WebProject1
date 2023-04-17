using System;
using System.Collections.Generic;
using System.Linq;

namespace WebProject1.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int DepartmentId { get; set; }
        public int ProductId { get; set; }

        public ICollection<SalesRecord> Sales = new List<SalesRecord>();


        public Seller()
        {
        }

        public Seller(int id, string name, double baseSalary)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}