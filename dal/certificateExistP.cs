using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;
namespace dal
{
   public partial class certificateExist
    {
        static DBEntities db = new DBEntities();
        //public static void addCertificateExist(string id, int statusCertificate, string dayCareCenterId,/*string picture,*/ DateTime issueDate, int certificateId)
        //{
            
        //    try
        //    {
        //        db.certificateExist.Add(new certificateExist()
        //        {
        //            Id = id,
        //            statusCertificate = statusCertificate,
        //            dayCareCenterId = dayCareCenterId,
        //            issueDate = issueDate,
        //            certificateId = certificateId
        //        });
        //        db.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
        public static void addCertificateExist(CcertificateExist cce)
        {
            certificateExist ce = mapper.ConvertCertificateExist(cce);
            try
            {
                using (var db = new DBEntities())
                {
                    db.certificateExist.Add(ce);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void deleteCertificateExist(int id)
        {

            certificateExist ce = db.certificateExist.Find(id);
            if (ce != null)
                db.certificateExist.Remove(ce);
            db.SaveChanges();
        }
        public static certificateExist getCertificateExist(int id)
        {
            return db.certificateExist.Find(id);
        }
        public static List<CcertificateExist> getCertificateByDCC(string id)
        {
            List <certificateExist> certificates = db.certificateExist.Where(c => c.dayCareCenterId == id).ToList();
            if(certificates!=null)
            {
                return mapper.convertToCommonCertificateExistList(certificates);
            }
            return null;
        }
    }
}
