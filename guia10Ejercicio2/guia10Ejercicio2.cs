using System;

class MainClass {
  public static void Main (string[] args) {
    Double maximo, minimo;
    int filas, columnas;
    Console.WriteLine("Escriba el numero de filas de la matriz");
    filas = int.Parse(Console.ReadLine());
    Console.WriteLine("Escriba el numero de columnas de la matriz");
    columnas = int.Parse(Console.ReadLine());
    Double[,] numeros = new Double[filas,columnas];
    Console.WriteLine("Llene la matriz");
    for(int cont = 0; cont < filas; cont++){
      for(int cont2 = 0; cont2 <  columnas; cont2++){
        numeros[cont,cont2] = Double.Parse(Console.ReadLine());
      }
    }
    maximo = numeros[0,0];
    minimo = numeros[0,0];

    //Busqueda
    for(int cont = 0; cont < filas; cont++){
      for(int cont2 = 0; cont2 <  columnas; cont2++){
        if(numeros[cont,cont2] > maximo){
          maximo = numeros[cont,cont2];
        }
        if(numeros[cont,cont2] < minimo){
          minimo = numeros[cont,cont2];
        }
      }
    }
    Console.WriteLine("Numero maximo encontrado: " + maximo);
    Console.WriteLine("Numero minimo encontrado: " + minimo);
  }
}