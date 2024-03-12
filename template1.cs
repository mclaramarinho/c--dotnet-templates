public class MinhaClasse {
    // Atributos privados
    private int AtributoPrivado;
    
    // Atributo protegido
    protected string AtributoProtegido;
    
    // Atributo público
    public double AtributoPublico;
    
    // Atributo com expressão lambda
    private string AtributoLambda => this.AtributoPublico.Sum(ap => ap.Value);

    // Construtor
    public MinhaClasse(int valorPrivado, string valorProtegido, double valorPublico) {
        this.atributoPrivado = valorPrivado;
        this.atributoProtegido = valorProtegido;
        this.atributoPublico = valorPublico;
    }

    // Método público
    public void MetodoPublico() {
        Console.WriteLine("Método público chamado");
    }

    // Método privado
    private void MetodoPrivado() {
        Console.WriteLine("Método privado chamado");
    }

    // Método protegido
    protected void MetodoProtegido() {
        Console.WriteLine("Método protegido chamado");
    }

    // Método para acessar o atributo privado (getter)
    public int GetAtributoPrivado() {
        return this.atributoPrivado;
    }

    // Método para modificar o atributo privado (setter)
    public void SetAtributoPrivado(int novoValor) {
        this.atributoPrivado = novoValor;
    }
}
