namespace DistanceConverter;

public static class FeetConverter {
  private const double ratio = 0.3048;

  // メートルからフィートを求める
  public static double FromMeter(double meter) {
    return meter / ratio;
  }

  // フィートからメートルを求める
  public static double ToMeter(double feet) {
    return feet * ratio;
  }

}