using System;
using System.Collections.Generic;

#nullable disable

namespace shopOnline.Models
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
            Orders = new HashSet<Order>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string FullName { get; set; }
        public string FullNameEn { get; set; }
        public string CodeName { get; set; }
        public int? AdministrativeUnitId { get; set; }
        public int? AdministrativeRegionId { get; set; }

        public virtual AdministrativeRegion AdministrativeRegion { get; set; }
        public virtual AdministrativeUnit AdministrativeUnit { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
