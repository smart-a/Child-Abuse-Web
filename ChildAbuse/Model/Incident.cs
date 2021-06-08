using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAbuse.Model
{
    public class Incident
    {
        public Incident()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { set; get; }
        public string Category { set; get; }
        public DateTime? Date { set; get; }
        public string CrimeLocation { set; get; }
        public string CrimeDescription { set; get; }
        public virtual Victim Victim { set; get; }
        public virtual Curprit Curprit { set; get; }
    }

    public class IncidentDisplay
    {
        public Guid Id { set; get; }
        public string Category { set; get; }
        public string Date { set; get; }
        public string CrimeLocation { set; get; }
        public string CrimeDescription { set; get; }

        public string VictimName { set; get; }
        public string VictimGender { set; get; }
        public int VictimAge { set; get; }

        public string CurpritName { set; get; }
        public string CurpritGender { set; get; }
        public int CurpritAge { set; get; }
        public string CurpritAddress { set; get; }
    }
}