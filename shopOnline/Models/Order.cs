using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace shopOnline.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên !")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên đường, số nhà !")]
        public string CustomerAddress { get; set; }
        [Required(ErrorMessage = "Chưa nhập thành phố/tỉnh !")]
        public string CustomerProvinceCode { get; set; }
        [Required(ErrorMessage = "Chưa nhập quận/huyện !")]
        public string CustomerDistrictCode { get; set; }
        [Required(ErrorMessage = "Chưa nhập phường/xã !")]
        public string CustomerWardCode { get; set; }
        [Required(ErrorMessage = "Chưa nhập SĐT !")]
        [RegularExpression(@"^([0-9]{10})", ErrorMessage = "SĐT không đúng !")]
        public string CustomerTel { get; set; }
        [Required(ErrorMessage = "Chưa nhập email !")]
        public string CustomerEmail { get; set; }
        public string Note { get; set; }
        public int TotalMoney { get; set; }
        public bool Prepaid { get; set; }
        public bool Deleted { get; set; }
        public bool Confirmed { get; set; }
        public string LabelGhtk { get; set; }
        public int? InsuranceFeeGhtk { get; set; }
        public int? FeeshipGhtk { get; set; }

        public virtual District CustomerDistrictCodeNavigation { get; set; }
        public virtual Province CustomerProvinceCodeNavigation { get; set; }
        public virtual Ward CustomerWardCodeNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
