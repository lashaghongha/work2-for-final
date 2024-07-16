using System;

namespace work2_for_final
{
    public class BusinessCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string CompanyID { get; set; }

        public BusinessCustomer(string firstName, string lastName, string email, string phone, string companyName, string companyID)
            : base(firstName, lastName, email, phone)
        {
            CompanyName = companyName;
            CompanyID = companyID;
        }

        public override void PrintCustomerInfo()
        {
            base.PrintCustomerInfo();
            Console.WriteLine($"კომპანიის დასახელება: {CompanyName}, საიდენტიფიკაციო ნომერი: {CompanyID}");
        }
    }
}
