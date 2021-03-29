using System;

class MainClass {
  public static void Main (string[] args) {
    string cadena1, cadena2;
    Console.WriteLine("Escriba la primer cadena");
    cadena1 = Console.ReadLine();
    Console.WriteLine("Escriba la segunda cadena");
    cadena2 = Console.ReadLine();

    if(string.Compare(cadena1,cadena2) == 0){
      Console.WriteLine("Las cadenas de caracteres son iguales");
    }else{
      Console.WriteLine("Las cadenas de caracteres no son iguales");
    }
  }
}