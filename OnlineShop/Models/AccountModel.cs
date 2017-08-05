using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }

        public bool Login(string username, string password)
        {
            var res = context.Accounts.FirstOrDefault(p => p.Username == username && p.Password == password);
            if (res != null)
                return true;
            return false;
        }
    }
}
