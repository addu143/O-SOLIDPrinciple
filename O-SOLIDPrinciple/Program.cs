   using System;
using System.Collections.Generic;
using WithOCP;
using WithoutOCP;

namespace O_SOLIDPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSalariesWithOCP();

            //GetSalariesWithoutOCP();
        }
        public static void GetSalariesWithOCP()
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new JuniorModel { FirstName = "Muhammad", LastName = "Adnan" },
                new SeniorModel { FirstName = "Farhan", LastName = "Saleem"},
                new JuniorModel { FirstName = "Yasin", LastName = "Saleem"}
            };

            foreach (var applicant in applicants)
            {
                applicant.Salary = applicant.ApplicantService.CalculateSalary();
                Console.WriteLine($"{ applicant.FirstName } { applicant.LastName }, Salary: {applicant.Salary}");
            }

        }

        public static void GetSalariesWithoutOCP()
        {
            List<ApplicantModel> applicants = new List<ApplicantModel>
            {
                new ApplicantModel { FirstName = "Muhammad", LastName = "Adnan", ApplicantType = ApplicantType.Junior },
                new ApplicantModel { FirstName = "Farhan", LastName = "Saleem", ApplicantType = ApplicantType.Senior },
                new ApplicantModel { FirstName = "Yasin", LastName = "Saleem", ApplicantType = ApplicantType.Junior }
            };

            foreach (var applicant in applicants)
            {
                applicant.Salary = ApplicantService.CalculateSalary(applicant);
                Console.WriteLine($"{ applicant.FirstName } { applicant.LastName }, Salary: {applicant.Salary}");
            }

        }
    }
}
