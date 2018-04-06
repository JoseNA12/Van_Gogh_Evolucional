using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class AlgoritmoGenetico
    {
        //Parametros del usuario
        public int poblacionInicial;
        public int probabilidadMutacion;
        public int porcentajeMenosAptos;
        public int porcentajeMutacionImg;
        public int cantidadGeneraciones;
        public int cantidadQueBaja;
        public int cantPixelsAMutar;
        public string opcionAEjecutar;

        //Ruta para guardar la imagen
        public string rutaGuardar = "";

        //Imagen a la cual se desea llegar
        public Imagen imagenMeta;

        //Lista donde se guardan todas las generaciones y su contador
        public Dictionary<int, Imagen>[] ListaDeGeneraciones;

        //Contador para la lista de generaciones
        public int controlaListaGeneraciones = 0;


        public Imagen[] listaMejoresImagenes;//Lista que contendra la mejor imagen de cada generacion
        //Objeto diccionario que calculará la distancia a cada imagen de la generacion y las devolverá en un Dictionary<int,Imagen>
        public DiccImagenes diccionarioImgs = new DiccImagenes();

        // Randoms que se usan en el programa
        public Random randPrimeraPoblacion = new Random();
        public Random randCruce = new Random();
        public Random randElijeImgAMutar = new Random();
       
        //Creacion del objeto AGenetico para instanciarlo
        public static AlgoritmoGenetico AGenetico;


        //Procedimiento que crea la primer poblacion (imagenes random)
        public void crearImgsPoblacionInicial()
        {
            Imagen[] listaPoblacionInicial = new Imagen[poblacionInicial];
            Bitmap NuevaImagen = new Bitmap(imagenMeta.img.Width, imagenMeta.img.Height);

            int r, g, b;
            int i = 0;
            while (i != poblacionInicial)
            {
                for (int x = 0; x < NuevaImagen.Width; x++)
                {
                    for (int y = 0; y < NuevaImagen.Height; y++)
                    {
                        r = randPrimeraPoblacion.Next(0, 255);
                        g = randPrimeraPoblacion.Next(0, 255);
                        b = randPrimeraPoblacion.Next(0, 255);

                        Color pixelColor = NuevaImagen.GetPixel(x, y);
                        Color newColor = Color.FromArgb(r, g, b);
                        NuevaImagen.SetPixel(x, y, newColor);
                    }
                }
                Imagen imagenAux = new Imagen(NuevaImagen);
                listaPoblacionInicial[i] = imagenAux;
                i++;
            }
            Dictionary<int, Imagen> nuevaGeneracion; ;
            nuevaGeneracion = diccionarioImgs.crearGeneracion(listaPoblacionInicial, imagenMeta);
            ListaDeGeneraciones = new Dictionary<int, Imagen>[cantidadGeneraciones];
            ListaDeGeneraciones[controlaListaGeneraciones] = nuevaGeneracion;
            controlaListaGeneraciones++;
        }

        //Algoritmo genético
        public void Algoritmo()
        {
            cantPixelsAMutar = (int)((porcentajeMutacionImg * (imagenMeta.img.Height * imagenMeta.img.Width)) / 100);
            cantidadQueBaja = (int)(porcentajeMenosAptos * poblacionInicial) / 100;
            this.crearImgsPoblacionInicial();
            int cuentaGeneraciones = 1;

            while (cuentaGeneraciones < AlgoritmoGenetico.AGenetico.cantidadGeneraciones) // Empieza el algoritmo genético, el cual se ejecutará hasta que se terminen las generaciones
            {
                Dictionary<int, Imagen> nuevaGeneracion;
                Imagen[] listaPadresImagenes = diccionarioImgs.retornaListaGeneracion(ListaDeGeneraciones[controlaListaGeneraciones - 1]);// Reste 1 al indice
                Imagen[] ListaHijos = CreaHijos(listaPadresImagenes);
                Bitmap[] guardaHijos = AGenetico.retornaListaBMPs(ListaHijos);

                
                nuevaGeneracion = diccionarioImgs.crearGeneracion(ListaHijos, imagenMeta);
                ListaDeGeneraciones[controlaListaGeneraciones] = nuevaGeneracion;
                controlaListaGeneraciones++;

                cuentaGeneraciones++;
            }
            //Bitmap[] primeraGen = AGenetico.retornaListaBMPs(diccionarioImgs.retornaListaGeneracion(ListaDeGeneraciones[0]));
            //Bitmap[] ultimaGen = AGenetico.retornaListaBMPs(diccionarioImgs.retornaListaGeneracion(ListaDeGeneraciones[controlaListaGeneraciones - 1]));
            listaMejoresImagenes=RetornaListaMejoresImagenes();
            crearImagen(listaMejoresImagenes);
            //AGenetico.guardarBMPS2(listaMejoresImagenes);
            //AGenetico.guardarBMPS(ultimaGen);

        }


       
        public void guardarBMPS2(Imagen[] lista)
        {
            for (int x = 0; x < lista.Length; x++)
            {
                lista[x].img.Save("C:\\Users\\JCO35\\Desktop\\Análisis de Algoritmos\\IMGSpruebas2\\" + x.ToString() + ".jpg");

            }
        }
        //Funcion que se utiliza para guardar las imagenes de la lista de imagenes que tiene por parametro
        public void guardarBMPS(Bitmap[] lista)
        {
            for (int x = 0; x < lista.Length; x++)
            {
                lista[x].Save("C:\\Users\\JCO35\\Desktop\\Análisis de Algoritmos\\IMGSPruebas\\" + x.ToString() + ".jpg");

            }
        }


        // Funcion que recibe una lista de objetos tipo Imagen, y devuelve los bmp de cada imagen
        public Bitmap[] retornaListaBMPs(Imagen[] listaImagenes)
        {
            Bitmap[] listaBMPs = new Bitmap[listaImagenes.Length];
            for (int x = 0; x < listaImagenes.Length ; x++)
            {
                listaBMPs[x] = listaImagenes[x].img;
            }
            return listaBMPs;
        }

        // Funcion que retorna la nueva generacion de imagenes a partir de la anterior
        public Imagen[] CreaHijos(Imagen[] listaPadres)
        {
            Imagen[] listaHijos = new Imagen[poblacionInicial];
            int i = 0;
            if (cantidadQueBaja == 0)
            {
                for (i = 0; i < listaPadres.Length; i++)
                {
                    listaHijos[i] = CruzarImagenesHistograma(listaPadres[randCruce.Next(0, poblacionInicial - 1)], listaPadres[randCruce.Next(0, poblacionInicial - 1)], imagenMeta);
                    
                }
                listaHijos = Mutaciones(listaHijos);
            }
            else
            {
                while (i != cantidadQueBaja)
                {
                    listaHijos[i] = listaPadres[randCruce.Next(0, poblacionInicial - 1)];
                    i++;
                }

                for (int x = i; x < listaPadres.Length; x++)
                {
                    listaHijos[x] = CruzarImagenesHistograma(listaPadres[randCruce.Next(0, poblacionInicial - 1)], listaPadres[randCruce.Next(0, poblacionInicial - 1)], imagenMeta);
                    
                }
                listaHijos = Mutaciones(listaHijos);
            }

            return listaHijos;
        }

        public int MutarPixel(int a, int meta)
        {
            int retorno = 0;

            if (a - meta > 0 )
            {
                if (a - meta > 100)
                {
                    retorno = a - 30;
                }
                else if(a-meta < 100 && a - meta > 20)
                {
                    retorno = a - 20;
                }
                else if (a-meta < 20)
                {
                    if (a - meta != 1)
                    {
                        retorno = a - 2;
                    }
                }
                
                return retorno; 
            }
            else if (a - meta < 0)
            {
                if (a - meta < -100)
                {
                    retorno = a + 30;
                }            
                else if(a-meta>-100 && a - meta < -20)
                {
                    retorno = a + 20;
                }               
                else if (a - meta < -20)
                {
                    if (a - meta != -1)
                    {
                        retorno = a + 2;
                    }
                }
                return retorno;
            }
            else
            {
                return a;
            }

        }



        // FUNCION PARA CRUZAR DOS IMAGENES Y QUE RETORNE UN HIJO
        public Imagen CruzarImagenesHistograma(Imagen padre, Imagen madre, Imagen meta)
        {
            Bitmap BitmapHijo = new Bitmap(meta.img.Width, meta.img.Height);
            int pixelPadre, pixelMadre;
            for (int x = 0; x < padre.img.Width; x++)
            {
                for (int y = 0; y < padre.img.Height; y++)
                {
                    pixelPadre = 0;
                    pixelMadre = 0;
                    Color pixelP = padre.img.GetPixel(x, y);
                    Color pixelM = madre.img.GetPixel(x, y);
                    Color pixelMeta = imagenMeta.img.GetPixel(x, y);
                    //Histograma color
                    if (AlgoritmoGenetico.AGenetico.opcionAEjecutar == "ManhattanColor" || AlgoritmoGenetico.AGenetico.opcionAEjecutar == "PropioColor")
                    {
                        pixelPadre = Math.Abs(pixelP.R - pixelMeta.R) + Math.Abs(pixelP.G - pixelMeta.G) + Math.Abs(pixelP.B - pixelMeta.B);
                        pixelMadre = Math.Abs(pixelM.R - pixelMeta.R) + Math.Abs(pixelM.G - pixelMeta.G) + Math.Abs(pixelM.B - pixelMeta.B);
                    }
                    //Histograma propio
                    else if (AlgoritmoGenetico.AGenetico.opcionAEjecutar == "ManhattanPropio" || AlgoritmoGenetico.AGenetico.opcionAEjecutar == "PropioPropio")
                    {
                        pixelPadre = (int)Math.Abs((pixelP.R - pixelMeta.R) / 3) + (int)Math.Abs((pixelP.G - pixelMeta.G) / 3) + (int)Math.Abs((pixelP.B - pixelMeta.B) / 3);
                        pixelMadre = (int)Math.Abs((pixelM.R - pixelMeta.R) / 3) + (int)Math.Abs((pixelM.G - pixelMeta.G) / 3) + (int)Math.Abs((pixelM.B - pixelMeta.B) / 3);
                    }
                    if (pixelPadre < pixelMadre)
                    {

                        BitmapHijo.SetPixel(x, y, pixelP);
                    }
                    else
                    {
                        BitmapHijo.SetPixel(x, y, pixelM);
                    }
                }
            }
            Imagen ImgRetorno = new Imagen(BitmapHijo);

            return ImgRetorno;
        }


        public Imagen[] Mutaciones(Imagen[] listaImagenes)
        {
            Imagen imagenAMutar2;
            int cantidadAMutar = (int)((probabilidadMutacion * poblacionInicial) / 100);
            int numeroLista=0;
            while (cantidadAMutar > 0)
            {
                numeroLista = randPrimeraPoblacion.Next(0, poblacionInicial-1);
                Imagen imagenAMutar = listaImagenes[numeroLista];
                imagenAMutar2 = Mutacion(imagenAMutar);
                listaImagenes[numeroLista] = imagenAMutar;
                cantidadAMutar--;
            }
            return listaImagenes;
        }

        public Imagen Mutacion(Imagen Img)
        {
            int cantMutarAux = cantPixelsAMutar;
            int pR, pG, pB, rand1, rand2,largo,ancho;
            largo = Img.img.Width;
            ancho = Img.img.Height;
            while (cantMutarAux > 0)
            {
                rand1 = randElijeImgAMutar.Next(0, largo);
                rand2 = randElijeImgAMutar.Next(0, ancho);
                Color PixelImagen = Img.img.GetPixel(rand1, rand2);
                Color PixelImagenMeta = imagenMeta.img.GetPixel(rand1, rand2);
                pR = MutarPixel(PixelImagen.R, PixelImagenMeta.R);
                pG = MutarPixel(PixelImagen.G, PixelImagenMeta.G);
                pB = MutarPixel(PixelImagen.B, PixelImagenMeta.B);
                Color PixelAux = Color.FromArgb(pR, pG, pB);
                Img.img.SetPixel(rand1, rand2, PixelAux);
                cantMutarAux--;
            }
            return Img;
        }

        public void crearImagen(Imagen[] mejoresImgs)
        {
            int pWidth;
            pWidth = imagenMeta.img.Width * cantidadGeneraciones;
            Bitmap imagenACrear = new Bitmap(pWidth, imagenMeta.img.Height);
            int manejoWidth=0;
            int cantImgs = 0;
            while (cantImgs != mejoresImgs.Length)
            {
                for (int x = 0; x < mejoresImgs[cantImgs].img.Width; x++)
                {
                    for (int y=0;y< mejoresImgs[cantImgs].img.Height; y++)
                    {
                        Color pixel = mejoresImgs[cantImgs].img.GetPixel(x, y);
                        imagenACrear.SetPixel(manejoWidth, y, pixel);
                        
                    }
                    manejoWidth++;
                }
                cantImgs++;
            }
            imagenACrear.Save(rutaGuardar);
        }



        public Imagen[] RetornaListaMejoresImagenes()
        {
            Imagen[] listaRetorno = new Imagen[cantidadGeneraciones];           
            int i = 0;
            while (i<cantidadGeneraciones)
            {
                Imagen[] listaAux = diccionarioImgs.retornaListaGeneracion(ListaDeGeneraciones[i]);
                listaRetorno[i] = retornaMejorImagen(listaAux);
                i++;
            }

            return listaRetorno;
        }


        public Imagen retornaMejorImagen(Imagen[] listaImagenes)
        {
            Imagen ImgRetorno=listaImagenes[0];
            for(int x = 0; x < listaImagenes.Length; x++)
            {
                if (listaImagenes[x].Distancia < ImgRetorno.Distancia)
                {
                    ImgRetorno = listaImagenes[x];
                }
                
            }
            return ImgRetorno;
        }

    }
}

