using WithOCP.Services;

namespace WithOCP
{
    public interface IApplicantModel
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        double Salary { get; set; }

        public IApplicantService ApplicantService { get; set; }
    }
}