using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ucak_bileti_hesaplama
{
    internal class hesaplama
    {
        public hesaplama()
        {


        }

        public double biletHesapla(double mil,double yas,double yolculukTipi)
        {
           double normaltutar = 0;
            double yasindirimorani = 0;
            double yasındirimtutari = 0;
            if(mil>0)
            {
                normaltutar = mil * 0.10;

            }

            else if(yas>=0||yas<=12)
            {

                yasindirimorani = 0.50;
                yasındirimtutari = normaltutar * yasindirimorani;

            
            }

            else if(yas>12||yas<=24)
            {   yasindirimorani = 0.10;
                yasındirimtutari = normaltutar * yasindirimorani;
                   
            }
            else if(yas>65)
            {
                yasindirimorani = 0.30;
                yasındirimtutari = normaltutar * yasindirimorani;
            }

            double indirimtutar = normaltutar - yasındirimtutari;
            double gidisdonuştutari = 0;

            if (yolculukTipi == 2)
            {
                double gidisdonusindirimorani = 0.20;
                double gidisdonusindirimtutari = indirimtutar * gidisdonusindirimorani;
                gidisdonuştutari = (indirimtutar - gidisdonusindirimtutari) * 2;

            }
            else if (yolculukTipi == 1)
            {
                gidisdonuştutari = indirimtutar;



            }      
            
            return gidisdonuştutari;
        }
            
        
        
        
        
        
        
        
        
        
        
        

           
    }
}
