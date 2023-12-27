
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ui.requests
{
    class CartDto
    {
        public int Id { get; set; }
        public ProductResponse Product {get; set;}
    }
}