using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Imagen
    {
        public Bitmap img;       
        public int[] ListaR = new int[256];
        public int[] ListaG = new int[256];
        public int[] ListaB = new int[256];
        public Double DistanciaR = 0;
        public Double DistanciaG = 0;
        public Double DistanciaB = 0;
        public Double Distancia = 0;

        public Imagen(Bitmap pImg)
        {
            img = pImg;
            int x, y = 0;
            for (x = 0; x < img.Width; x++)
            {
                for (y = 0; y < img.Height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);

                    ListaR[pixelColor.R]++;
                    ListaG[pixelColor.G]++;
                    ListaB[pixelColor.B]++;

                }
            }
        }
        public Bitmap getImg()
        {
            return img;
        }
        public int[] getListaR()
        {
            return ListaR;
        }
        public int[] getListaG()
        {
            return ListaG;
        }
        public int[] getListaB()
        {
            return ListaB;
        }



        public void CalcularDistanciaManhattanPropia(Imagen pImg, Imagen pImgMeta)
        {
            DistanciaR =(int) retornaDistanciaPropiaLista(pImg.ListaR, pImgMeta.ListaR);
            DistanciaG =(int)retornaDistanciaPropiaLista(pImg.ListaG, pImgMeta.ListaG);
            DistanciaB =(int)retornaDistanciaPropiaLista(pImg.ListaB, pImgMeta.ListaB);

            this.Distancia =DistanciaR + DistanciaG + DistanciaB;
        }

        public void CalcularDistanciaManhattanColor(Imagen pImg, Imagen pImgMeta)
        {
            DistanciaR = retornaDistanciaColorLista(pImg.ListaR, pImgMeta.ListaR);
            DistanciaG = retornaDistanciaColorLista(pImg.ListaG, pImgMeta.ListaG);
            DistanciaB = retornaDistanciaColorLista(pImg.ListaB, pImgMeta.ListaB);

            this.Distancia = DistanciaR + DistanciaG + DistanciaB;
        }

        public void CalcularDistanciaPropiaPropia(Imagen pImg, Imagen pImgMeta)
        {
            DistanciaR = Math.Sqrt(retornaDistanciaPropiaLista(pImg.ListaR, pImgMeta.ListaR));
            DistanciaG = Math.Sqrt(retornaDistanciaPropiaLista(pImg.ListaR, pImgMeta.ListaR));
            DistanciaB = Math.Sqrt(retornaDistanciaPropiaLista(pImg.ListaR, pImgMeta.ListaR));
            this.Distancia= DistanciaR + DistanciaG + DistanciaB;
        }
        public void CalcularDistanciaPropiaColor(Imagen pImg, Imagen pImgMeta)
        {
            DistanciaR = Math.Sqrt(retornaDistanciaColorLista(pImg.ListaR, pImgMeta.ListaR));
            DistanciaG = Math.Sqrt(retornaDistanciaColorLista(pImg.ListaR, pImgMeta.ListaR));
            DistanciaB = Math.Sqrt(retornaDistanciaColorLista(pImg.ListaR, pImgMeta.ListaR));
            this.Distancia = DistanciaR + DistanciaG + DistanciaB;
        }



        public int retornaDistanciaColorLista(int[] pLista, int[] pListaMeta)
        {
            int retorna = 0;
            for (int x = 0; x < pLista.Length; x++)
            {
                retorna = retorna + Math.Abs(pListaMeta[x] - pLista[x]);
            }
            return retorna;
        }

        public int retornaDistanciaPropiaLista(int[] pLista, int[] pListaMeta)
        {
            int retorna = 0;
            for (int x = 0; x < pLista.Length; x++)
            {
                retorna = retorna + Math.Abs(pListaMeta[(int)(x/3)] - pLista[(int)(x / 3)]);
            }
            return retorna;
        }


        public int devolverPixelPropio(int pix, int pixMeta)
        {
            int retorno;
            retorno = (int)Math.Abs((pix / 3) - (pixMeta / 3));
            return retorno;
        }
        public int devolverPixeColor(int pix, int pixMeta)
        {
            int retorno;
            retorno = (int)Math.Abs(pix - pixMeta);
            return retorno;
        }
    }
}
