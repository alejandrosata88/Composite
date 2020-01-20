using Composicion.Entidad;
using Composicion.Servicio.Interfaz;
using System;
using System.Collections.Generic;

namespace Composicion.Servicio.Implementacion
{
    public class ClaseComposicion : IComponente
    {
        public ImportesUnidad ImportesUnidad { get; set; }

        protected List<IComponente> lstHijos = new List<IComponente>();

        public ClaseComposicion(ImportesUnidad _ImportesUnidad)
        {
            this.ImportesUnidad = _ImportesUnidad;
        }

        public int ObtenerImporteUnidad()
        {
            int iMonto = 0;
            foreach (IComponente IComponente in this.lstHijos)
            {
                iMonto += IComponente.ObtenerImporteUnidad();
                Console.Write("{0} : {1}\n", IComponente.ImportesUnidad.cUnidad, iMonto);

            }
            return iMonto;
        }

        public void Agregar(IComponente _IComponente)
        {
            this.lstHijos.Add(_IComponente);
        }

        public void Remover(IComponente _IComponente)
        {
            this.lstHijos.Remove(_IComponente);
        }

        public List<IComponente> ObtenerHijos()
        {
            return this.lstHijos;
        }
    }
}
