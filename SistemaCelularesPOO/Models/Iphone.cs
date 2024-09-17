namespace DesafioPOO.Models
{
  // Supondo que a classe "Smartphone" exista em outro lugar no código
  public class Iphone : Smartphone
  {
    // Construtor da classe Iphone que utiliza o construtor da classe base (Smartphone)
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    // Sobrescrevendo o método InstalarAplicativo para Iphone
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
    }
  }
}
