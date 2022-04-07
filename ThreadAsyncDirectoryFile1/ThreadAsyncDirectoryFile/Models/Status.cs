using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Models
{
    internal class Status
    {
        List<Status> Statuses = new List<Status>();
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public Status (DateTime datatime)
        {
           SharedDate = datatime;
        }


        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
            DateTime sharedtime = DateTime.Now;
        }


    }
}
