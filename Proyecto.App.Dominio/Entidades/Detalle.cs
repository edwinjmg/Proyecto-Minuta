using System;

namespace Proyecto.App.Dominio
{
    public class Detalle
    {
        public int Id {get;set;}
        public Pedido Pedido {get;set;}
        public Producto Producto {get;set;}
        public int Cantidad {get;set;}
        
    }
}