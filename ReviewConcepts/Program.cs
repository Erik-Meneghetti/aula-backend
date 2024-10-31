Console.WriteLine($"Ola, digite seu nome:");
string nome = Console.ReadLine()!;

Console.WriteLine($"Agora digite seu sobrenome:");
string sobrenome = Console. ReadLine()!;

Console.WriteLine($"E-mail:");
string email = Console.ReadLine()!;


Console.WriteLine($"E seu endereço:"!);
string estadoCivil = Console.ReadLine()!;

Console.WriteLine($"Seu CPF:");
float cpf = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Seu telefone");
int telefone = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine()!);

int anoAtual = DateTime.Now.Year;
int anoNascimento = anoAtual - idade;

Console.WriteLine(@$"Obrigado:

    - {nome} {sobrenome}
    - {idade} - {anoNascimento}
    - {email}
    -{telefone}
    -{cpf}
    -{estadoCivil}");
