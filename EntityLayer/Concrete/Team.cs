namespace EntityLayer.Concrete;
public class Team
{
    public int TeamID { get; set; }
    public string TeamName { get; set; }
    public virtual ICollection<Match> HomeMatches { get; set; }
    public virtual ICollection<Match> AwayMatches { get; set; }
}
