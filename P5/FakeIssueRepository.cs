using System;
using System.Collections.Generic;

namespace P6 {
    class FakeIssueRepository : IIssueRepository {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        private string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        List<Issue> Issues;
        public string Add(Issue issue) {
            throw new NotImplementedException();
        }

        public List<Issue> GetAll(int ProjectId) {
            throw new NotImplementedException();
        }

        public Issue GetIssueById(int Id) {
            throw new NotImplementedException();
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId) {
            throw new NotImplementedException();
        }

        public List<string> GetIssuesByMonth(int ProjectId) {
            throw new NotImplementedException();
        }

        public int GetTotalNumberOfIssues(int ProjectId) {
            throw new NotImplementedException();
        }

        public string Modify(Issue issue) {
            throw new NotImplementedException();
        }

        public bool Remove(Issue issue) {
            throw new NotImplementedException();
        }

        private string ValidateIssue(Issue issue) {
            throw new NotImplementedException();
        }

        private bool IsDuplicate(string title) {
            throw new NotImplementedException();
        }
    }
}
