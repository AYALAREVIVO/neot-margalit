using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;
using dal;

namespace bll
{
  public  class BproblemsManager
    {
        public static void addProblem(CproblemsExist c)
        {
          //  problemsExist.addProblemsExist(c);
        }
        public static List<CproblemsExist> getProblemByMM(string userName)//maintenanceMan
        {
            return problemsExist.getProblemBymaintenanceManId(userName);
        }
        public static List<CproblemsExist> getProblemByDCC(string id)//day care center
        {
            return problemsExist.getProblemByDayCareCenter(id);
        }
        public static void deleteProblemById(string id)
        {
            problemsExist.deleteProblemsExist(id);
        }
        public static void changeStatusProblem(string idProblem, int idStatus)
        {
            problemsExist.changeStatusProblem(idProblem, idStatus);
        }
    }

}
