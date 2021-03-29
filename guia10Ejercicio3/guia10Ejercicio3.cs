using System;

class MainClass {
  public static void Main (string[] args) {
    Double promedio, total = 0;;
    int[,] numeros = new int[3,4];
    Console.WriteLine("Llene la matriz 3x4");
    for(int cont = 0; cont < 3; cont++){
      for(int cont2 = 0; cont2 <  4; cont2++){
        numeros[cont,cont2] = int.Parse(Console.ReadLine());
      }
    }

    for(int cont = 0; cont < 3; cont++){
      for(int cont2 = 0; cont2 <  4; cont2++){
        total += numeros[cont,cont2];
      }
    }
    promedio = total/12;

    Console.WriteLine("Promedio: " + promedio);
  }
}