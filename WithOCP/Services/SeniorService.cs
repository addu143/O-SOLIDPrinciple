using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithOCP.Services;

namespace WithOCP
{
    public class SeniorService : IApplicantService
    {
        public double CalculateSalary()
        {
            return 200;         
        }
    }
}
