using System;

namespace P5
{
    internal class RecordIssue
    {
        private AppUser currentAppUser;

        public RecordIssue()
        {
        }

        public RecordIssue(AppUser currentAppUser)
        {
            this.currentAppUser = currentAppUser;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}