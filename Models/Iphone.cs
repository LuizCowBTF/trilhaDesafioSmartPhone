using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilhaDesafioSmartPhone.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria )
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando {nomeApp} no celular IPhone.");
        }
    }
}