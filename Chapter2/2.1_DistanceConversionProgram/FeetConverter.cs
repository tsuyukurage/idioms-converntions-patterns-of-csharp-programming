namespace DistanceConverter;

public class FeetConverter {
  // メートルからフィートを求める
  public static double FromMeter(double meter) {
    return meter / 0.3048;
  }

  // フィートからメートルを求める
  public static double ToMeter(double feet) {
    return feet * 0.3048;
  }

}