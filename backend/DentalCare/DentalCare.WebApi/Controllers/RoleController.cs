using DentalCare.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentalCare.WebApi.Controllers
{
    public class RoleController : ApiController
    {

        DentalCareEntities dentalCareEntities = new DentalCareEntities();

        public IEnumerable<role> GetRoles()
        {
            var listRoles = dentalCareEntities.roles.ToList();
            return listRoles;
        }

        public role GetRole(int id)
        {
            role rol = dentalCareEntities.roles.Find(id);
            //usuario.person = null;
            return rol;
        }

        [HttpPost]
        public void PostRole([FromBody] role value)
        {
            dentalCareEntities.roles.Add(value);
            dentalCareEntities.SaveChanges();
        }

        [HttpPut]
        public void UpdateRole(role value)
        {
            role rol = dentalCareEntities.roles.Find(value.id);
            
            rol.name = value.name;
            rol.description = value.description;
            dentalCareEntities.Entry(rol).State = System.Data.Entity.EntityState.Modified;
            dentalCareEntities.SaveChanges();
        }

        [HttpDelete]
        public void DeleteRole(role value)
        {
            role rol = dentalCareEntities.roles.Find(value.id);
            dentalCareEntities.roles.Remove(rol);
            dentalCareEntities.SaveChanges();
        }

    }
}
