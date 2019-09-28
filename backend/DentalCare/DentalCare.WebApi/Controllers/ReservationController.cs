using DentalCare.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DentalCare.WebApi.Controllers
{
    public class ReservationController : ApiController
    {

        DentalCareEntities dentalCareEntities = new DentalCareEntities();

        public IEnumerable<reservation> GetReservations()
        {
            var listReservation = dentalCareEntities.reservations.ToList();
            return listReservation;
        }

        public reservation GetReservation(int id)
        {
            reservation reservacion  = dentalCareEntities.reservations.Find(id);
            return reservacion;
        }

        [HttpPut]
        public void UpdateReservation(reservation value)
        {
            reservation cita = dentalCareEntities.reservations.Find(value.id);

            cita.reservation_date = value.reservation_date;
            cita.estatus = value.estatus;
            cita.observation = value.observation;
            cita.idDentalPiece = value.idDentalPiece;
            cita.idDentist = value.idDentist;
            cita.idPacient = value.idPacient;
            cita.idTreatment = value.idTreatment;
            dentalCareEntities.Entry(cita).State = System.Data.Entity.EntityState.Modified;
            dentalCareEntities.SaveChanges();
        }

        [HttpDelete]
        public void DeleteReservation(reservation value)
        {
            reservation cita = dentalCareEntities.reservations.Find(value.id);
            dentalCareEntities.reservations.Remove(cita);
            dentalCareEntities.SaveChanges();
        }

    }
}
