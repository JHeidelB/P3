using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Issue
    {
        public int id { get; set; }
        public string title { get; set; }
        public string discoveryDate { get; set; }
        public string discoverer { get; set; }
        public string inicialDiscription { get; set; }
        public string component { get; set; }
        public string status { get; set; }
    }
}
