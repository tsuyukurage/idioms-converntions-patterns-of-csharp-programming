// 完全修飾名で記述すると
// System.Diagnostics.Debug.WriteLine("Entering Programming");
// System.Console.WriteLine("Hello World.");
// System.Diagnostics.Debug.WriteLine("Exiting Programming");

using System; // Consoleクラスを利用するために必要 C#10以降では省略可能
using System.Diagnostics; // Debugクラスを利用するために必要

using SampleApp;

Debug.WriteLine("Entering Programming");
Console.WriteLine("Hello World.");
Debug.WriteLine("Exiting Programming");

MyApp myApp = new();
myApp.Run();