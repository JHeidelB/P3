﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    class FakePreferenceRepository : IPreperenceRepository
    {
        public const string PREFERENCE_PROJECT_ID = "Project ID";
        public const string PREFERENCE_PROJECT_NAME = "Project Name";
        private const string NO_ERROR = "";
        private static Dictionary<string, Dictionary<string, string>> Preferences = new Dictionary<string, Dictionary<string, string>>();

        public string GetPreference(string UserName, string PreferenceName)
        {
            Dictionary<string, string> NameValuePair = new Dictionary<string, string>();
            string value = "";
            if (Preferences.TryGetValue(UserName, out NameValuePair))
            {
                NameValuePair.TryGetValue(PreferenceName, out value);
            }
            return value;
        }

        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, Dictionary<string, string>> preference = new Dictionary<string, Dictionary<string, string>>();
            string value = "";
            return value;
        }
    }
}