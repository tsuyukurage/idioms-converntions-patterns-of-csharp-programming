namespace Chapter1Exercises;

// 商品クラス
public class Product {
  // 商品コード
  public int Code { get; private set; }
  // 商品名
  public string Name { get; private set; }
  // 商品価格（税抜き）
  public int Price { get; private set; }

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