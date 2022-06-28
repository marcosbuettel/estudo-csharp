class Program
{
  static void Main(string[] args)
  {
    Aluno joao = new Aluno();
    joao.nome = "João";
    joao.nota1 = 0;
    joao.nota2 = 10;

    joao.mensagem();
  }
}