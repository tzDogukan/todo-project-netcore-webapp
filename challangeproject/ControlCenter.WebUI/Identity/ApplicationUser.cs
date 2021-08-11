using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlCenter.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string ReferanceNumber { get; set; }
        public string BirthDate { get; set; }
        public string NameSurname { get; set; }
        public string RegisterDate { get; set; }
        public string UserProfilePicture { get; set; }
        public string ContractStatus { get; set; }
        public string AdminActivated { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string WhatsApp { get; set; }
        public string Telegram { get; set; }
    }
}
