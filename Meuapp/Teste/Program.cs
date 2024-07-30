using System;
using System.Data.Common;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Meuapp
{
     class Program
   {
      static void Main()
      {
         var mouse = new Product(1, "Mouse gamer", 299.90, EProductType.Product);
         
         var manuntecaoEletrica = new Product(2, "manuntenção elétrica residencial", 500, EProductType.Service);


         Console.WriteLine(mouse.Id);
         Console.WriteLine(mouse.Name);
         Console.WriteLine(mouse.Price);
         Console.WriteLine((int)mouse.Type);
      }

      
      
      // static void Main()
      // {
      //    string nome = RetornaNome("Guilherme", "Amaro", 19);

      //    Console.WriteLine(nome);

      //    Meumetodo();
      // }
      // static string RetornaNome(string nome, string sobrenome, int idade)
      // {
      //    return nome + " " + sobrenome + ", " + idade.ToString() + " anos";
      // }

      // static void Meumetodo()
      // {
      //    Console.WriteLine("vai se fuder C#");
      // }

         
   }
   struct Product
   {
      public int Id;
      public string Name;
      public double Price;
      public EProductType Type;

      public double PriceInDolar(double dolar)
      {
         return Price * dolar;
      }
   }    

   enum EProductType
   {
      Product = 1,
      Service = 2
   }
}

