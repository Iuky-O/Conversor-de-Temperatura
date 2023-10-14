
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Conversor.Function{
    
    public class ConvertTemp{
        
        public double CelsiusFahrenheit(){
            
            double Result_F;
            
            Console.Write("°C - ");
            double C = double.Parse(Console.ReadLine()); 
            
            Result_F = 1.8 * C + 32;
            
            return Result_F;
            
        }
        
        public double FahrenheitCelsius(){
            
            double Result_C;

            Console.Write("°F - ");
            double F = double.Parse(Console.ReadLine());
            
            Result_C = (F - 32) / 1.8;
            
            return Result_C;
            
        }
        
        public double CelsiusKelvin(){
            
            double Result_K;
            
            Console.Write("°C - ");
            double C = double.Parse(Console.ReadLine());
            
            Result_K = C + 273.15;
            
            return Result_K;
        }
        
        public double KelvinCelcius(){
            
            double Result_C;
            
            Console.Write("°K - ");
            double K = double.Parse(Console.ReadLine());
            
            Result_C = K - 273.15;
            
            return Result_C;
        }
        
        public double FahrenheitKelvin(){
            
            double Result_K;
            
            Console.Write("°F - ");
            double F = double.Parse(Console.ReadLine());
            
            Result_K = (F - 32) * 5/9 + 273.15;
            
            return Result_K;
            
        }
        
        public double KelvinFahrenheit(){
            
            double Result_F;
            
            Console.Write("°K - ");
            double K = double.Parse(Console.ReadLine());
            
            Result_F = (K - 273.15) * 9/5 + 32;
            
            return Result_F;
            
        }
    }
}