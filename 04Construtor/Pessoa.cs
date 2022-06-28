class Pessoa
{
  private string nome;
  private int idade;

  public Pessoa(string nome, int idade)
  {
    this.nome = nome;
    this.idade = idade;
  }

  public void mensagem()
  {
    Console.WriteLine("Nome: " + nome + " | Idade: " + idade);
  }
}