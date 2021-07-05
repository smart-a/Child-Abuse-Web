using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAbuse.Model
{
    public class WhistleBlower
    {
        public WhistleBlower()
        {
            Id = Guid.NewGuid();
            BlowDate = DateTime.Now;
        }

        public Guid Id { set; get; }
        public string What { set; get; }
        public string When { set; get; }
        public string Where { set; get; }
        public string Who { set; get; }
        public string Contact { set; get; }
        public DateTime BlowDate { set; get; }
    }

    public class WhistleBlowerString
    {
        public Guid Id { set; get; }
        public string WhatHappend { set; get; }
        public string When { set; get; }
        public string Where { set; get; }
        public string WhoInvolved { set; get; }
        public string WhistleBlowerContact { set; get; }
        public string SubmittedOn { set; get; }
    }
}