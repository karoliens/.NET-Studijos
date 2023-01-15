using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Dto
{
    public class GetClientDTO
    {
        public GetClientDTO()
        {
        }

        public GetClientDTO(Client client)
        {
            Name = client.Name;
            Email = client.Email;
            PhoneNumber = client.PhoneNumber;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
