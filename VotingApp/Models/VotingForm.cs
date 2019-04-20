using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingApp.Models
{
    public class VotingForm
    {
        public int Id { get; set; }
        public List<ElectionPost> Posts { get; set; }
    }
}