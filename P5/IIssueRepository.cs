using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Builder
{
    public interface IIssueRepository
    {
        string Add(int ID, Issue issue);
       
    }
}
