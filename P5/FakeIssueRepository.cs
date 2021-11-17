using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueRepository
    {
        public IEnumerable Enumerator { get; set; }
        public IEnumerable GetEnumerator()
        {
            
            return Enumerator;
        }
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project id.";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        public static Dictionary<int, Issue> _Issues;
        
        public FakeIssueRepository()
        {
            _Issues = new Dictionary<int, Issue>();
            //if (_Issues.Count == 0)
            //{
            _Issues.Add(1, new Issue
                        {
                            id = 1,
                            title = "First Issue",
                            discoveryDate = "1/25/2020 8:01:00 AM",
                            discoverer = "Bishop, Dave",
                            inicialDiscription = "The first issue",
                            component = "FormMain",
                            status = "Closed - Won't Fix"
                        });
            //}
            
        }

        public void Add(int value, Issue issue)
        {
            _Issues.Add(0, issue);
        }
    }
}
