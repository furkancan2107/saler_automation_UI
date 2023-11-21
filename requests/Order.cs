
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ui.requests
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductResponse Product { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public string OrderStatus { get; set; }
    }
}