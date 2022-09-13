using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public readonly AppContext _appContext;
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var UsuarioNuevo = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return UsuarioNuevo.Entity;
        }
        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=>u.Id==idUsuario);
            if(UsuarioEncontrado==null)
            return;
            _appContext.Usuarios.Remove(UsuarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuario()
        {
            return _appContext.Usuarios;
        }
        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(u=>u.Id==idUsuario);
        }
        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u=>u.Id==usuario.Id);
            if(UsuarioEncontrado!=null)
            {
                UsuarioEncontrado.NombreUsuario=usuario.NombreUsuario;
                UsuarioEncontrado.Contraseña=usuario.Contraseña;
                UsuarioEncontrado.Email=usuario.Email;
                UsuarioEncontrado.TipoUsuario=usuario.TipoUsuario;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }
    }
}