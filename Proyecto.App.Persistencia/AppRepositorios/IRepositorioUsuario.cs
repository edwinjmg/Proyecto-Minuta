using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuario();
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);
    }
}