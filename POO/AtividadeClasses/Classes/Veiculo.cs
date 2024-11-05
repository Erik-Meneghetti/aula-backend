using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{
    public class Veiculo
    {
        public string marca
        public string potencia
        public string cor;
        public string nome;
        public int modelo
        public int qtdPortas

        public void Acelerar( string acelerar = "stututututu")
        {
            Console.WriteLine($"som do carro ao acelerar : {acelerar}");
  
        }

        public void Ligar (string ligar = "ligado")
        {
            Console.WriteLine($"carro: {ligar}");
            
        }
        public void Desligar (string desligar = "desligado")
        {
            Console.WriteLine($"carro : {desligar}");
            
        }
        public void Freiar(string freiar)
        {
            Console.WriteLine($"Som do carro ao freiar: {freiar}");
            
        }
    }
}
