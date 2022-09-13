using System;

namespace Proyecto.App.Dominio
{
    public class SalidaVehiculo
    {
        public int Id {get;set;}
        public DateTime FechaHoraSalida {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public Conductor Conductor {get;set;}
        public Pedido Pedido {get;set;}
    }
}