namespace DesafioPOO.Models
{
  public class Xiaomi : Smartphone
  {
    // Construtor da classe Xiaomi que utiliza o construtor da classe base (Smartphone)
    public Xiaomi(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    // Sobrescrevendo o método InstalarAplicativo para Xiaomi
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no Xiaomi.");
    }
  }
}
