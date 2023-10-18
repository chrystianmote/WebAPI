using WebAPI.AutoMapper.Enums;

namespace WebAPI.AutoMapper.Models
{
    public class PersonInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string FullAddress { get; set; }
    }
}
