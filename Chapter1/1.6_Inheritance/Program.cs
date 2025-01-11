Employee employee = new Employee {
  Id = 100,
  Name = "山田太郎",
  Birthday = new DateTime(1992, 4, 5),
  DivisionName = "第一営業部",
};
Console.WriteLine($"{employee.Name}({employee.GetAge()})は、{employee.DivisionName}に所属しています。");

Person person = new Employee(); // is-a関係
// Employee employee2 = new Person(); // エラー not is-a関係

// クラス階層の頂点にあるのがSystem.Objectクラス
object person2 = new Person();
object employee2 = new Employee();