using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace shopOnline.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên danh mục !")]
        public string CategoryName { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
