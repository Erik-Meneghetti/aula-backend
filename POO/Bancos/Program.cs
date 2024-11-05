using Bancos.Classes;


    
    Console.Clear();
    Console.WriteLine($"Bem vindo ao Sanstander");
    Console.WriteLine();


    ContaCorrente contaErik = new ContaCorrente();
    ContaCorrente contaSillas = new ContaCorrente();

    contaErik.Titular = "Erik";
    contaErik.Depositar(100000f);

    contaErik.Titular = "Erik";
    contaErik.Depositar(100000f);

    Console.WriteLine($"Conta da {contaErik} tem R$ {contaErik.Saldo}");
    Console.WriteLine($"Conta da {contaErik} tem R$ {contaErik.Saldo}");

    contaErik.Sacar(250f);
    Console.WriteLine($"Voce sacou e sua conta ficou com R${contaErik.Saldo}");





    

