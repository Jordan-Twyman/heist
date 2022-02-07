namespace heist
{
    public class Bank
    {
        public int CashOnHand {get; set;}
        public int AlarmScore {get; set;}
        public int ValutScore {get; set;}
        public int SecurityGuardScore {get; set;}


        public bool IsSecure()
        {
            int allscores = CashOnHand + AlarmScore + ValutScore + SecurityGuardScore;
            
            if (allscores <= 0){
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}