using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERORR = "Statement must be unique";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND_EORR = "Requirement does not exist";
        public const string MISSING_FEATURID_ERORR = "Must select a feature for this requirement";
        public const string MISSING_PROJECTID_EROOR = "must select a project for this requirement";

        private List<Requirement> _Requirements = new List<Requirement>();
        public string Add(Requirement requirement)
        {
            string newRequrementStatement = requirement.Statement.Trim();
            if (IsDupliclateStatement(newRequrementStatement))
            {
                return DUPLICATE_STATEMENT_ERORR;
            }
            if (newRequrementStatement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            _Requirements.Add(requirement);
            return NO_ERROR;
        }

        public int CountByFeatureId(int featureID)
        {
            throw new NotImplementedException();
        }

        public List<Requirement> GetAll(int ProjectId)
        {
            return _Requirements;
        }

        public Requirement GetRequirementById(int requirement)
        {
            Requirement curReq;
            try
            {
                curReq = _Requirements[requirement];
            }
            catch
            {

                curReq = null;
            }
            return curReq;
        }

        public string Modify(Requirement requirement)
        {
            if (IsDupliclateStatement(requirement.Statement))
            {
                return DUPLICATE_STATEMENT_ERORR;
            }
            if (requirement.Statement.Trim() == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            int index = 0;
            foreach (Requirement p in _Requirements)
            {
                if (requirement.Statement == p.Statement)
                {
                    _Requirements[index].Statement = requirement.Statement;
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_EORR;
        }

        public string Remove(Requirement requirement)
        {
            int index = 0;
            foreach (Requirement p in _Requirements)
            {
                if (p.ProjectId == requirement.ProjectId)
                {
                    _Requirements.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_EORR;
        }

        public void RemoveByFeatureID(int featureID)
        {
            int index = 0;
            foreach (Requirement p in _Requirements)
            {
                if (p.ID == featureID)
                {
                    _Requirements.RemoveAt(index);
                }
                index++;
            }
        }

        public bool IsDupliclateStatement(string statement)
        {
            bool isDuplicate = false;
            foreach (Requirement p in _Requirements)
            {
                if (statement == p.Statement)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
    }
}
