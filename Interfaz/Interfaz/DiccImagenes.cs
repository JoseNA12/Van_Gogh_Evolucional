using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class DiccImagenes
    {
        public Dictionary<int, Imagen> crearGeneracion(Imagen[] listaImagenes, Imagen pImgMeta)
        {
            Dictionary<int, Imagen> nuevaGeneracion = new Dictionary<int, Imagen>();
        
            for (int x = 0; x < listaImagenes.Length; x++)
            {
                if (AlgoritmoGenetico.AGenetico.opcionAEjecutar=="ManhattanColor") {
                    listaImagenes[x].CalcularDistanciaManhattanColor(listaImagenes[x], pImgMeta);
                    nuevaGeneracion.Add(x, listaImagenes[x]);
                }
                else if (AlgoritmoGenetico.AGenetico.opcionAEjecutar == "ManhattanPropio")
                {
                    listaImagenes[x].CalcularDistanciaManhattanPropia(listaImagenes[x], pImgMeta);
                    nuevaGeneracion.Add(x, listaImagenes[x]);
                }
                else if (AlgoritmoGenetico.AGenetico.opcionAEjecutar == "PropioColor")
                {
                    listaImagenes[x].CalcularDistanciaPropiaColor(listaImagenes[x], pImgMeta);
                    nuevaGeneracion.Add(x, listaImagenes[x]);
                }
                else if (AlgoritmoGenetico.AGenetico.opcionAEjecutar == "PropioPropio")
                {
                    listaImagenes[x].CalcularDistanciaPropiaPropia(listaImagenes[x], pImgMeta);
                    nuevaGeneracion.Add(x, listaImagenes[x]);
                }
            }
            return nuevaGeneracion;
        }

        public Imagen[] retornaListaGeneracion(Dictionary<int, Imagen> diccionario)
        {
            Imagen[] listaRetorno = new Imagen[AlgoritmoGenetico.AGenetico.poblacionInicial];
            int x = 0;
            while(x < AlgoritmoGenetico.AGenetico.poblacionInicial)
            {
                if (diccionario.ContainsKey(x))
                {
                    listaRetorno[x] = diccionario[x];
                }
                else
                {
                    break;
                }
                x++;
            }
            return listaRetorno;
        }

        

    }
}
