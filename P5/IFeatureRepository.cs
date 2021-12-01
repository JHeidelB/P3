using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IFeatureRepository
    {
        string Add(Feature featrure);
        List<Feature> GetAll(int ProjectID);
        string Remove(Feature feature);
        string Modify(Feature feature);
        Feature GetFeatureById(int projectID, int featureId);
        Feature GetFeatureByTirle(int projectID, string title);
    }
}
