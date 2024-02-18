namespace CurriculumVitaeGenerator.Domain.Entities;

public class AdministrativeInformation
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Address Address { get; set; }
}

public class Address
{
    public StreetTypes StreetType { get; set; }
    public string StreetName { get; set; }

    public enum StreetTypes
    {
        Street,
        Avenue,
        Boulevard,
        Alley,
        Path
    }
}