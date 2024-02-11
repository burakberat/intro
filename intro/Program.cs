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
using intro.Entities;

CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}