using System;
using System.Linq;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    sealed class User
    {
        private string Login;
        private string Name;

        // информация о польователе

        internal Root Root { get; }

        private static User instance = null;

        private User(string Login, string Name, Root root)
        {
            this.Login = Login;
            this.Name = Name;
            this.Root = root;
        }

        internal static bool IsNull()
        {
            return instance == null;
        }

        internal static User getCurrent()
        {
            return instance;
        }

        internal static User getInstance(string Login, string Name, Root root)
        {
            if (instance == null)
                instance = new User(Login, Name, root);
            return instance;
        }

        internal static bool ExitUser()
        {
            instance = null;
            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} aka {1}", Name, Login);
        }
    }
}