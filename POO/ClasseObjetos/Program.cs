
using System.Net.Http.Headers;
using ClasseObjetos.Classes;


Animal cachorro = new Animal ();

cachorro.nome = "Spaik";
cachorro.raca = "Shihtzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = 5;

Console.WriteLine($"Nome do cachorrinho:{cachorro.nome}");
Console.WriteLine($"Nome do cachorrinho:{cachorro.idade}");
Console.WriteLine($"Nome do cachorrinho:{cachorro.cor}");
Console.WriteLine($"Nome do cachorrinho:{cachorro.raca}");  