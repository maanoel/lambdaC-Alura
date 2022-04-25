using System.Collections.Generic;
using System.Linq;

namespace LambdaTests
{
  public class Banco
  {

    private IList<Conta> contas;

    public IList<Conta> Contas
    {
      get { return contas; }
    }
    public Banco()
    {
      this.contas = new List<Conta>();
    }

    public void CriarConta(int agencia, int numero, int saldo)
    {
      contas.Add(new Conta(agencia, numero, saldo));
    }

    public IList<Conta> ContasComSaldoMaiorQueDoisMil()
    {
      return contas.Where(conta => conta.Saldo > 2000).ToList();
      //return contas.Where((Conta conta) => { return conta.Saldo > 2000;  }).ToList();
      //return contas.Where((Conta conta)=> conta.Saldo > 2000).ToList();
    }

    public double ObterSaldoTotalContas() {
      return contas.Sum(conta => conta.Saldo);
    }

    public double MeiaDoSaldoDasContas() {
      return contas.Average(conta => conta.Saldo);
    }

    public int NumeroDeContasComSaldoMaiorQue5000() {
      return contas.Count(conta => conta.Saldo > 5000);
    }

    public double MenorSaldoEntreAsContas() {
      return contas.Min(conta => conta.Numero);
    }

    public double MaiorSaldoEntreAsContas()
    {
      return contas.Max(conta => conta.Numero);
    }
  }
}
