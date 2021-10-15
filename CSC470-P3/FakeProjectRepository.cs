using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{

    class FakeProjectRepository : IProjectRepository
    {
        private static Dictionary<string, Project> Projects;
        private static List<Project> project;
        const string NO_ERROR = "";
        const string MODIFIED_PROJECT_ID_ERROR = "Modified Project Id";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Duplicate Project Name";
        const string NO_PROJECT_FOUND_ERROR = "No Project Found";
        const string EMPTY_PROJECT_NAME_ERROR = "Empty Project Name";
        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("1", new Project
                {
                    Name = "Accouting Project",
                    Id = 1
                });
                Projects = new Dictionary<string, Project>();
                Projects.Add("2", new Project
                {
                    Name = "Big Expensive Project",
                    Id = 2
                }); Projects = new Dictionary<string, Project>();
                Projects.Add("3", new Project
                {
                    Name = "Some Other Project",
                    Id = 3
                });
            }
        }


        private int GetNextID()
        {
            Project next = new Project();
            int id = next.Id + 1;
            return id;
        }

        public string Add(Project project, out int Id)
        {
            throw new NotImplementedException();
        }

        public string Remove(int projectId)
        {
            throw new NotImplementedException();
        }

        public string Modify(int projectId, Project project)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsDuplicateName(string ProjectName)
        {
            throw new NotImplementedException();
        }
    }
}
