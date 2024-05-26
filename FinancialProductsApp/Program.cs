using System;

namespace FinancialProductsApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string customerName = "Ms. Barros";

      string currentProduct = "Magic Yield";
      int currentShares = 2975000;
      decimal currentReturn = 0.1275m;
      decimal currentProfit = 55000000.0m;

      string newProduct = "Glorious Future";
      decimal newReturn = 0.13125m;
      decimal newProfit = 63000000.0m;

      Console.WriteLine($"Dear {customerName},");
      Console.WriteLine(
          $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n"
      );
      Console.WriteLine(
          "Currently, you own {0:N2} shares at a return of {1:P2}. with a profit of {2:C}.\n",
          currentShares,
          currentReturn,
          currentProfit
      );
      Console.WriteLine(
          "Our new product, {0}, offers a return of {1:P2}. Given your current volume, your potential profit would be {2:C}\n",
          newProduct,
          newReturn,
          newProfit
      );
      Console.WriteLine("Here's a quick comparison:\n");

      string comparisonMessage = "";

      string currentProductString = $"{currentProduct}";
      string currentReturnString = $"{currentReturn:P2}";
      string currentProfitString = $"{currentProfit:C}\n";
      string newProductString = $"{newProduct}";
      string newReturnString = $"{newReturn:P2}";
      string newProfitString = $"{newProfit:C}";

      comparisonMessage += currentProductString.PadRight(20);
      comparisonMessage += currentReturnString.PadRight(10);
      comparisonMessage += currentProfitString.PadRight(10);
      comparisonMessage += newProductString.PadRight(20);
      comparisonMessage += newReturnString.PadRight(10);
      comparisonMessage += newProfitString.PadRight(10);

      Console.WriteLine(comparisonMessage);
    }
  }
}
