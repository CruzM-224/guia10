using System;

class MainClass {
  public static void Main (string[] args) {
    string cadena1, cadena2, cadena3, cadena4, cadena;
    Console.WriteLine("Escriba la primer cadena");
    cadena1 = Console.ReadLine();
    Console.WriteLine("Escriba la segunda cadena");
    cadena2 = Console.ReadLine();
    Console.WriteLine("Escriba la tercer cadena");
    cadena3 = Console.ReadLine();
    Console.WriteLine("Escriba la cuarta cadena");
    cadena4 = Console.ReadLine();
    cadena = string.Concat(cadena1,cadena2,cadena3,cadena4);
    Console.WriteLine("Cadena concatenada");
    Console.WriteLine(cadena);
  }
}