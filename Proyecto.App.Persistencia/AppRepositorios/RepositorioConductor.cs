using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public class RepositorioConductor : IRepositorioConductor
    {
        public readonly AppContext _appContext;
        public RepositorioConductor(AppContext appContext)
        {
            _appContext = appContext;
        }
        Conductor IRepositorioConductor.AgregarConductor(Conductor Conductor)
        {
            var ConductorNuevo = _appContext.Conductores.Add(Conductor);
            _appContext.SaveChanges();
            return ConductorNuevo.Entity;
        }
        void IRepositorioConductor.EliminarConductor(int idConductor)
        {
            var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(u=>u.Id==idConductor);
            if(ConductorEncontrado==null)
            return;
            _appContext.Conductores.Remove(ConductorEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Conductor> IRepositorioConductor.MostrarConductores()
        {
            return _appContext.Conductores;
        }
        Conductor IRepositorioConductor.MostrarConductor(int idConductor)
        {
            return _appContext.Conductores.FirstOrDefault(c=>c.Id==idConductor);
        }
        Conductor IRepositorioConductor.ActualizarConductor(Conductor Conductor)
        {
            var ConductorEncontrado = _appContext.Conductores.FirstOrDefault(c=>c.Id==Conductor.Id);
            if(ConductorEncontrado!=null)
            {
                ConductorEncontrado.Cedula=Conductor.Cedula;
                ConductorEncontrado.Nombre=Conductor.Nombre;
                ConductorEncontrado.Apellido=Conductor.Apellido;
                ConductorEncontrado.Celular=Conductor.Celular;
                _appContext.SaveChanges();
            }
            return ConductorEncontrado;
        }
    }
}