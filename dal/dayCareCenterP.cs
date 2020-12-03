using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;
namespace dal
{
   public partial class dayCareCenter
    {
        static DBEntities db = new DBEntities();

        public static void addDayCareCenter(string id, string dayCareCenterDirectorName, string directorId, string maintenanceManId, string welfareSymbol, string economySymbol)
        {
            try
            {
                db.dayCareCenter.Add(new dayCareCenter()
                {
                    Id = id,
                    dayCareCenterDirectorName = dayCareCenterDirectorName,
                    directorId = directorId,
                    maintenanceManId = maintenanceManId,
                    welfareSymbol = welfareSymbol,
                    economySymbol = economySymbol
                });
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new UnUniqValueException();
            }
        }
        public static void deleteDayCareCenter(int id)
        {

            dayCareCenter d = db.dayCareCenter.Find(id);
            if (d != null)
                db.dayCareCenter.Remove(d);
            db.SaveChanges();
        }
        public static dayCareCenter getDayCareCenter(string id)
        {
            return db.dayCareCenter.Find(id);
        }
       
    }
}
