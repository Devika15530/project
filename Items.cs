using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class Items:Subcategories
    {
        [Key]
        public int itemid, price, stocknum;

        public string itemname, ides, remarks;


        public Items() { }
        public Items(int cid, string cname, string cdetails, int id, string name, string details,int itemid, int price, int stocknum, string itemname, string ides, string remarks):base(cid, cname, cdetails,  id,  name,  details)
        {
            this.itemid = itemid;
            this.price = price;
            this.stocknum = stocknum;
            this.itemname = itemname;
            this.ides = ides;
            this.remarks = remarks;


        }


    }
}
