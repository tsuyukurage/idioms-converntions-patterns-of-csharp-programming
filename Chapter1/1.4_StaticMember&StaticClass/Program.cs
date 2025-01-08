// newせずに使える
DateTime today = DateTime.Today;
Console.WriteLine($"今日は{today.Month}月{today.Day}日です");

public static class Console {
  // ビルドエラーになる
  // Console con = new Console();
}