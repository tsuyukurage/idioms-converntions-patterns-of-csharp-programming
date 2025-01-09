// 名前空間の定義
/*
namespace SampleApp {
  // code
}
*/

// C#10.0のファイルスコープ名前空間宣言で記述
namespace SampleApp;

public class Product {
  public int Code { get; set; }
  public string Name { get; set; }
  public int Price { get; set; }

    public Product(int code, string name, int price) {
    this.Code = code;
    this.Name = name;
    this.Price = price;
  }

  // 消費税率は10%
  private readonly double _taxRate = 0.1;

  // 消費税額を求める
  public int GetTax() {
    return (int)(Price * _taxRate);
  }

  // 税込価格を求める
  public int GetPriceIncludingTax() {
    return Price + GetTax();
  }
}