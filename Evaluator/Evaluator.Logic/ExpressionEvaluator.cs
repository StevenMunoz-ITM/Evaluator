namespace Evaluator.Logic;

public class ExpressionEvaluator
{
    public static double Evaluate(string infix)
    {
        var posfix = InfixToPostfix(infix);
        return Calculate(posfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = string.Empty;
        int i = 0;
        while (i < infix.Length)
        {
            if (char.IsDigit(infix[i]) || infix[i] == '.' || infix[i] == ',')
            {
                var number = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.' || infix[i] == ','))
                {
                    number += (infix[i] == ',' ? '.' : infix[i]);
                    i++;
                }
                postfix += number + " ";
                continue;
            }
            if (IsOperator(infix[i]))
            {
                if (infix[i] == ')')
                {
                    do
                    {
                        postfix += stack.Pop() + " ";
                    } while (stack.Peek() != '(');
                    stack.Pop();
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        if (PriorityInfix(infix[i]) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(infix[i]);
                        }
                        else
                        {
                            postfix += stack.Pop() + " ";
                            stack.Push(infix[i]);
                        }
                    }
                    else
                    {
                        stack.Push(infix[i]);
                    }
                }
            }
            else if (!char.IsWhiteSpace(infix[i]))
            {
                throw new Exception($"Invalid character: {infix[i]}");
            }
            i++;
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop() + " ";
        }
        return postfix.Trim();
    }

    private static bool IsOperator(char item) => item is '^' or '*' or '/' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid Expression"),
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid Expression"),
    };

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        var tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calculate(op1, token[0], op2));
            }
            else
            {
                if (double.TryParse(token, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double value))
                {
                    stack.Push(value);
                }
                else
                {
                    throw new Exception($"Token inválido: '{token}'");
                }
            }
        }
        return stack.Peek();
    }

    private static double Calculate(double op1, char item, double op2) => item switch
    {
        '^' => Math.Pow(op1, op2),
        '*' => op1 * op2,
        '/' => op1 / op2,
        '%' => op1 % op2,
        '+' => op1 + op2,
        '-' => op1 - op2,
        _ => throw new Exception("Invalid Expression"),
    };
}