using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGN_Computerladen.ShopItems
{
    class ShopItem
    {
        public int id { get; set; }
        public string type { get; set; }
        public string price { get; set; }
        public string name { get; set; }
        public string estimatedWorkingHours { get; set; }
    }
}
