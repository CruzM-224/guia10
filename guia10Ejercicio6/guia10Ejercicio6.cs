using System;

class MainClass {
  public static void Main (string[] args) {
    string cadena, invertida;
    Console.WriteLine("Escriba la cadena a invertir");
    cadena = Console.ReadLine();
    char[] inv = cadena.ToCharArray();
    Array.Reverse(inv);
    invertida = new string(inv);
    Console.WriteLine("La cadena invertida es: " + invertida);
  }
}