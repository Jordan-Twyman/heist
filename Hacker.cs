 using System.Collections.Generic;

 
 namespace heist
{
 public class Hacker : TeamMember, IRobber
{

    public string Name {get; set;}
    public string SkillLevel {get; set;}
    public string PercentageCut {get; set;}
    

  public void PerformSkill(Bank bank)
 {
    int hackerSkill = Int32.Parse(SkillLevel);
    int hackerScore = hackerSkill - bank.AlarmScore;
    
    Console.WriteLine($"{Name}");

    if(bank.AlarmScore <= 0)
    {
        Console.WriteLine($"{Name} was able to disable the alarm");
    }
    else{

    }
 }
}
}