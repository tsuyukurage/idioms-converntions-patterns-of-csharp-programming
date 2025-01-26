// 売り上げデータを読み込み、Saleオブジェクトのリストを返す
static List<Sale> ReadSales(string filePath) {
  List<Sale> sales = new List<Sale>();
  string[] lines = File.ReadAllLines(filePath);
  foreach(string line in lines) {
    string[] items = line.Split(',');
    sales sale = new Sale {
      ShopName = items[0],
      ProductCategory = items[1],
      Amount = int.Parse(items[2]),
    };
    sales.Add(sale);
  }
  return sales;
}