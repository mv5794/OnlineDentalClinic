using DentalCare.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentalCare.WebApi.Controllers
{

    public class UserController : ApiController
    {
        DentalCareEntities dentalCareEntities = new DentalCareEntities();

        public IEnumerable<user> GetUsers()
        {
            var listUser = dentalCareEntities.users.ToList();
            return listUser;
        }

        public user GetUser(int id)
        {
            user usuario  = dentalCareEntities.users.Find(id);
            //usuario.person = null;
            return usuario;
        }

        [HttpPost]
        public void CreateUser(user value)
        {
            dentalCareEntities.users.Add(value);
            dentalCareEntities.SaveChanges();
        }


        [HttpPut]
        public void UpdateUser(user value)
        {
            user usuario = dentalCareEntities.users.Find(value.id);

            usuario.cod_user = value.cod_user;
            usuario.idPerson = value.idPerson;
            usuario.password = value.password;
            dentalCareEntities.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            dentalCareEntities.SaveChanges();
        }

        [HttpDelete]
        public void DeleteUser(user value)
        {
            user usuario = dentalCareEntities.users.Find(value.id);
            dentalCareEntities.users.Remove(usuario);
            dentalCareEntities.SaveChanges();
        }

    }
}
