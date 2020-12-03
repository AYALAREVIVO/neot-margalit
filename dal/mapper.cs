using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comon;

namespace dal
{
    class mapper
    {
        //user
        public static users ConvertUser(Cuser u)
        {
            users user = new users();
            user.userName = u.userName;
            user.password = u.password;
            user.permission = u.permission;
            user.firstName = u.firstName;
            user.lastName = u.lastName;
            return user;
        }
        public static Cuser ConvertToCommonUser(users u)
        {
            Cuser c = new Cuser(u.userName, u.password, u.lastName, u.firstName, u.permission);
            return c;    
        }
        //problem
        public static problemsExist ConvertProblemExist(CproblemsExist p)
        {
            problemsExist pe = new problemsExist();
            pe.Id = p.Id;
            pe.problemStatus = p.problemStatus;
            pe.date = p.date;
            pe.maintenanceDescription = p.maintenanceDescription;
            pe.problemId = p.problemId;
            pe.dayCareCenterId = p.dayCareCenterId;
            pe.pictureAfter = p.pictureAfter;
            pe.pictureBefore = p.pictureBefore;
            return pe;
        }
        public static CproblemsExist convertToCommonProblemExist(problemsExist p)
        {
            CproblemsExist problemExist = new CproblemsExist(p.Id,p.problemStatus,p.date,p.dayCareCenterId,p.maintenanceDescription,p.problemId,p.pictureBefore,p.pictureAfter);
            return problemExist;
        }
        //list problem
        public static List<CproblemsExist> convertToCommonProblemExistList(List<problemsExist> p)
        {
            List<CproblemsExist> listProblems=new List<CproblemsExist>();
            foreach (problemsExist item in p)
            {
                listProblems.Add(convertToCommonProblemExist(item));
            }
            return listProblems;
        }
        //certificate
        public static certificateExist ConvertCertificateExist(CcertificateExist c)
        {
            certificateExist ce = new certificateExist();
            ce.Id = c.Id;
            ce.statusCertificate = c.statusCertificate;
            ce.dayCareCenterId = c.dayCareCenterId;
            ce.picture = c.picture;
            ce.issueDate = c.issueDate;
            ce.certificateId = c.certificateId;
            return ce;
        }
        public static CcertificateExist convertCommonCertificate(certificateExist c)
        {
            CcertificateExist certificate = new CcertificateExist(c.Id, c.statusCertificate,c.dayCareCenterId, c.issueDate, c.certificateId, c.picture);
            return certificate;
        }
        public static List<CcertificateExist> convertToCommonCertificateExistList(List<certificateExist> c)
        {
            List<CcertificateExist> listCertificates = new List<CcertificateExist>();
            foreach (certificateExist item in c)
            {
                listCertificates.Add(convertCommonCertificate(item));
            }
            return listCertificates;
        }
    }
}
