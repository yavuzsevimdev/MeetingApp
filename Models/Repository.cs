namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Yavuz", Phone = "111", Email = "info1@gmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Ali", Phone = "222", Email = "info2@gmail.com", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Ahmet", Phone = "333", Email = "info3@gmail.com", WillAttend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}