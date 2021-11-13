using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6 {
    class FakeIssueStatusRepository : IIssueStatusRepository {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public FakeIssueStatusRepository() {
            _IssueStatuses.Clear();
            _IssueStatuses = new List<IssueStatus> { new IssueStatus { Id=0, Value="Open" }, new IssueStatus { Id = 1, Value = "Assigned" }, new IssueStatus { Id = 2, Value = "Fixed" }, new IssueStatus { Id = 3, Value = "Closed - Won't fix" }, new IssueStatus { Id = 4, Value = "Closed - Fixed" }, new IssueStatus { Id = 5, Value = "Closed - By design" }, };
        }
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
