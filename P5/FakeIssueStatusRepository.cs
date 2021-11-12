using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6 {
    class FakeIssueStatusRepository : IIssueStatusRepository {
        private List<IssueStatus> IssueStatuses;
        public void Add(int Id, string value) {
            throw new NotImplementedException();
        }

        public List<IssueStatus> GetAll() {
            throw new NotImplementedException();
        }

        public int GetIdByStatus(string value) {
            throw new NotImplementedException();
        }

        public string GetValueById(int Id) {
            throw new NotImplementedException();
        }
    }
}
