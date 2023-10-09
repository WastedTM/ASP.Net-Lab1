var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    //Task 1
    var company = new Company("Apple", "One Apple Way Park", 80000);
    
    company.Name = "Apple";
    company.Address = "One Apply Way Park";
    company.Employees = 80000;
    //Task 2
    var random = new Random();
    
    int randomNumber = random.Next(0, 101);
    
    return "Name = " + company.Name + "\nAddress = " + company.Address + "\nEmployers = " + company.Employees + "\nRandom number = " + randomNumber;
});

app.Run();