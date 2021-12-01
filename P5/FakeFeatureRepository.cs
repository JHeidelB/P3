using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeFeatureRepository : IFeatureRepository
    {
        private const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique";
        public const string EMPTY_TITLE_ERROR = "Title must have a value";
        public const string NOT_FOUND_ERROR = "Feature not found";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature";

        private List<Feature> _Features = new List<Feature>();

        public string Add(Feature featrure)
        {
            int Id = 0;
            string newFeatureName = featrure.Title.Trim();
            if (IsDupliclateName(newFeatureName))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if (newFeatureName == "")   
            {
                return EMPTY_TITLE_ERROR;
            }
            featrure.ID = GetNextId();
            _Features.Add(featrure);
            Id = featrure.ID;
            return NO_ERROR;
            
        }

        public List<Feature> GetAll(int ProjectID)
        {
            return _Features;
        }

        public List<Feature> GetAll()
        {
            return _Features;
        }

        public Feature GetFeatureById(int projectID, int featureId)
        {
            // no idea
            throw new NotImplementedException();
        }

        public Feature GetFeatureByTirle(int projectID, string title)
        {
            // no idea
            throw new NotImplementedException();
        }

        public string Modify(Feature feature)
        {
            if(IsDupliclateName(feature.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if(feature.Title.Trim() == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            int index = 0;
            foreach (Feature p in _Features)
            {
                if(feature.Title == p.Title)
                {
                    _Features[index].Title = feature.Title;
                    return NO_ERROR;
                }
                index++;
            }
            return NOT_FOUND_ERROR;
        }

        public string Remove(Feature feature)
        {
            int index = 0;
            foreach (Feature p in _Features)
            {
                if (p.Title == feature.Title)
                {
                    _Features.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return NOT_FOUND_ERROR;
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Feature p in _Features)
            {
                currentMaxId = p.ID;
            }
            return ++currentMaxId;
        }
        public bool IsDupliclateName(string titleName)
        {
            bool isDuplicate = false;
            foreach (Feature p in _Features)
            {
                if (titleName == p.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
    }
}
