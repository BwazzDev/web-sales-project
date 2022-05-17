using System;
using System.ComponentModel.DataAnnotations;

namespace web_sales_project.Models
{
    public enum SalesCategory
    {
        Shirt,
        Jeans,
        Shorts,
        Dress,
        Jacket,
        Accessory,
    }

    public class SalesItem
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime ListingTimeStamp { get; set; }
        
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }
        
        public int SellerId { get; set; }
        
        [Required]
        public virtual SalesCategory SalesCategory { get; set; }
    }
}