class Aluno
{
  public string nome;
  public double nota1, nota2;

  public double media()
  {
    return (nota1 + nota2) / 2;
  }

  public string situacao(double media)
  {
    return media >= 7 ? "Aprovado" : "Reprovado";
  }

  public void mensagem()
  {
    double obterMedia = media();
    string oberSituacao = situacao(obterMedia);

    Console.WriteLine("Está " + oberSituacao);
  }


}