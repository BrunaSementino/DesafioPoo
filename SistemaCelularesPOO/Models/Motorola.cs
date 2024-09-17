namespace DesafioPOO.Models
{
  public class Motorola : Smartphone
  {
    // Construtor da classe Motorola que utiliza o construtor da classe base (Smartphone)
    public Motorola(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    // Sobrescrevendo o método InstalarAplicativo para Motorola
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no Motorola.");
    }
  }
}
