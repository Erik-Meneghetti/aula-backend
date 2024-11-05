using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjetos.Classes
{
    public class Animal
    {
        public string raca;
        public string cor;
        public string nome;
        public int idade = 0;

        public void FazerBarulho()
        {
            Console.WriteLine($"Som de um animal qualquer.");
            
        }
    public void Envelhecer()
    {
    idade =+ 1;
    }  
} 
}
