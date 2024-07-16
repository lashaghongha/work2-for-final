using System;
using System.Collections.Generic;
using System.Text;

namespace work2_for_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // კონსოლის შრიფტის და ენკოდირების ცვლილება
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "ბანკის სისტემა";

            List<Account> accounts = new List<Account>
            {
                new SavingsAccount("001", new PersonalCustomer("John", "Doe", "john@example.com", "555-1234", "123456789"), 1000m, 1.5m),
                new CheckingAccount("002", new BusinessCustomer("Jane", "Smith", "jane@example.com", "555-5678", "Tech Corp", "987654321"), 500m, 10m)
            };

            Console.WriteLine("ყველა ანგარიშის ინფორმაცია:");
            foreach (var account in accounts)
            {
                account.PrintBalance();
                account.Owner.PrintCustomerInfo();
                Console.WriteLine();
            }

            // გამოიყენეთ სარგებლის გამოყენება და თვიური სარგებლის დაკლება
            SavingsAccount savingsAccount = accounts[0] as SavingsAccount;
            if (savingsAccount != null)
            {
                savingsAccount.ApplyInterest();
                savingsAccount.PrintBalance();
            }

            CheckingAccount checkingAccount = accounts[1] as CheckingAccount;
            if (checkingAccount != null)
            {
                try
                {
                    checkingAccount.DeductFee();
                    checkingAccount.PrintBalance();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


//პრაქტიკული სამუშაო
//1.შექმენით მშობელი კლასი [Account] შემდეგი ველებითა და მეთოდებით:

//ველები: ანგარიშის ნომერი, ბალანსი, მფლობელი.
//მეთოდები: დეპოზიტის მეთოდი(დეპოზიტი თანხის ანგარიშზე), გატანის მეთოდი(გატანა თანხის ანგარიშიდან), ბალანსის ბეჭდვის მეთოდი.

//2.შექმენით შემდეგი მემკვიდრე კლასები:

//[SavingsAccount] (ანგარიშის ნომერი, ბალანსი, მფლობელი, სარგებლის პროცენტი);
//[CheckingAccount] (ანგარიშის ნომერი, ბალანსი, მფლობელი, თვიური სარგებელი).


//3.შექმენით ანგარიშის მფლობელი კლასის [Customer] და მემკვიდრე კლასების [PersonalCustomer] და[BusinessCustomer] შემდეგი ველებითა და მეთოდებით:

//ველები: სახელი, გვარი, ელ.ფოსტა, ტელეფონი.
//PersonalCustomer: დამატებითი ველი - პირადი ნომერი.
//BusinessCustomer: დამატებითი ველი - კომპანიის დასახელება, საიდენტიფიკაციო ნომერი.


//4.მთავარ პროგრამაში შექმენით ანგარიშის ობიექტების n ელემენტებიანი მასივი. შეავსეთ ინფორმაცია.

//5.გამოიტანეთ ეკრანზე ინფორმაცია ყველა ანგარიშის შესახებ და მათი მფლობელების შესახებ.