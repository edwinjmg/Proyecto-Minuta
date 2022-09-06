using System;

namespace Proyecto.App.Dominio
{
    public class EntradaVehiculo
    {
        public int EntradaVehiculoId {get;set;}
        public DateTime FechaHoraIngreso {get;set;}
        public int VehiculoId {get;set;}
        public int ConductorId {get;set;}
        public int PedidoId {get;set;}
        
    }
}