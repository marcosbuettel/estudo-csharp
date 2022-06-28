using System;

class Pessoa
{
  public string? nome;
  public int idade;
  public void mensagem()
  {
    Console.Write("Olá " + nome + " você tem " + idade + " anos.");
  }
}