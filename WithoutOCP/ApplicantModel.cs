using System;

namespace WithoutOCP
{
    public class ApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public ApplicantType ApplicantType { get; set; }

        public double Salary { get; set; }
    }

    public enum ApplicantType
    { 
        Junior, 
        Senior
    }
}
