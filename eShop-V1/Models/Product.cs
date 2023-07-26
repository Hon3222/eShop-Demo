using eShop_V1.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_V1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public int MarketId { get; set; }
        [ForeignKey("MarketId")]
        public Market Market { get; set; }
    }
}
