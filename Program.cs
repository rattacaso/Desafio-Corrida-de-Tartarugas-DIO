using System;

namespace CorridaTartarugas
{
    class Program
    {

      public static void Main() {
        
      int L = 3;
      while (L > 0)
      {
        var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
        if(numeroQuantidade >= 1 && numeroQuantidade <= 500)
        {
          
          string[] tartarugas = Console.ReadLine().Split(" ");
          
          var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
          for(int i = 1; i < numeroQuantidade; i++)
          {
            var tartaruga = Int32.Parse(tartarugas[i]);
            
            if( tartaruga > maiorVelocidade)
            {
              maiorVelocidade = tartaruga;
            }
          }
          
          if(maiorVelocidade < 10)
          {
            Console.WriteLine(1);
          }
          else if(maiorVelocidade >= 10 && maiorVelocidade < 20)
          {
            Console.WriteLine(2);
          }
          else if(maiorVelocidade >= 20)
          {
            Console.WriteLine(3);
          }
          
          L--;
          
        } else {
          Console.WriteLine("Insira um número entre 1 e 500");
        }
      }
    }
  }
}



// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace CorridaTartarugas
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int L = int.Parse(Console.ReadLine());
//             int[] Grupo = new int[L];

//             for(int i = 0; i<L; i++)
//             {
//                 Grupo[i] = int.Parse(Console.ReadLine());
                
//             }
            
            
//         }
        
//     }
// }
