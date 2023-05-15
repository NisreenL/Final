using System;

class Program {

 static void Main(string[] args) {
      int numCity = int.Parse(Console.ReadLine());
      string[] nameArray = new string[numCity];
      for (int i = 0; i < numCity; i++) {
      nameArray[i] = Console.ReadLine();
      }
      int City = int.Parse(Console.ReadLine());
      int contactCity = int.Parse(Console.ReadLine());
      for (int j = 0; j < contactCity; j++){
        if (contactCity < 0 || contactCity >= numCity )
        
                {
                    Console.WriteLine("Invalid ID. Please enter again.");
                   
                  
                    
                }
        
      }

 }

}