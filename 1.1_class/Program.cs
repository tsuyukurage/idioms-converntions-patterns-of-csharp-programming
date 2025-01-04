Product karinto = new(123, "かりんとう", 180);
int price = karinto.Price;
int taxIncluded = karinto.GetPriceIncludingTax();

// 1つのクラスから複数のインスタンスを作成できる。
Product daifuku = new(253, "大福もち", 160);

int karintoTax = karinto.GetTax();
int daifukuTax = daifuku.GetTax();