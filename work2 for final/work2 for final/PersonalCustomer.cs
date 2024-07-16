using System;

namespace work2_for_final
{
    public class PersonalCustomer : Customer
    {
        public string PersonalID { get; set; }

        public PersonalCustomer(string firstName, string lastName, string email, string phone, string personalID)
            : base(firstName, lastName, email, phone)
        {
            PersonalID = personalID;
        }

        public override void PrintCustomerInfo()
        {
            base.PrintCustomerInfo();
            Console.WriteLine($"personal ნომერი: {PersonalID}");
        }
    }
}
