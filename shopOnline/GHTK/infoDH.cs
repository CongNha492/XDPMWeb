using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopOnline.GHTK
{
    public class info_products
    {
        public string name;
        public double weight;
        public int quantity;
    }

    public class info_order
    {
        public string id;
        public string pick_name = "Vũ Minh Đức";
        public int pick_money;
        public string pick_address = "152 Cao Lỗ";
        public string pick_province = "Hồ Chí Minh";
        public string pick_district = "Quận 8";
        public string pick_ward = "Phường 4";
        public string pick_tel = "0145076863";
        public string name;
        public string address;
        public string province;
        public string district;
        public string ward;
        public string hamlet = "Khác";
        public string tel;
        public string note;
        public string email;
        public string transport = "road";
        public int is_freeship;
        public int value;
    }
    public class infoDH
    {
        public List<info_products> products = new List<info_products>();
        public info_order order = new info_order();
    }
}
