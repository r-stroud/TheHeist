namespace TheHeist;

public class TeamMember
{
    public string Name { get; set; }
    public int SkillLevel { get; set; } // should be positive
    public decimal CourageFactor { get; set; } // should be between 0.0 and 2.0

    // TODO: make this return the right string
    public override string ToString()
    {
        return @$"
===========================
Name: {Name}
Skill: {SkillLevel}
Courage: {CourageFactor}
===========================
";
    }
}
