using System;

namespace Proyecto.App.Dominio
{
    public class Usuario
    {
        public int Id{get;set;}
        public string NombreUsuario{get;set;}
        public string Contraseña{get;set;}
        public string Email{get;set;}
        public Tipo TipoUsuario {get;set;}
        
    }
}