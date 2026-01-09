namespace MyNewApp.Models;

class Person
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Address { get; set; } = "";
    public string Mail { get; set; } = "";


    public override string ToString()
    {
        return $"Person Details: Name: {Name}, Age: {Age}, Address:{Address}";
    }
}

static class NewPerson
{
    static NewPerson()
    {
        ID = 90;
    }
    public static int ID { get; set; }
    public static int GetAge()
    {
        return ID;
    }
}
