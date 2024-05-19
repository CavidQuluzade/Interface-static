namespace TaskUser
{
    internal class Program
    {
        static void Main()
        {
            User user1 = new("Javid", "Qulu-zade", User.RegistrationMonth.June, "RT34567");
            user1.GetDetails();
            User user2 = new("AAA", "AA", User.RegistrationMonth.March, "1234567");
            user2.GetDetails();
            User user3 = new("BBB", "BB", User.RegistrationMonth.February, "abvfdggg");
            user3.GetDetails();
            User user4 = new("CCC", "CC", User.RegistrationMonth.January, "123456");
            user4.GetDetails();
            User user5 = new("DDD", "DD", User.RegistrationMonth.August, "TYRJCEERT");
            user5.GetDetails();
     

        }
    }
}
