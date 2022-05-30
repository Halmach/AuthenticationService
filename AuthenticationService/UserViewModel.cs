using System;
using System.Net.Mail;

namespace AuthenticationService
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public bool FromRussia { get; set; }

        public UserViewModel(User user)
        {
            Id = user.Id;
            FullName = String.Concat(user.FirstName, " ", user.LastName);
            FromRussia = GetFromRussiaValue(user.Email);
        }

        public bool GetFromRussiaValue(string email)
        {
            MailAddress mailAddress = new MailAddress(email);

            if (mailAddress.Host.Contains(".ru"))
                return true;
            return false;
        }
        public string GetFullName(string firstName, string lastName)
        {
            return String.Concat(firstName, " ", lastName);
        }
    }
}
