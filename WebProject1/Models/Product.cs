using WebProject1.Models.Enums;

namespace WebProject1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public SalesRecord Sales { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, Department department, int price, string details)
        {
            Id = id;
            Name = name;
            Department = department;
            Price = price;
            Details = details;
        }
    }
}
