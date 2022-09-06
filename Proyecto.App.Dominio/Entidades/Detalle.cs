using System;

namespace Proyecto.App.Dominio
{
    public class Detalle
    {
        public int DetalleId {get;set;}
        public int PedidoId {get;set;}
        public int ProductoId {get;set;}
        public int Cantidad {get;set;}
        
    }
}