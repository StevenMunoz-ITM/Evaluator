using Evaluator.Logic;

Console.WriteLine("Hello, Evaluator!");
var infix = "35,12^(13,24/7,6)";
var result = ExpressionEvaluator.Evaluate(infix);
Console.WriteLine($"{infix} = {result}");