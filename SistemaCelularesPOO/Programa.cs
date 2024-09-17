using System;
using DesafioPOO.Models; // Certifique-se de que o namespace está correto

namespace DesafioPOO
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Instanciar objetos de cada classe de smartphone
      Smartphone samsung = new Samsung("123456789", "Galaxy S21", "111222333", 128);
      Smartphone motorola = new Motorola("987654321", "Moto G9", "444555666", 64);
      Smartphone xiaomi = new Xiaomi("555666777", "Mi 11", "777888999", 256);
      Smartphone iphone = new Iphone("666777888", "iPhone 13", "222333444", 128);

      // Testar a instalação de aplicativos
      samsung.InstalarAplicativo("WhatsApp");
      motorola.InstalarAplicativo("Telegram");
      xiaomi.InstalarAplicativo("Instagram");
      iphone.InstalarAplicativo("Facebook");
    }
  }
}

