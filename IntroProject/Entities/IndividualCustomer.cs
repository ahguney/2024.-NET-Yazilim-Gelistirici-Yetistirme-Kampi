using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject.Entities
{
    public class IndividualCustomer : BaseCustomer
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? NationalIdentity { get; set; }

    }
}
