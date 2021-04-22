using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class UserDao
    {
        private DbContextWebUTE db;

        public UserDao()
        {
            db = new DbContextWebUTE();
        }

        public int login(string user, string pass)
        {
            var result = db.Users.SingleOrDefault(x => x.Username.Contains(user) && x.Password.Contains(pass));
            if (result == null)
                return 0;
            else
                return 1;
        }
    }
}
