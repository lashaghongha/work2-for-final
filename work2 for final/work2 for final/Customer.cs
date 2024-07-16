using System;

namespace work2_for_final
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public virtual void PrintCustomerInfo()
        {
            Console.WriteLine($"სახელი: {FirstName} {LastName}, ელ.ფოსტა: {Email}, ტელეფონი: {Phone}");
        }
    }
}
