using System.Collections.Generic;
using System.Linq;
using holaMundo.Models;

namespace holaMundo.Services
{
    public class ProfesionRepository
    {

        public List<Profesion> profesion()
        {
            using (var db = new ConfigContext())
            {
                return db.Profesion.ToList();
            }
        }
        
    }
}