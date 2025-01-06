// structとclassでは振る舞いが違う
class/* struct */ MyPoint {
  public int X { get; set; }
  public int Y { get; set; }

  // コンストラクタ
  public MyPoint(int x, int y) {
    this.X = x;
    this.Y = y;
  }
}