class Program
{
  static void Main(string[] args)
  {
    Pessoa joao = new Pessoa();
    joao.Nome = "João";
    joao.Idade = 30;

    Console.WriteLine("Nome: " + joao.Nome + " Idade: " + joao.Idade);
  }
}