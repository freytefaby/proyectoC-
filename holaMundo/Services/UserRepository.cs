using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using holaMundo.Models;

namespace holaMundo.Services
{
    public class UserRepository
    {
        private User User;
        public UserRepository()
        {
            User = new User();
        }
       

        public List<User> users()
        {
            using (var db = new ConfigContext())
            {
                return db.User.Include(x => x.Profesion).ToList();
            }
        }
        public String Create(User model)
        {
          
            using (var db = new ConfigContext())
            {
       
                this.User.nombre = model.nombre;
                this.User.email = model.email;
                this.User.apellido = model.apellido;
                this.User.add = DateTime.Now;
                this.User.ProfesionFk = model.ProfesionFk;
                db.User.Add(User);
                db.SaveChanges();
                this.User = null;
            }
            return "ok";


        }

    public User userFind(int id)
        {

            using (var db = new ConfigContext())
            {
                this.User = db.User.Find(id);
                return this.User;
              
            }

        }


        public String Editar(User model)
        {

            using (var db = new ConfigContext())
            {
               
                this.User.id = model.id;
                this.User.nombre = model.nombre;
                this.User.email = model.email;
                this.User.apellido = model.apellido;
                this.User.ProfesionFk = model.ProfesionFk;
                db.Entry(this.User).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.User = null;
               
            }
            return "ok";


        }
    }
}