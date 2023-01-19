using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Design;
using System.Security.Policy;
using System.Xml.Linq;

namespace AgendaContacte.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [Display(Name = "Numele contactului")]
        public string? Nume { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        
    }

} 


