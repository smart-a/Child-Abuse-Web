using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAbuse.Model
{
    public class Victim
    {
        public Victim()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string VictimName { set; get; }
        public string VictimGender { set; get; }
        public int VictimAge { set; get; }
    }
}