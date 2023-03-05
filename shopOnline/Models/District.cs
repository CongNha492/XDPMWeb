using System;
using System.Collections.Generic;

#nullable disable

namespace shopOnline.Models
{
    public partial class District
    {
        public District()
        {
            Orders = new HashSet<Order>();
            Wards = new HashSet<Ward>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string FullName { get; set; }
        public string FullNameEn { get; set; }
        public string CodeName { get; set; }
        public string ProvinceCode { get; set; }
        public int? AdministrativeUnitId { get; set; }

        public virtual AdministrativeUnit AdministrativeUnit { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Ward> Wards { get; set; }
    }
}
