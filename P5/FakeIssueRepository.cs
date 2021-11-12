using System;
using System.Collections.Generic;

namespace P6 {
    class FakeIssueRepository : IIssueRepository {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        private string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        private static List<Issue> _Issues = new List<Issue>();
        public string Add(Issue issue) {
            if(issue.Title == "")
                return EMPTY_TITLE_ERROR;
            if (issue.DiscoveryDate == null)
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            if (issue.DiscoveryDate > DateTime.Now)
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            if (issue.Discoverer == "")
                return EMPTY_DISCOVERER_ERROR;
            _Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectId) {
            return _Issues;
        }

        public Issue GetIssueById(int Id) {
            for(int i = 0; i < _Issues.Count; i++) {
                if (_Issues[i].Id == Id)
                    return _Issues[i];
            }
            return new Issue();
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0; i < _Issues.Count; i++) {
                if(_Issues[i].ProjectId == ProjectId) {
                    if (dict.ContainsKey(_Issues[i].Discoverer)) {
                        dict[_Issues[i].Discoverer] += 1;
                    } else {
                        dict[_Issues[i].Discoverer] = 1;
                    }
                }
            }
            List<string> output = new List<string>();
            foreach (KeyValuePair<string, int> entry in dict) {
                string issue = $"{entry.Key}: {entry.Value}";
                output.Add(issue);
            }
            return output;
        }

        public List<string> GetIssuesByMonth(int ProjectId) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < _Issues.Count; i++) {
                if (_Issues[i].ProjectId == ProjectId) {
                    string month = $"{_Issues[i].DiscoveryDate.Year} - {_Issues[i].DiscoveryDate.Month}"
                    if (dict.ContainsKey(month)) {
                        dict[month] += 1;
                    } else {
                        dict[month] = 1;
                    }
                }
            }
            List<string> output = new List<string>();
            foreach (KeyValuePair<string, int> entry in dict) {
                string issue = $"{entry.Key}: {entry.Value}";
                output.Add(issue);
            }
            return output;
        }

        public int GetTotalNumberOfIssues(int ProjectId) {
            int count = 0;
            foreach (Issue issue in _Issues) {
                if (issue.ProjectId == ProjectId)
                    count++;
            }
            return count;
        }

        public string Modify(Issue issue) {
            if (issue.Title == "")
                return EMPTY_TITLE_ERROR;
            if (issue.DiscoveryDate == null)
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            if (issue.DiscoveryDate > DateTime.Now)
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            if (issue.Discoverer == "")
                return EMPTY_DISCOVERER_ERROR;
            for(int i = 0; i < _Issues.Count; i++) {
                if(_Issues[i].Id == issue.Id) {
                    _Issues[i] = issue;
                    return NO_ERROR;
                }
            }
            _Issues.Add(issue);
            return NO_ERROR;
        }

        public bool Remove(Issue issue) {
            return _Issues.Remove(issue);
        }

        private string ValidateIssue(Issue issue) {
            if (issue.Title == "")
                return EMPTY_TITLE_ERROR;
            if (issue.DiscoveryDate == null)
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            if (issue.DiscoveryDate > DateTime.Now)
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            if (issue.Discoverer == "")
                return EMPTY_DISCOVERER_ERROR;
            return NO_ERROR;
        }

        private bool IsDuplicate(string title) {
            foreach(Issue issue in _Issues) {
                if(issue.Title == title) {
                    return true;
                }
            }
            return false;
        }
    }
}
