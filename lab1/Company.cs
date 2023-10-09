public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Employees { get; set; }
    
    public int RandomNumber { get; set; }
    
    public Company(string name, string address, int employees)
    {
        Name = name;
        Address = address;
        Employees = employees;
    }
    
    
}