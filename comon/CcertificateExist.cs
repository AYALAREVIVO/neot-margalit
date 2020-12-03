using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comon
{
   public class CcertificateExist
    {
        public CcertificateExist(string Id, int statusCertificate, string dayCareCenterId, 
            System.DateTime issueDate, int certificateId, byte[] picture=null)
        {
            this.Id = Id;
            this.statusCertificate = statusCertificate;
            this.dayCareCenterId = dayCareCenterId;
            this.issueDate = issueDate;
            this.certificateId = certificateId;
            this.picture = picture;

        }
        public string Id { get; set; }
        public int statusCertificate { get; set; }
        public string dayCareCenterId { get; set; }
        public byte[] picture { get; set; }
        public System.DateTime issueDate { get; set; }
        public int certificateId { get; set; }

    }
}
