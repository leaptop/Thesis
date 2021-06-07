using _012.Data;
using _012.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace _012.Controllers
{
    public class CardController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
       // private readonly IEmailSenderService _emailSender;
      //  private readonly ILogger _logger;

        private readonly ApplicationDbContext _db;

        public CardController(ApplicationDbContext db,//dependency injection here
            UserManager<IdentityUser> userManager,
             SignInManager<IdentityUser> signInManager//,
            // IEmailSenderService emailSender,
            // ILogger<AccountController> logger
            )
        {
            _db = db;//now we can use our database in this controller

            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            IEnumerable<Card> objList = _db.CardT;
            //have retrieved contents of the table CardT
            return View(objList);//have passed the contents to our view
        }
        //GET-create
        public IActionResult Create()
        {
            return View();
        }

        //POST-create
        [HttpPost]
        [ValidateAntiForgeryToken]//Checks if we still have a token, if we are still logged in
        public IActionResult Create(Card obj)
        {
            /*SignInManager<IdentityUser> SignInManager;
            UserManager<IdentityUser> UserManager;*/
            var user =  _userManager.GetUserAsync(User);
            obj.CardHolderId = user.Result.Id.ToString();
            _db.CardT.Add(obj);//obviously adding the newly created writing to our db
            _db.SaveChanges();//obviously saving changes to our db
            return RedirectToAction("Index");//obviously just call another action
        }
    }
}
