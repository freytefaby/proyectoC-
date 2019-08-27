using holaMundo.Models;
using holaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace holaMundo.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _repo;
        private ProfesionRepository profesionList;

        public UserController()
        {
            _repo = new UserRepository();
            profesionList = new ProfesionRepository();
        }
        // GET: User
        public ActionResult Index()
        {
            var model = _repo.users();
           
            return View(model);
        }

       public ActionResult Create()
        {
            var model = profesionList.profesion();
            ViewBag.profesion = model;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User model)
        {
            try
            {

                if(ModelState.IsValid)
                {
                    _repo.Create(model);
                    return Redirect("/User");

                }
                return View(model);
               
            }
            catch(Exception e)
            {

                ViewBag.error = e.Message;
                var profesion = profesionList.profesion();
                ViewBag.profesion = profesion;
                return View(model);
                
            }

        }

       public ActionResult Edit(int id)
        {
            var profesion = profesionList.profesion();
            ViewBag.profesion = profesion;
            var model = _repo.userFind(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User model)
        {
            
                if (ModelState.IsValid)
                {
                    _repo.Editar(model);
                    return Redirect("/err");

                }
                return View("dposa");

            
          

        }




    }
}
