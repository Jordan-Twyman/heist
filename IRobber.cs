using System.Collections.Generic;
namespace heist
{

    public interface IRobber {

       public string Name {get; set;}

       public string SkillLevel {get; set;}

       public string PercentageCut {get; set;}


        public void PerformSkill(Bank bank);
    
    }
}