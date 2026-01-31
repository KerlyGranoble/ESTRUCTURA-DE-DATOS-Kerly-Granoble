using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== CÍRCULO =====
            Circulo circulo = new Circulo(5);

            Console.WriteLine("CÍRCULO");
            Console.WriteLine("Radio: " + circulo.Radio);
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

            Console.WriteLine();

            // ===== RECTÁNGULO =====
            Rectangulo rectangulo = new Rectangulo(4, 6);

            Console.WriteLine("RECTÁNGULO");
            Console.WriteLine("{0,-10} {1,-10}", "Base", "Altura");
            Console.WriteLine("{0,-10} {1,-10}", rectangulo.Base, rectangulo.Altura);
            Console.WriteLine("Área: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());

            Console.ReadKey();
        }
    }

    class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    class Rectangulo
    {
        private double baseRect;
        private double altura;

        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public double Base
        {
            get { return baseRect; }
        }

        public double Altura
        {
            get { return altura; }
        }

        public double CalcularArea()
        {
            return baseRect * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
}
