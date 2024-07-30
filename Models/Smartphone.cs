using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_que_Trabalha_com_Celulares.Models
{
    public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
    {

        public string Numero { get; set; } = numero;
        public string Modelo {  get; private set;} = modelo;
        public string Imei {  get; private set;} = imei;
        public int Memoria {  get; private set; } = memoria;

        public void Ligar()
        {
            Console.WriteLine("\nLigando...\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("\nRecebendo ligação...\n");
        }

        public void MudarNumero(string numero){
            this.Numero = numero;
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
    
}