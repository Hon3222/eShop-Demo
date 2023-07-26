using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace eShop_V1.Models
{
    public class Market
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Market Logo")]
        [Required(ErrorMessage = "Market Logo is required")]


        public string Logo { get; set; }
        [Display(Name = "Market Name")]
        [Required(ErrorMessage = "Market Name is required")]

        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Market Description is required")]

        public string Description { get; set; }

        //Relationships
        public List<Product> Products { get; set; }


    }
}
