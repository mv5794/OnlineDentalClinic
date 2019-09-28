using DentalCare.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentalCare.WebApi.Controllers
{
    public class PersonController : ApiController
    {

        DentalCareEntities dentalCareEntities = new DentalCareEntities();

        public IEnumerable<person> GetPersons()
        {
            var listPerson  = dentalCareEntities.persons.ToList();
            return listPerson;
        }

        public person  GetPerson(int id)
        {
            person persona = dentalCareEntities.persons.Find(id);
            return persona;
        }

        [HttpPost]
        public void CreatePerson(person value)
        {
            dentalCareEntities.persons.Add(value);
            dentalCareEntities.SaveChanges();
        }

        [HttpPut]
        public void UpdatePerson(person value)
        {
            person persona = dentalCareEntities.persons.Find(value.id);

            persona.name = value.name;
            persona.lastname = value.lastname;
            persona.dni = value.dni;
            persona.phone = value.phone;
            persona.picture = value.picture;
            persona.gender = value.gender;
            persona.idRole = value.idRole;
            persona.address = value.address;
            dentalCareEntities.Entry(persona).State = System.Data.Entity.EntityState.Modified;
            dentalCareEntities.SaveChanges();
        }

        [HttpDelete]
        public void DeletePerson(person value)
        {
            person persona = dentalCareEntities.persons.Find(value.id);
            dentalCareEntities.persons.Remove(persona);
            dentalCareEntities.SaveChanges();
        }
    }
}
