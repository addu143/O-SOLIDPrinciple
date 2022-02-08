﻿using WithOCP.Services;

namespace WithOCP
{
    public class JuniorModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public double Salary { get; set; }
        public IApplicantService ApplicantService { get; set; } = new JuniorService();
    }
}
