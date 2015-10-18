using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Domain.Models
{
    public class CallCharges
    {
        public List<Call> Calls { get; set; }
        public double Total { get; set; }
    }
}
