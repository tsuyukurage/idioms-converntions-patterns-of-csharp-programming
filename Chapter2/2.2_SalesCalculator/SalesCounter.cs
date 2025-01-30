namespace SalesCalculator;
// 売り上げ集計クラス
public class SalesCounter {

  private readonly List<SalesCounter> _sales;

  // コンストラクタ
  public SalesCounter(List<SalesCounter> sale) {
    _sales = sale;
  }

  // 店舗売り上げを求める
  public Dictionary<string, int> GetPerStoreSales() {
    Dictionary<string, int> dict = new Dictionary<string, int>();
    foreach (SalesCounter sale in _sales) {
      if (dict.ContainsKey(sale.ShopName))
        dict[sale.ShopName] += sale.Amount;
      else
        dict[sale.ShopName] = sale.Amount;
    }
    return dict;
  }
}