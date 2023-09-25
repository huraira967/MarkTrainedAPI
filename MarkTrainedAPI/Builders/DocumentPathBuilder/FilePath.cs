using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Builders.DocumentPathBuilder
{
    internal class FilePath
    {
        public const string ServicePlanFolderName = "Service Plan";

        public const string NursingPlanFolderName = "Nursing Plan";

        public const string HomeInspection = "Home Inspection";

        public const string NursingVisits = "Nursing Visits";

        public const string INE = "Initial Nursing Evaluation";

        public const string PCPReviews = "PCPReview";

        public const string AbilitiesNeeds = "Abilities Needs";

        public const string PCPTrainingChecklist = "PCP Training Checklist";

        public const string PaperMAR = "Paper MAR";

        public static string MAR(int alfId, int residentId, string folderName)
        {
            return alfId + "/Resident/" + residentId + "/" + folderName + "/";
        }

        public static string GetUrlByAlfAndResId(int alfId, int residentId, string folderName)
        {
            return alfId + "/Resident/" + residentId + "/" + folderName + "/";
        }

        public static string GetUrlByAlfAndLocIdHomeInspection(int alfId, int locationId, int docId, string folderName)
        {
            return alfId + "/Location/" + locationId + "/" + folderName + "/" + docId + "/";
        }

        public static string GetStaffTrainingSignUrl(int alfId, int? staffId, string extension)
        {
            if (staffId > 0)
            {
                string[] obj = new string[6]
                {
                    alfId.ToString(),
                    "/Staff/",
                    null,
                    null,
                    null,
                    null
                };
                int? num = staffId;
                obj[2] = num.ToString();
                obj[3] = "/Training Documents/";
                obj[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                obj[5] = extension;
                return string.Concat(obj);
            }

            return "ERROR";
        }

        public static string GetPMOFPath(int alfId, int residentId, string fileName)
        {
            return alfId + "/PMOF/PMOFs Documents/" + residentId + "/" + fileName;
        }

        public static string GetMSPDocFPath(int alfId, int residentId, string fileName)
        {
            return alfId + "/MSP/MSP Documents/" + residentId + "/" + fileName;
        }

        public static string GetPCPTrainingCheckListSignaturesUrl(int alfId, int? staffId, string extension)
        {
            if (staffId > 0)
            {
                string[] obj = new string[6]
                {
                    alfId.ToString(),
                    "/Staff/",
                    null,
                    null,
                    null,
                    null
                };
                int? num = staffId;
                obj[2] = num.ToString();
                obj[3] = "/PCP Training Checklist/";
                obj[4] = DateTime.Now.ToString("yyyyMMddHHmmss");
                obj[5] = extension;
                return string.Concat(obj);
            }

            return "ERROR";
        }
    }

}
