using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingApp.Models
{
    public class ElectionCandidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Voted { get; set; }
    }
}