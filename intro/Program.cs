// See https://aka.ms/new-console-template for more information
//double total = 0;
//while (true)
//{

//    double last = 0;
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Toplam:" + total);
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.Write("Toplanacak sayıyı giriniz: ");
//    bool isDouble = double.TryParse(Console.ReadLine(), out last);
//    if (isDouble)
//    {
//        total += last;
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Lütfen sadece sayı giriniz.");
//        Console.ReadKey();
//    }
//}

//string[] loans = { "kredi1", "kredi2", "kredi3", "kredi4", "kredi5", "kredi6" };
////string[] loans2 = new string[6];
////loans2[2] = "test";

//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[i]);
//}

using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;

CourseManager courseManager = new(new DapperCourseDal());


List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price + " / " + courses[i].Description);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123456789";
customer1.FirstName = "Burak";
customer1.LastName = "Orucoglu";
customer1.CustomerNumber = "1234561";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "987654321";
customer2.FirstName = "Serenay";
customer2.LastName = "Orucoglu";
customer2.CustomerNumber = "6543211";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.TaxNumber = "1234567890";
customer3.CustomerNumber = "0123789";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 3;
customer4.Name = "BT";
customer4.TaxNumber = "9876543210";
customer4.CustomerNumber = "6549870";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

