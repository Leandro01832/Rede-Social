using System;
using System.Collections.Generic;
using System.Text;

namespace business.business
{
   public class CopiaLayout : BaseModel
    {
        public string UserId { get; set; }
        public Int64 LayoutModelo { get; set; }
        public Int64 LayoutUser { get; set; }
    }
}
