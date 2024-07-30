using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_que_Trabalha_com_Celulares.Models
{
    public class Iphone(string numero, string modelo, string imei, int memoria) : 
    Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp){
             Console.WriteLine($"\nEstá sendo instalado no dispositivo {nameof(Iphone)}, o aplicativo {nomeApp}.\n");
            
        }
    }
}