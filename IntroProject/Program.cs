using IntroProject.Business;
using IntroProject.DataAccess.Abstracts;
using IntroProject.DataAccess.Concretes;
using IntroProject.Entities;


//variables -->camelCase

string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAuthenticated = true;
Console.WriteLine(message1);

if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Ahmet");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new CourseManager(new DapperCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Ahmet Fahri";
customer1.LastName = "GUNEY";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Customer";
customer2.LastName = "Customer";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Aydın";

Console.WriteLine(cities2[0]);

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}