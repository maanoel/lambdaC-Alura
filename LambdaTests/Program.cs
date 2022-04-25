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

      Console.WriteLine(saldoTotalEntreAsContas);
    }
  }
}
