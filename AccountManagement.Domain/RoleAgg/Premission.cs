using OuroFramework.Domain;

namespace AccountManagement.Domain.RoleAgg
{
    public class Premission : EntityBase<int>
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int RoleId { get; private set; }
        public Role Role { get; private set; }

        public Premission(int code, string name, int roleId)
        {
            Code = code;
            Name = name;
            RoleId = roleId;
        }
        public Premission(int code)
        {
            Code = code;
        }
    }
}
