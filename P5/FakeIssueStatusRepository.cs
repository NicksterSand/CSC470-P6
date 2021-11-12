using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6 {
    class FakeIssueStatusRepository : IIssueStatusRepository {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public void Add(int Id, string value) {
            IssueStatus status = new IssueStatus();
            status.Id = Id;
            status.Value = value;
            _IssueStatuses.Add(status);
        }

        public List<IssueStatus> GetAll() {
            return _IssueStatuses;
        }

        public int GetIdByStatus(string value) {
            foreach(IssueStatus status in _IssueStatuses) {
                if(status.Value == value) {
                    return status.Id;
                }
            }
            return -1;
        }

        public string GetValueById(int Id) {
            foreach (IssueStatus status in _IssueStatuses) {
                if (status.Id == Id) {
                    return status.Value;
                }
            }
            return "";
        }
    }
}
