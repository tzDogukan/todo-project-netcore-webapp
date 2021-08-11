
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Entities
{
    public class userTask 
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string fileUrl { get; set; }
        public string userId { get; set; }
    }
}
