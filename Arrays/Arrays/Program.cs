string [] frutas = {"Melancia", "Carambola", "Maracuja","Morango", "Limao", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Linchia","Pitaya", "Pessego", "Banana"};

    Console.Write($"Sua sacola contem {frutas.Length} frutas");


    foreach (string f in frutas)
    {
        Console.Write($"{f},");
    }

    Console.WriteLine();