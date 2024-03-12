// Invocando o construtor com todos os atributos
MinhaClasse objeto1 = new MinhaClasse(10, "texto", 5.5, true);
Console.WriteLine("Objeto 1:");
objeto1.ExibirValores();

Console.WriteLine();

// Invocando o construtor sem os atributos opcionais
MinhaClasse objeto2 = new MinhaClasse(20, "outro texto");
Console.WriteLine("Objeto 2:");
objeto2.ExibirValores();


 // Invocando o construtor com todos os atributos opcionais - sintaxe alternativa
MinhaClasse objeto1 = new MinhaClasse(10, "texto") {
    atributoOpcional1 = 5.5,
    atributoOpcional2 = true
};
Console.WriteLine("Objeto 1:");
objeto1.ExibirValores();
