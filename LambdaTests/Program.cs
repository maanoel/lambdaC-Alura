using System;

namespace LambdaTests
{
  class Program
  {
    static void Main(string[] args)
    {
      var banco = new Banco();
      banco.CriarConta(1111, 2222, 10);
      banco.CriarConta(1111, 2222, 20);
      banco.CriarConta(1111, 2222, 2000);
      banco.CriarConta(1111, 2222, 3000);
      banco.CriarConta(1111, 2222, 5000);

      var contasMaiorQueDoisMil = banco.ContasComSaldoMaiorQueDoisMil();

      foreach (var conta in contasMaiorQueDoisMil)
      {
        Console.WriteLine(conta);
      }

      var saldoTotalEntreAsContas = banco.ObterSaldoTotalContas();
      var mediaEntreAsContas = banco.MeiaDoSaldoDasContas();
      var numeroDeContasComSaldoMaiorQue5000 = banco.NumeroDeContasComSaldoMaiorQue5000();
      var menorSaldoEntreAsContas = banco.MenorSaldoEntreAsContas();
      var maiorSaldoEntreAsContas = banco.MaiorSaldoEntreAsContas();

      Console.WriteLine(saldoTotalEntreAsContas);
      Console.WriteLine(mediaEntreAsContas);
      Console.WriteLine(numeroDeContasComSaldoMaiorQue5000);
      Console.WriteLine(menorSaldoEntreAsContas);
      Console.WriteLine(maiorSaldoEntreAsContas);
    }
  }
}
