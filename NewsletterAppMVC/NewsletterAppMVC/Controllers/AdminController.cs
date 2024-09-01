using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //Lambda syntax

                var signups = (from c in db.SignUps //LINQ Language Integrated Query
                               where c.Removed == null
                               select c).ToList();
                var signupVMs = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVm);
                }
                return View(signupVMs);

                //This way uses ADO.NET. It is a longer way to accomplish what we accomplished above
                //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";
                //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);

                //    connection.Open();

                //    SqlDataReader reader = command.ExecuteReader();

                //    while (reader.Read())
                //    {
                //        var signup = new NewsletterSignUp();
                //        signup.Id = Convert.ToInt32(reader["Id"]);
                //        signup.FirstName = reader["FirstName"].ToString();
                //        signup.LastName = reader["LastName"].ToString();
                //        signup.EmailAddress = reader["EmailAddress"].ToString();
                //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                //        signups.Add(signup);
                //    }
                //}
                //var signupVMs = new List<SignupVm>();
                //foreach (var signup in signups)
                //{
                //    var signupVm = new SignupVm();
                //    signupVm.FirstName = signup.FirstName;
                //    signupVm.LastName = signup.LastName;
                //    signupVm.EmailAddress = signup.EmailAddress;
                //    signupVMs.Add(signupVm);
                //}

                //return View(signupVMs);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); //Find() helpful for grabbing row that has a particular Id
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}