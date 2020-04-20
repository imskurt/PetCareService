using System;
//test commit
[MariahCurtis].CodeLou.PetCareService
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueRunning = "Y";
            while (continueRunning == "Y")
            {
               InputEmployee();
               Console.WriteLine("DO you want to add another employee? (Y/N)");
               continueRunning = Console.ReadLine();
            }
            Console.ReadKey();
        }

        static void InputEmployee() 
{
    Console.WriteLine("Enter Employee");
    var employeeId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter First Name");
    employeeFirstName = Console.ReadLine();
    Console.WriteLine("Enter Last Name");
    employeeLastNamele.ReadLine();
    Console.WriteLine("Enter Phone Number");
    var phoneNumber = Console.ReadLine();
    Console.WriteLine("Enter Email Address");
    var emailAddress = Console.ReadLine();
    Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
    var startDate = DateTimeOffset.Parse(Console.ReadLine());

    var employeeRecord = new Employee();
    employeeRecord.StudentId = employeeId;
    employeeRecord.FirstName = employeeFirstName;
    employeeRecord.LastName = employeeLastName;
    employeeRecord.phoneNumber = phoneNumber;
    employeeRecord.emailAddress = emailAddress;
    employeeRecord.StartDate = startDate;
    Console.WriteLine($"Employee Id | Name |  Phone Number "); ;
    Console.WriteLine($"{employeeRecord.StudentId} | {employeeRecord.FirstName} {employeeRecord.LastName} | {employeeRecord.phoneNumber} "); ;
    Console.ReadKey();

    }
}   
//test comment