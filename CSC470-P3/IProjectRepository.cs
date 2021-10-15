using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public interface IProjectRepository
    {
        string Add(Project project, out int Id);
        string Remove(int projectId);
        string Modify(int projectId, Project project);
        List<Project> GetAll();
        bool IsDuplicateName(string ProjectName);
    }
}
