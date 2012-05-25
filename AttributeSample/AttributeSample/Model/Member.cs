using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeSample.Attributes;

namespace AttributeSample.Model
{
    public class Member
    {
        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        [ValidAge(18, 70, ErrMsg="Persons age is not in range to be a save biker.")]
        public int Age { get; set; }
    }
}
