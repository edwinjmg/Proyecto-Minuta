using System;

namespace Proyecto.App.Dominio
{
    public class EntradaVehiculo
    {
        public int Id {get;set;}
        public DateTime FechaHoraIngreso {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public Conductor Conductor {get;set;}
        public Pedido Pedido {get;set;}
        
    }
}