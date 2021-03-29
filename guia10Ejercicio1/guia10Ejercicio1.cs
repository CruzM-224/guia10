using System;

class MainClass {
  public static void Main (string[] args) {
    int negativos = 0, positivos = 0, ceros = 0, filas, columnas;
    Console.WriteLine("Escriba el numero de filas de la matriz");
    filas = int.Parse(Console.ReadLine());
    Console.WriteLine("Escriba el numero de columnas de la matriz");
    columnas = int.Parse(Console.ReadLine());
    Double[,] numeros = new Double[filas,columnas];
    Console.WriteLine("Llene la matriz");
    for(int cont = 0; cont < filas; cont++){
      for(int cont2 = 0; cont2 <  columnas; cont2++){
        numeros[cont,cont2] = Double.Parse(Console.ReadLine());
        if(numeros[cont,cont2] > 0){
          positivos++;
        }else{
          if(numeros[cont,cont2] < 0){
            negativos++;
          }else{
            ceros++;
          }
        }
      }
    }

    Console.WriteLine("Cantidad de numeros positivos: " + positivos);
    Console.WriteLine("Cantidad de numeros negativos: " + negativos);
    Console.WriteLine("Cantidad de ceros: " + ceros);
  }
}