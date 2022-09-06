using System;

namespace Proyecto.App.Dominio
{
    public class SalidaVehiculo
    {
        public int SalidaVehiculoId {get;set;}
        public DateTime FechaHoraSalida {get;set;}
        public int VehiculoId {get;set;}
        public int ConductorId {get;set;}
        public int PedidoId {get;set;}
    }
}