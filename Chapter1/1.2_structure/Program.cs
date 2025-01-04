DateTime date = new(2025, 1, 4);
int year = date.Year;
// 10日後を求める
DateTime daysAfter10 = date.AddDays(10);
Console.WriteLine(daysAfter10);

MyClass myClass = new MyClass { X = 1, Y = 2 };
Console.WriteLine($"MyClass: X = {myClass.X}, Y = {myClass.Y}");

MyStruct myStruct = new MyStruct { X = 3, Y = 4 };
Console.WriteLine($"MyStruct: X = {myStruct.X}, Y = {myStruct.Y}");

/*
  クラスの場合、変数とは別の場所のヒープ領域が確保され、変数にはその参照が格納されるが、
  構造体の場合は、変数そのものにオブジェクトが格納される。
 */