using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        public string Title { get; set; } = "";

        public List<JobFieldType> Columns { get; set; }

        public JobFieldType Column { get; set; }   //<---How to address assignment of value to All in SJVM?


        public void PopulateColumnList()   // <--Do I need a parameter here?
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
