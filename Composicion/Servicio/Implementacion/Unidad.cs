using Composicion.Entidad;
using Composicion.Servicio.Interfaz;
using System;

namespace Composicion.Servicio.Implementacion
{
    class Unidad : IComponente
    {
        public ImportesUnidad ImportesUnidad { get; set; }

        public Unidad(ImportesUnidad _ImportesUnidad)
        {
            this.ImportesUnidad = _ImportesUnidad;
        }

        public int ObtenerImporteUnidad()
        {
            int iMonto = 0;
            iMonto=this.ImportesUnidad.iMesEnero + this.ImportesUnidad.iMesFebrero + this.ImportesUnidad.iMesMarzo;
            return iMonto;
        }
    }
}
