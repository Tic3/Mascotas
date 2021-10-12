using System;
namespace MascotasWeb.App.Dominio
{
    public class Visitas
    {
        public Mascota Mascota {get;set;}
        public Empleado Empleado {get;set;}
        public string fechaVisita {get;set;}
        public string temperatura {get;set;}
        public string peso {get;set;}
        public int idMascota{get;set;}
        public int idCliente{get;set;}
        public string recomendaciones {get;set;}
    }
}