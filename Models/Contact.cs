using System.ComponentModel.DataAnnotations;

namespace MyNewApp.Models;

class Contact
{
    public Guid ID { get; set; }
    public string? Name { get; set; }
    public string? PhoneNo { get; set; }

}