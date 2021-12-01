using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Requirement
    {
        public int ID { get; set; }
        public int ProjectId { get; set; }
        public int Feature { get; set; }
        public string Statement { get; set; }

    }
}
