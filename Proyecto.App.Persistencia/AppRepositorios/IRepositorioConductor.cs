using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia.AppRepositorios
{
    public interface IRepositorioConductor
    {
        IEnumerable<Conductor> MostrarConductores();
        Conductor AgregarConductor(Conductor conductor);
        Conductor ActualizarConductor(Conductor conductor);
        void EliminarConductor(int idConductor);
        Conductor MostrarConductor(int idConductor);
    }
}