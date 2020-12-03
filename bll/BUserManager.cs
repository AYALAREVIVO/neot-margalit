using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;
using dal;

namespace bll
{
   public class BUserManager
    {
        public static void addUser(Cuser c)
        {
           users.addUsers(c);
        }
        public static bool isUserFound(string userName, string password)
        {
            return users.isFound(userName, password);
        }
        public static Cuser getCuser(string userName)
        {
            return  users.getUserById(userName);
        }
        //public static CproblemsExist getProblemBymaintenanceManId(string userName)
        //{
        //    return problemsExist.getProblemsExist(userName);
        //}
    }
}
