using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public int Count { get; set; }
        public int OrderId { get; set; }
    }
}
