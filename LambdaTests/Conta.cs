namespace LambdaTests
{
  public class Conta
  {
    private int agencia;
    private int numero;
    private double saldo;

    public Conta(int agencia, int numero, int saldo)
    {
      this.agencia = agencia;
      this.numero = numero;
      this.saldo = saldo;
    }

    public int Agencia
    {
      get { return agencia; }
      set { agencia = value; }
    }

    public double Saldo
    {
      get { return saldo; }
    }

    public int Numero
    {
      get { return numero; }
      set { numero = value; }
    }

    public override string ToString()
    {
      return $"Conta: {numero} - Agência: {agencia} - Saldo: {Saldo}";
    }
  }
}
