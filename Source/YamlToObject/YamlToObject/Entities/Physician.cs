using System;

namespace YamlToObject.Entities
{
    public class Physician
    {
        public Guid Id { get; set; }
        public string ObjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Clinic { get; set; }
    }
}