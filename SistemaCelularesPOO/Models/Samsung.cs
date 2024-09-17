namespace DesafioPOO.Models
{
  public class Samsung : Smartphone
  {
    // Construtor da classe Samsung que utiliza o construtor da classe base (Smartphone)
    public Samsung(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    // Sobrescrevendo o método InstalarAplicativo para Samsung
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no Samsung.");
    }
  }
}
