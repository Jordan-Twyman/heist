
using System.Collections.Generic;
namespace heist
{
public class Muscle : TeamMember, IRobber
{



    public string Name {get; set;}
    public string SkillLevel {get; set;}
    public string PercentageCut {get; set;}
    

  public void PerformSkill(Bank bank)
 {
    int hackerSkill = Int32.Parse(SkillLevel);
    int hackerScore = hackerSkill - bank.SecurityGuardScore;
    
    Console.WriteLine($"{Name}");

    if(bank.SecurityGuardScore <= 0)
    {
        Console.WriteLine($"{Name} was able to disable the alarm");
    }
    else{

    }
 }
}
}
     