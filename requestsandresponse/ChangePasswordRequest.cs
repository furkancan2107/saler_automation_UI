using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.requests
{
    class ChangePasswordRequest
    {
        public string ActivationCode { get; set; }
        public string NewPassword { get; set; } 
    }
}
