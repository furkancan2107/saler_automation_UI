
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ui.requests
{
    class ProductResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public DateTime DatePosted { get; set; }
    }
}