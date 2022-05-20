using System;

class Program {
  public static void Main (string[] args) {
    double pr, co;

    Console.WriteLine("Digite um númro de 1 á 5: ");
    co = double.Parse(Console.ReadLine());

    if(co == 1){
      Console.WriteLine("Sul");
    }

    else if (co == 2)
      Console.WriteLine("Sudeste");
    
      else if (co == 3)
        Console.WriteLine("Centro - Oeste");

          else if (co == 4)
            Console.WriteLine("Norte");

              else if (co == 5)
                Console.WriteLine("Nordeste");




    
  }
}