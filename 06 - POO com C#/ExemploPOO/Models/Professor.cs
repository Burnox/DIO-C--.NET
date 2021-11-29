namespace ExemploPOO.Models
{
  public class Professor : Pessoa
  {
    public int Salario { get; set; }

    public override sealed void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome}, e recebo {Salario} reais!");
    }
  }
}