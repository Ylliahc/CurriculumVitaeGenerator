namespace CurriculumVitaeGenerator.Domain.Entities;

public class Skill
{
    public string Name { get; set; }
    public SkillTypes Type { get; set; }

    public SkillLevels Level { get; set; }

    public enum SkillTypes 
    {
        Technic,
        Method,
        Soft
    }

    public enum SkillLevels 
    {
        Beginner = 1,
        Intermediate = 2,
        Autonom = 3,
        Expert = 4
    }
}
