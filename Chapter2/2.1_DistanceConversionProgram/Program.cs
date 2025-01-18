if (args.Length >= 1 && args[0] == "-tom") {
  PrintFeetToMeterList(1, 10);
} else {
  PrintMeterToFeetList(1, 10);
}

// フィートからメートルへの対応表を出力
static void PrintFeetToMeterList(int start, int stop) {
  for (int feet = start; feet <= stop; feet++) {
    double meter = FeetToMeter(feet);
    Console.WriteLine($"{feet}ft = {meter:N4}m");
  }
}

// メートルからフィートへの対応表を出力
PrintMeterToFeetList(int start, int stop) {
  for (int meter = start; meter <= stop; meter++) {
    double feet = MeterToFeet(meter);
    Console.WriteLine($"{meter}m = {feet:N4}ft");
  }
}