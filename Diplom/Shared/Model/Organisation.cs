using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Shared.Model
{
    class Organisation
    {
        public int UNK { get; set; }
        public string Name { get; set; }
        public string Principal { get; set; }
        public string Address { get; set; }

        public Organisation HigherOrg { get; set; }
    }
}
