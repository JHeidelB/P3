using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    public interface IPreperenceRepository
    {
        string GetPreference(string UserName, string PreferenceName);
        string SetPreference(string UserName, string PreferenceName, string Value);
    }
}