using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOCP
{
    public class ApplicantService
    {
        public static double CalculateSalary(ApplicantModel applicantInfo)
        {
            switch (applicantInfo.ApplicantType)
            {
                case ApplicantType.Junior:
                    return 100;
                case ApplicantType.Senior:
                    return 200;
                default:
                    break;
            }
            
            return 0;
        }
    }
}
