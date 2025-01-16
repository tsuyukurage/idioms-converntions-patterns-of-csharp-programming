﻿
// フィートからメートルへの対応表を出力
for (int feet = 1; feet <= 10; feet++) {
  double meter = FeetToMeter(feet);
  Console.WriteLine($"{feet}ft = {meter:N4}m");
}

// フィートからメートルを求める
static double FeetToMeter(int feet) {
  return feet * 0.3048;
}

