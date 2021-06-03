using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAbuse.Model
{
    public class Curprit
    {
        public Curprit()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string CurpritName { set; get; }
        public string CurpritGender { set; get; }
        public int CurpritAge { set; get; }
        public string CurpritAddress { set; get; }
}
}