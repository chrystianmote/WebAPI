namespace WebAPI.AutoMapper.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string FullAddress { get; set; }
    }
}
