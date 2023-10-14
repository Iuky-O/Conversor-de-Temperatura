
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

using Conversor.Function;

public class Principal {
    
  static void Main() {
      
    int decisao = 0;
    
    ConvertTemp var = new ConvertTemp();
    
    while(decisao != 7){
    
                Console.WriteLine("Conversor");
                Console.WriteLine("1 - CELCIUS - FAHRENHEIT");
                Console.WriteLine("2 - FAHRENHEIT - CELCIUS");
                Console.WriteLine("3 - CELCIUS - KELVIN");
                Console.WriteLine("4 - KELVIN - CELCIUS");
                Console.WriteLine("5 - FAHRENHEIT - KELVIN");
                Console.WriteLine("6 - KELVIN - FAHRENHEIT");
                Console.WriteLine("7 - FINALIZAR");
                Console.Write(" --> ");
                decisao = int.Parse(Console.ReadLine());
    
                switch (decisao){
                    case 1:
                        Console.WriteLine("°F - {0}", var.CelsiusFahrenheit());
                        break;
                    case 2:
                        Console.WriteLine("°C - {0}", var.FahrenheitCelsius());
                        break;
                    case 3:
                        Console.WriteLine("°K - {0}", var.CelsiusKelvin());
                        break;
                    case 4:
                        Console.WriteLine("°C - {0}", var.KelvinCelcius());
                        break;
                    case 5:
                        Console.WriteLine("°K - {0}", var.FahrenheitKelvin());
                        break;
                    case 6:
                        Console.WriteLine("°F - {0}", var.KelvinFahrenheit());
                        break;
                    case 7:
                        Console.WriteLine("PROGRAMA FINALIZADO!");
                        break;
                    default:
                        Console.WriteLine("Valor invalido!");
                        break;
    
                }
            }
    
  }
}
