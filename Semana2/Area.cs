namespace FigurasGeometricas
{
 // Clase Circulo
 // Esta clase representa un círculo y guarda su radio
 class Circulo
 {
 // Variable privada que almacena el radio del círculo
 private double radio;
 // Constructor que recibe el radio del círculo
 public Circulo(double radio)
 {
 this.radio = radio;
 }
 // CalcularArea es una función que devuelve un valor double,
 // se utiliza para calcular el área de un círculo
 public double CalcularArea()
 {
 return Math.PI * radio * radio;
 }
 // CalcularPerimetro devuelve el perímetro del círculo
 public double CalcularPerimetro()
 {
 return 2 * Math.PI * radio;
 }
 }
 // Clase Rectangulo
 // Esta clase representa un rectángulo con base y altura
 class Rectangulo
 {
 // Variables privadas
 private double baseRect;
 private double altura;
 // Constructor que recibe la base y la altura
 public Rectangulo(double baseRect, double altura)
 {
 this.baseRect = baseRect;
 this.altura = altura;
 }
 // CalcularArea calcula el área del rectángulo
 public double CalcularArea()
 {
 return baseRect * altura;
 }
 // CalcularPerimetro calcula el perímetro del rectángulo
 public double CalcularPerimetro()
 {
 return 2 * (baseRect + altura);
 }
 }
}