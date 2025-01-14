// Person person; // nullで初期化される
// person person = null;

// stringは参照型なのでnullで初期化できる
// ""とは異なる
string name = null;

if (name is null) {
  Console.WriteLine("nameはnullです");
}

/** null許容型 Nullable */
// 型名に続けて'?'をつけることで、null許容型になる
int? number = null;
// number = 4;

if (number.HasValue) {
  Console.WriteLine($"number = {number.Value}");
} else {
  Console.WriteLine("number = null");
}

/** null許容参照型 */
// nullを許容しない
string text = "C# Programming";
// nullを許容する
string? nullableText = "C# Programming";

text = null; // ビルドエラーになる可能性
nullableText = null; // OK

/*
null許容参照型の導入の効果
>NullReferenceException実行時エラーを回避するのに役立つ
>コードの意図を明確にすることが可能になる
*/