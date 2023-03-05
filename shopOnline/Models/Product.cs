using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace shopOnline.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên sản phẩm !")]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Chưa nhập giá !")]
        [Range(0, 19999999, ErrorMessage = "Giá sản phẩm phải từ 0 tới 19999999")]
        public int? ProductPrice { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Chưa nhập khối lượng !")]
        public double? Weight { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
