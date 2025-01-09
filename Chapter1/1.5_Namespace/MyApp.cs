using System;

namespace SampleApp {
  public class MyApp {
    public void Run() {
      // ProductクラスはSampleApp名前空間で定義されているため、
      // using SampleApp;
      // は不要。
      Product karinto = new(123, "かりんとう", 180);
      int taxIncluded = karinto.GetPriceIncludingTax();
      Console.WriteLine(taxIncluded);
    }
  }
}