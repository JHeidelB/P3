using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetAll(int ProjectId);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        Requirement GetRequirementById(int requirement);
        int CountByFeatureId(int featureID);
        void RemoveByFeatureID(int featureID);
    }
}
