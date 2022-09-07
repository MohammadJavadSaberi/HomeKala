using AccountManagement.Domain.AccountAgg;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace AccountManagement.Domain.RoleAgg
{
    public class Role : EntityBase<int>
    {
        public string Title { get; private set; }
        public List<Account> Accounts { get; private set; }
        public List<Premission> Premissions { get; private set; }

        protected Role() { }
        public Role(string title, List<Premission> premissions)
        {
            Title = title;
            Premissions = premissions;
        }
        public void Edit(string title, List<Premission> premissions)
        {
            Title = title;
            Premissions = premissions;
        }
    }
}
