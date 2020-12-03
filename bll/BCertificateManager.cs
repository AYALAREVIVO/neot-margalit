using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;
using dal;
namespace bll
{
  public  class BCertificateManager
    {
        public static List<CcertificateExist> getCertificateByDCC(string id)
        {
            return certificateExist.getCertificateByDCC(id);
        }
        public static void addCertificate(string id, int statusCertificate, string dayCareCenterId,  DateTime issueDate, int certificateId, byte[] picture=null)
        {
            CcertificateExist c = new CcertificateExist(id, statusCertificate, dayCareCenterId,  issueDate, certificateId, picture);
          //  certificateExist.addCertificateExist( id,  statusCertificate,  dayCareCenterId,/*string picture,*/  issueDate,  certificateId);
            certificateExist.addCertificateExist(c);
        }
    }
}
