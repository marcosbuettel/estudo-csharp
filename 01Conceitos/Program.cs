using System;

class Program
{
  static void Main(string[] args)
  {
    Pessoa joao = new Pessoa();
    joao.nome = "João";
    joao.idade = 31;

    joao.mensagem();
  }
}