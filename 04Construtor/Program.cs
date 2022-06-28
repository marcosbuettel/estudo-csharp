class Program
{
  static void Main(string[] args)
  {
    Pessoa joao = new Pessoa("João", 20);
    Pessoa jose = new Pessoa("José", 34);

    joao.mensagem();
    jose.mensagem();
  }
}