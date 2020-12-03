using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comon
{
   public class CproblemsExist
    {
        public CproblemsExist(string Id, int problemStatus,DateTime date, string dayCareCenterId,
            string maintenanceDescription, int problemId, string pictureBefore=null, string pictureAfter=null)
        {
            this.date = date;
            this.dayCareCenterId = dayCareCenterId;
            this.problemId = problemId;
            this.Id = Id;
            this.maintenanceDescription = maintenanceDescription;
            this.problemStatus = problemStatus;
            this.pictureBefore = pictureBefore;
            this.pictureAfter = pictureAfter;
        }
        public string Id { get; set; }
        public int problemStatus { get; set; }
        public string pictureBefore { get; set; }
        public string pictureAfter { get; set; }
        public System.DateTime date { get; set; }
        public string dayCareCenterId { get; set; }
        public string maintenanceDescription { get; set; }
        public int problemId { get; set; }

        
    }
}
