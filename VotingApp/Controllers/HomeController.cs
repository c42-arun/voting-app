using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vote()
        {
            ViewBag.Message = "Choose a candidate for each post";
            ViewBag.CandidateList = CandidateList;

            VotingForm p = BlankVotingForm;

            return View(p);
        }
        [HttpPost]
        public ActionResult Vote(VotingForm e)
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private VotingForm BlankVotingForm
        {
            get
            {
                List<ElectionPost> posts = new List<ElectionPost>(new[] {
                new ElectionPost { Id = 100,
                    Name = "General Secretary"
                },
              new ElectionPost { Id = 101,
                    Name = "Vice President"
                }
            });

                return new VotingForm { Id = 1, Posts = posts };
            }
        }

        private Dictionary<int, List<ElectionCandidate>> CandidateList
        {
            get
            {
                return new Dictionary<int, List<ElectionCandidate>>
                {
                    {
                        100,
                        new List<ElectionCandidate>(new[] {
                            new ElectionCandidate { Id = 0, Name = "<Choose a candidate>" },
                            new ElectionCandidate { Id = 10, Name = "John" },
                            new ElectionCandidate { Id = 11, Name = "Jack" },
                            new ElectionCandidate { Id = 12, Name = "JK" },
                        })
                    },
                    {
                        101,
                        new List<ElectionCandidate>(new[] {
                            new ElectionCandidate { Id = 0, Name = "<Choose a candidate>" },
                            new ElectionCandidate { Id = 13, Name = "Amar" },
                            new ElectionCandidate { Id = 14, Name = "Akbar" },
                            new ElectionCandidate { Id = 15, Name = "Antony" },
                        })
                    },
                };
            }
        }
    }
}