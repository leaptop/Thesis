using _012.Data;
using _012.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _012.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountsController(ApplicationDbContext db)//dependency injection here
        {
            _db = db;//now we can use our database in this controller
        }

        public IActionResult Index()
        {
            IEnumerable<Accounts> objList = _db.AccountsT;
            //have retrieved contents of the table AccountsT
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
        public IActionResult Create(Accounts obj)
        {
            _db.AccountsT.Add(obj);//obviously adding the newly created writing to our db
            _db.SaveChanges();//obviously saving changes to our db
            return RedirectToAction("Index");//obviously just call another action
        }
    }
}
