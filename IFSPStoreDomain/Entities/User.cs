using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class User : BaseEntity<int>
    {
        public User(int id, string name, string password, string login, string email, DateTime registerdate, DateTime logindate, bool isActive) : base(id)
        {
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegisterDate = registerdate;
            LoginDate = logindate;
            IsActive = isActive;
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsActive { get; set; }
    }
}
