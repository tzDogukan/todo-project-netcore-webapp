using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlCenter.WebUI.Models
{
    public class userTaskModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string userId { get; set; }
        public List<userTask> userTasks { get; set; }
        public string fileUrl { get; set; }


    }



}

