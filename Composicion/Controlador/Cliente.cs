using Composicion.Entidad;
using Composicion.Servicio.Implementacion;
using Composicion.Servicio.Interfaz;
using System;

namespace Composicion.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            int iMontoTotal = 0;
            string cMensaje = string.Empty;
            //UAX
            ClaseComposicion claseComposicionX = new ClaseComposicion(AgregarImporteUnidad("UAX", 0, 0, 0));
            //1
            ClaseComposicion claseComposicion1 = new ClaseComposicion(AgregarImporteUnidad("UA1", 0, 0, 0));
            //1.1
            ClaseComposicion claseComposicion1_1 = new ClaseComposicion(AgregarImporteUnidad("UA1.1", 0, 0, 0));           
            //1.1.1
            IComponente iComponenteUnidad1_1_1 = new Unidad(AgregarImporteUnidad("UA1.1.1",1,1,1));
            claseComposicion1_1.Agregar(iComponenteUnidad1_1_1);

            IComponente iComponenteUnidad1_1 = claseComposicion1_1;
            claseComposicion1.Agregar(iComponenteUnidad1_1);

            IComponente iComponenteUnidad1 = claseComposicion1;
            claseComposicionX.Agregar(iComponenteUnidad1);

            //2
            ClaseComposicion claseComposicion2 = new ClaseComposicion(AgregarImporteUnidad("UA2", 0, 0, 0));
            //2.1
            ClaseComposicion claseComposicion2_1 = new ClaseComposicion(AgregarImporteUnidad("UA2.1", 0, 0, 0));
            //2.1.1
            IComponente iComponenteUnidad2_1_1 = new Unidad(AgregarImporteUnidad("UA2.1.1", 2, 2, 2));
            claseComposicion2_1.Agregar(iComponenteUnidad2_1_1);

            IComponente iComponenteUnidad2_1 = claseComposicion2_1;
            claseComposicion2.Agregar(iComponenteUnidad2_1);

            IComponente iComponenteUnidad2 = claseComposicion2;
            claseComposicionX.Agregar(iComponenteUnidad2);

            //3
            ClaseComposicion claseComposicion3 = new ClaseComposicion(AgregarImporteUnidad("UA3", 0, 0, 0));
            //3.1
            IComponente iComponenteUnidad3_1 = new Unidad(AgregarImporteUnidad("UA3.1", 3, 3, 3));
            claseComposicion3.Agregar(iComponenteUnidad3_1);

            IComponente iComponenteUnidad3 = claseComposicion3;
            claseComposicionX.Agregar(iComponenteUnidad3);

            //3.1
            IComponente iComponenteUnidad4 = new Unidad(AgregarImporteUnidad("UA4", 4, 4, 4));
            claseComposicionX.Agregar(iComponenteUnidad3);

            iMontoTotal =claseComposicionX.ObtenerImporteUnidad();
            Console.WriteLine(string.Format("Impote Total: {0}", iMontoTotal));
            Console.ReadLine();
        }

        public ImportesUnidad AgregarImporteUnidad(string _cUnidad,int _iMesEnero, int _iMesFebrero, int _iMesMarzo)
        {
            ImportesUnidad importesUnidad = new ImportesUnidad();
            importesUnidad.cUnidad = _cUnidad;
            importesUnidad.iMesEnero = _iMesEnero;
            importesUnidad.iMesFebrero = _iMesFebrero;
            importesUnidad.iMesMarzo = _iMesMarzo;
            return importesUnidad;
        }
    }
}
