using Composicion.Entidad;

namespace Composicion.Servicio.Interfaz
{
    public interface IComponente
    {
        ImportesUnidad ImportesUnidad { get; set; }
        int ObtenerImporteUnidad();
    }
}
