using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyTechnicalTest.Domain.Models
{
    public class Call
    {
        public string Called { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }
    }
}
