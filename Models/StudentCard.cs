using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleIT.Models
{
    public class StudentCard
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentImage { get; set; }
        public string UserName { get; set; }
        public string BirthDate { get; set; }
        public string School { get; set; }
        public string EndDate { get; set; }

        public string Username { get; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
