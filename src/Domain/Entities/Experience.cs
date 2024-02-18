namespace CurriculumVitaeGenerator.Domain.Entities;

public class Experience
{
    /// <summary>
    /// Which company employed you
    /// </summary>
    public string Employer { get; set; }
    /// <summary>
    /// In case you worked for a service company and so for your company's customers.
    /// </summary>
    public string Customer { get; set; }
    public string Role { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string Context { get; set; }
    public List<string> Missions { get; set; }
}
