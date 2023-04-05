using WebProject1.Models.Enums;

namespace WebProject1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public SalesRecord Sales { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
    }
}
