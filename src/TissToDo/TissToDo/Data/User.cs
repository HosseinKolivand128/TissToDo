using System.Collections.Generic;
using TissToDo.Enums;

namespace TissToDo.Data
{
    public class User
    {
        public string FullName { get; set; }

        public string PublicName { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Organisation { get; set; }
        public string BasedIn { get; set; }

        public List<Email> Emails { get; set; }
        public List<Phone> phones { get; set; }
    }
    public class Email
    {
        public string Name { get; set; }
        public CanSee CanSee { get; set; }
    }
    public class Phone
    {
        public string PhoneNumber { get; set; }
        public CanSee CanSee { get; set; }
    }

}
