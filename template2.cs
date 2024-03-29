public class MinhaClasse {
    // Atributos obrigatórios
    private int atributoObrigatorio1;
    private string atributoObrigatorio2;

    // Atributos opcionais
    private double? atributoOpcional1;
    private bool atributoOpcional2;

    // Construtor com atributos obrigatórios e opcionais
    public MinhaClasse(int valorObrigatorio1, string valorObrigatorio2, double? valorOpcional1 = null, bool valorOpcional2 = false) {
        this.atributoObrigatorio1 = valorObrigatorio1;
        this.atributoObrigatorio2 = valorObrigatorio2;
        this.atributoOpcional1 = valorOpcional1;
        this.atributoOpcional2 = valorOpcional2;
    }

    // Método para exibir os valores dos atributos
    public void ExibirValores() {
        Console.WriteLine($"Atributo Obrigatório 1: {this.atributoObrigatorio1}");
        Console.WriteLine($"Atributo Obrigatório 2: {this.atributoObrigatorio2}");
        Console.WriteLine($"Atributo Opcional 1: {this.atributoOpcional1 ?? 0}"); // ?? 0 para lidar com valores nulos
        Console.WriteLine($"Atributo Opcional 2: {this.atributoOpcional2}");
    }
}

