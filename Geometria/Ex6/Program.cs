using System;
using System.Globalization;

namespace Ex6 {

    internal class Program {

        public static void Main(string[] args) {

            string[] vet = System.Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * Math.Pow(c, 2.0);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            System.Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }

    }

}
