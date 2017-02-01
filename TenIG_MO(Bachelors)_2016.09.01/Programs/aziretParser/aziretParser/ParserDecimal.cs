using System.Collections.Generic;
using System.Linq;
using Extreme.Mathematics;

namespace aziretParser
{
    public class ParserDecimal
    {
        public static decimal Compute(string function, decimal value)
        {
            List<string> splitExpression = returnSplitExpression(function.Replace(" ", ""));
            Queue<string> revpExpression = returnPolish(splitExpression);

            decimal answer = calculate(revpExpression, value);
            return answer;
        }

        public static string ReturnDerivative(string function)
        {
            List<string> splitExpression = returnSplitExpression(function.Replace(" ", "").ToLower());
            Queue<string> revpExpression = returnPolish(splitExpression);

            string deriv = GetDerivative(revpExpression.ToList());

            List<string> splitDerivative = returnSplitExpression(deriv);
            Queue<string> revpDerivative = returnPolish(splitDerivative);
            deriv = NoBraces(revpDerivative);
            return deriv;
        }



        public static decimal calculate(Queue<string> polska, decimal x)
        {
            decimal answer = 0;

            Stack<decimal> opers = new Stack<decimal>();

            foreach (string s in polska)
            {
                if (standartOperators.Contains(s))
                {
                    decimal a;
                    decimal b;

                    switch (s)
                    {
                        case "+":
                            opers.Push(opers.Pop() + opers.Pop());
                            break;
                        case "-":
                            b = opers.Pop();
                            a = opers.Pop();
                            opers.Push(a - b);
                            break;
                        case "*":
                            opers.Push(opers.Pop() * opers.Pop());
                            break;
                        case "/":
                            b = opers.Pop();
                            a = opers.Pop();
                            opers.Push(a / b);
                            break;
                        case "^":
                            b = opers.Pop();
                            a = opers.Pop();
                            opers.Push(DecimalMath.Pow(a, b));
                            break;
                        case "%":
                            b = opers.Pop();
                            a = opers.Pop();
                            opers.Push(a % b);
                            break;
                        case "sqrt":
                            opers.Push(DecimalMath.Sqrt(opers.Pop()));
                            break;
                        case "sin":
                            opers.Push(DecimalMath.Sin(opers.Pop()));
                            break;
                        case "cos":
                            opers.Push(DecimalMath.Cos(opers.Pop()));
                            break;
                        case "tan":
                            opers.Push(DecimalMath.Tan(opers.Pop()));
                            break;
                        case "atan":
                            opers.Push(DecimalMath.Atan(opers.Pop()));
                            break;
                        case "acos":
                            opers.Push(DecimalMath.Acos(opers.Pop()));
                            break;
                        case "asin":
                            opers.Push(DecimalMath.Asin(opers.Pop()));
                            break;
                        case "acotan":
                            opers.Push(DecimalMath.Atan(1 / opers.Pop()));
                            break;
                        case "exp":
                            opers.Push(DecimalMath.Exp(opers.Pop()));
                            break;
                        case "ln":
                            opers.Push(DecimalMath.Log(opers.Pop()));
                            break;
                        case "log":
                            opers.Push(DecimalMath.Log10(opers.Pop()));
                            break;
                        case "sinh":
                            opers.Push(DecimalMath.Sinh(opers.Pop()));
                            break;
                        case "cosh":
                            opers.Push(DecimalMath.Cosh(opers.Pop()));
                            break;
                        case "tanh":
                            opers.Push(DecimalMath.Tanh(opers.Pop()));
                            break;
                        case "abs":
                            opers.Push(DecimalMath.Abs(opers.Pop()));
                            break;
                        case "ceil":
                            opers.Push(DecimalMath.Ceiling(opers.Pop()));
                            break;
                        case "floor":
                            opers.Push(DecimalMath.Floor(opers.Pop()));
                            break;
                        case "fac":
                            opers.Push(factorial(opers.Pop()));
                            break;
                        case "sfac":
                            opers.Push(semifactorial(opers.Pop()));
                            break;
                        case "round":
                            opers.Push(DecimalMath.Round(opers.Pop()));
                            break;
                        case "fpart":
                            a = opers.Pop();
                            opers.Push(a - DecimalMath.Truncate(a));
                            break;
                    }
                }
                else if (s == "x")
                {
                    opers.Push(x);
                }
                else
                {
                    opers.Push(decimal.Parse(s));
                }
            }

            answer = opers.Pop();
            return answer;
        }

        private static decimal semifactorial(decimal v)
        {
            long f = 1;
            long con = (long)v;

            if (con % 2 == 0)
            {
                for (long i = 2; i <= con; i += 2)
                {
                    f *= i;
                }
            }
            else
            {
                for (long i = 1; i <= con; i += 2)
                {
                    f *= i;
                }
            }
            return (decimal)f;
        }

        private static decimal factorial(decimal v)
        {
            long f = 1;
            long con = (long)v;

            for (long i = 1; i <= con; i++)
            {
                f *= i;
            }
            return (decimal)f;
        }


        public static string Derivative(List<string> polska)
        {
            Stack<string> opers = new Stack<string>();
            List<string> deriv = new List<string>();
            string answer = "";
            string a;
            string b;

            if (polska.Count == 1)
            {
                decimal d;
                if (decimal.TryParse(polska.Last(), out d))
                {
                    answer = "0";
                }

                if (polska.Last() == "x")
                {
                    answer = "1";
                }
            }
            else
            {
                switch (polska.Last())
                {
                    case "+":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        b = opers.Pop();
                        a = opers.Pop();
                        answer = "([" + a + "]" + "+" + "[" + b + "])";
                        break;
                    case "-":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        b = opers.Pop();
                        a = opers.Pop();
                        answer = "([" + a + "]" + "-" + "[" + b + "])";
                        break;
                    case "*":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        b = opers.Pop();
                        a = opers.Pop();
                        answer = "([" + a + "]*" + b + "+" + "[" + b + "]*" + a + ")";
                        break;
                    case "/":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        b = opers.Pop();
                        a = opers.Pop();
                        answer = "(([" + a + "]*" + b + "-" + "[" + b + "]*" + a + ")/(" + b + ")^2)";
                        break;
                    case "^":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        b = opers.Pop();
                        a = opers.Pop();
                        //a^b = b * a^(b-1) * a' + a^b * ln(a) * b'
                        answer = "(" + b + "*" + a + "^(" + b + "-1)*[" + a + "]" + "+" + a + "^" + b + "*ln(" + a + ")*[" + b + "])";
                        break;
                    case "sqrt":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "((" + a + ")^(-0.5)*[" + a + "]/2)";
                        break;
                    case "sin":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "(cos(" + a + ")*[" + a + "])";
                        break;
                    case "cos":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "((-sin(" + a + "))*[" + a + "])";
                        break;
                    case "tan":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/(cos(" + a + "))^2)";
                        break;
                    case "atan":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/(1+" + a + "^2))";
                        break;
                    case "acos":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "((-[" + a + "])/(1-" + a + "^2)^(0.5))";
                        break;
                    case "asin":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/(1-" + a + "^2)^(0.5))";
                        break;
                    case "acotan":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "((-[" + a + "])/(1+" + a + "^2))";
                        break;
                    case "exp":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "(exp(" + a + ")*[" + a + "])";
                        break;
                    case "ln":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/(" + a + "))";
                        break;
                    case "log":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/(x*ln(10)))";
                        break;
                    case "sinh":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]*" + "cosh(" + a + "))";
                        break;
                    case "cosh":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]*" + "sinh(" + a + "))";
                        break;
                    case "tanh":
                        polska.RemoveAt(polska.Count - 1);
                        opers = GetStack(polska);
                        a = opers.Pop();
                        answer = "([" + a + "]/" + "cosh(" + a + ")^2)";
                        break;
                }

            }

            return GetSimpleDerivatives(answer);
        }

        private static string GetSimpleDerivatives(string answer)
        {
            answer = answer.Replace("[x]", "1");
            answer = answer.Replace("[exp(x)]", "exp(x)");
            answer = answer.Replace("[ln(x)]", "1/x");
            answer = answer.Replace("[sin(x)]", "cos(x)");
            answer = answer.Replace("[cos(x)]", "(-sin(x))");
            answer = answer.Replace("[sqrt(x)]", "1/(2*x^0.5)");
            answer = answer.Replace("[tan(x)]", "1/(cos(x)^2)");
            answer = answer.Replace("[cotan(x)]", "(-1/(sin(x)^2))");
            answer = answer.Replace("[asin(x)]", "1/(1-x^2)^0.5");
            answer = answer.Replace("[acos(x)]", "(-1/(1-x^2)^0.5)");
            answer = answer.Replace("[atan(x)]", "1/(1+x^2)");
            answer = answer.Replace("[acotan(x)]", "(-1/(1+x^2))");
            answer = answer.Replace("[sinh(x)]", "cosh(x)");
            answer = answer.Replace("[cosh(x)]", "sinh(x)");
            answer = answer.Replace("[tanh(x)]", "1/cosh(x)^2");
            return answer;
        }

        internal static string GetDerivative(List<string> list)
        {
            string answer = Derivative(list);
            string beginning = "";
            string middle = "";
            string end = "";

            while (answer.Contains('['))
            {
                char[] ans = answer.ToArray();

                bool flagBeg = true;
                bool flagMid = false;

                foreach (char a in ans)
                {
                    if (a == '[' && flagBeg == true)
                    {
                        flagBeg = false;
                        flagMid = true;
                        continue;
                    }

                    if (a == ']' && flagMid == true)
                    {
                        flagMid = false;
                        continue;
                    }

                    if (flagBeg)
                    {
                        beginning += a.ToString();
                    }
                    else if (flagMid)
                    {
                        middle += a.ToString();
                    }
                    else
                    {
                        end += a.ToString();
                    }
                }

                List<string> splitExpression = returnSplitExpression(middle);
                Queue<string> reversePolish = returnPolish(splitExpression);
                middle = Derivative(reversePolish.ToList());
                answer = beginning + middle + end;
                beginning = "";
                middle = "";
                end = "";
            }

            return answer;
        }


        private static Stack<string> GetStack(List<string> polska)
        {
            Stack<string> opers = new Stack<string>();
            string a;
            string b;

            foreach (string s in polska)
            {
                if (standartOperators.Contains(s))
                {
                    if (prior1.Contains(s))
                    {
                        opers.Push(s + "(" + opers.Pop() + ")");
                    }
                    else
                    {
                        switch (s)
                        {
                            case "+":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "+" + b);
                                break;
                            case "-":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "-" + b);
                                break;
                            case "*":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "*" + b);
                                break;
                            case "/":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "/" + b);
                                break;
                            case "^":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "^" + b);
                                break;
                            case "%":
                                b = opers.Pop();
                                a = opers.Pop();
                                opers.Push(a + "%" + b);
                                break;

                        }
                    }
                }
                else
                {
                    opers.Push(s);
                }
            }

            return opers;
        }

        public static List<string> returnSplitExpression(string expr)
        {
            char[] symbols = expr.ToArray();


            List<string> operands = new List<string>();
            string current = "";

            foreach (char ch in symbols)
            {
                switch (ch)
                {
                    case '(':
                    case ')':
                    case '+':
                    case '-':
                    case '*':
                    case '^':
                    case '/':
                        if (current != "")
                        {
                            operands.Add(current);
                        }
                        current = "";

                        operands.Add(ch.ToString());
                        break;
                    default:
                        current += ch;
                        break;


                }

            }

            if (current != "")
            {
                operands.Add(current);
            }

            List<string> expression = new List<string>();

            foreach (string s in operands)
            {
                expression.Add(s);
            }

            for (int i = 0; i < expression.Count; i++)
            {
                if (i == 0)
                {
                    switch (expression[i])
                    {
                        case "-":
                            expression.Insert(0, "0");
                            break;
                        case "+":
                            expression.RemoveAt(i);
                            break;
                    }
                }
                if (expression[i] == "(")
                {
                    switch (expression[i + 1])
                    {
                        case "-":
                            expression.Insert(i + 1, "0");
                            break;
                        case "+":
                            expression.RemoveAt(i);
                            break;
                    }
                }
            }

            return expression;

        }

        static List<string> standartOperators = new List<string> {
                "+", "-", "*", "/", "^", "%",
                "sqrt", "sin", "cos", "tan",
                "atan", "acos", "asin", "acotan",
                "exp", "ln", "log",
                "sinh", "cosh", "tanh", "abs",
                "ceil", "floor", "fac", "sfac", "round", "fpart"
            };

        static List<string> braces = new List<string>
            {
                "(", ")"
            };

        static List<string> prior2 = new List<string>
            {
                "^"
            };

        static List<string> prior1 = new List<string>
            {
                 "sqrt", "sin", "cos", "tan",
                "atan", "acos", "asin", "acotan",
                "exp", "ln", "log",
                "sinh", "cosh", "tanh", "abs",
                "ceil", "floor", "fac", "sfac", "round", "fpart"
            };

        static List<string> prior3 = new List<string>
            {
                "*", "/", "%"
            };


        static List<string> prior4 = new List<string>
            {
                "+", "-"
            };

        public static Queue<string> returnPolish(List<string> expression)
        {
            Stack<string> operators = new Stack<string>();
            Queue<string> polska = new Queue<string>();


            foreach (string s in expression)
            {
                if (braces.Contains(s))
                {
                    if (s == "(")
                    {
                        operators.Push(s);
                    }
                    else
                    {
                        while (operators.Peek() != "(")
                        {
                            polska.Enqueue(operators.Peek());
                            operators.Pop();
                        }
                        if (operators.Peek() == "(")
                        {
                            operators.Pop();
                        }
                    }
                }
                else if (standartOperators.Contains(s))
                {
                    if (prior1.Contains(s))
                    {
                        while (operators.Count != 0 && prior1.Contains(operators.Peek()))
                        {
                            polska.Enqueue(operators.Peek());
                            operators.Pop();
                        }
                        operators.Push(s);
                    }
                    else if (prior2.Contains(s))
                    {
                        while (operators.Count != 0 && (prior1.Contains(operators.Peek()) || prior2.Contains(operators.Peek())))
                        {
                            polska.Enqueue(operators.Peek());
                            operators.Pop();
                        }
                        operators.Push(s);
                    }
                    else if (prior3.Contains(s))
                    {
                        while (operators.Count != 0 && (prior1.Contains(operators.Peek()) || prior2.Contains(operators.Peek()) || prior2.Contains(operators.Peek())))
                        {
                            polska.Enqueue(operators.Peek());
                            operators.Pop();
                        }
                        operators.Push(s);
                    }
                    else
                    {
                        while (operators.Count != 0 &&
                            (prior1.Contains(operators.Peek())
                        || prior2.Contains(operators.Peek())
                        || prior3.Contains(operators.Peek())
                        || prior4.Contains(operators.Peek())))
                        {
                            polska.Enqueue(operators.Peek());
                            operators.Pop();
                        }
                        operators.Push(s);
                    }
                }
                else
                {
                    polska.Enqueue(s);
                }
            }


            while (operators.Count != 0)
            {
                polska.Enqueue(operators.Peek());
                operators.Pop();
            }

            return checking(polska);
        }

        private static Queue<string> checking(Queue<string> polska)
        {
            Stack<string> opers = new Stack<string>();

            foreach (string s in polska)
            {
                if (standartOperators.Contains(s))
                {
                    if (prior1.Contains(s))
                    {
                        opers.Push(opers.Pop() + s);
                    }
                    else
                    {
                        opers.Push(opers.Pop() + opers.Pop() + s);
                    }
                }
                else
                {
                    opers.Push(s);
                }
            }

            if (opers.Count != 1)
            {
                return null;
            }
            else
            {
                return polska;
            }
        }

        static Stack<string> polish = new Stack<string>();

        public static string NoBraces(Queue<string> polska)
        {
            polish = new Stack<string>();

            foreach (string s in polska)
            {
                polish.Push(s);
            }

            string lastOperator = polish.Pop();
            if (standartOperators.Contains(lastOperator))
            {
                string answer = DeleteBraces(polish, lastOperator);
                while (answer.Contains("++") || answer.Contains("+-") || answer.Contains("-+") || answer.Contains("--"))
                {
                    answer = answer.Replace("++", "+");
                    answer = answer.Replace("+-", "-");
                    answer = answer.Replace("-+", "-");
                    answer = answer.Replace("--", "+");
                }
                return answer;
            }
            else
            {
                return lastOperator;
            }
        }

        private static string DeleteBraces(Stack<string> polish, string previousOperator)
        {
            string a;
            string b;

            if (prior1.Contains(previousOperator))
            {
                a = polish.Pop();
                if (standartOperators.Contains(a))
                {
                    a = DeleteBraces(polish, a);
                }
                return (previousOperator + "(" + a + ")");
            }
            else if (prior2.Contains(previousOperator))
            {
                b = polish.Pop();
                if (standartOperators.Contains(b))
                {
                    if (prior1.Contains(b))
                    {
                        b = DeleteBraces(polish, b);
                    }
                    else
                    {
                        b = "(" + DeleteBraces(polish, b) + ")";
                    }
                }

                a = polish.Pop();
                if (standartOperators.Contains(a))
                {
                    if (prior1.Contains(a))
                    {
                        a = DeleteBraces(polish, a);
                    }
                    else
                    {
                        a = "(" + DeleteBraces(polish, a) + ")";
                    }
                }

                if (b == "(1)" || b == "1")
                {
                    return a;
                }
                else
                {
                    return a + previousOperator + b;
                }

            }
            else if (prior3.Contains(previousOperator))
            {
                b = polish.Pop();
                if (standartOperators.Contains(b))
                {
                    if (prior4.Contains(b))
                    {
                        b = "(" + DeleteBraces(polish, b) + ")";
                    }
                    else
                    {
                        b = DeleteBraces(polish, b);
                    }
                }

                a = polish.Pop();
                if (standartOperators.Contains(a))
                {
                    if (prior4.Contains(a))
                    {
                        a = "(" + DeleteBraces(polish, a) + ")";
                    }
                    else
                    {
                        a = DeleteBraces(polish, a);
                    }
                }

                if (a == "0" || b == "0")
                {
                    if (previousOperator == "*")
                    {
                        return "0";
                    }
                    else
                    {
                        if (a == "0" && b != "0")
                        {
                            return "0";
                        }
                        else
                        {
                            return "error!";
                        }
                    }
                }
                else
                {
                    if (previousOperator == "*")
                    {
                        if (a == "1")
                        {
                            return b;
                        }

                        if (b == "1")
                        {
                            return a;
                        }
                    }
                    else
                    {
                        if (b == "1")
                        {
                            return a;
                        }
                    }
                    return a + previousOperator + b;
                }
            }
            else
            {
                //надо добавить упрощение выражений
                b = polish.Pop();
                if (standartOperators.Contains(b))
                {
                    b = DeleteBraces(polish, b);
                }

                a = polish.Pop();
                if (standartOperators.Contains(a))
                {
                    a = DeleteBraces(polish, a);
                }

                if (a == "0" || b == "0")
                {
                    if (previousOperator == "+")
                    {
                        if (a == "0")
                        {
                            return b;
                        }
                        else
                        {
                            return a;
                        }
                    }
                    else
                    {
                        if (a == "0" && b == "0")
                        {
                            return "0";
                        }
                        else
                        {
                            if (a == "0")
                            {
                                return previousOperator + b;
                            }
                            else
                            {
                                return a;
                            }
                        }
                    }
                }

                decimal checkDecimal;
                if (decimal.TryParse(a, out checkDecimal) && decimal.TryParse(b, out checkDecimal))
                {
                    if (previousOperator == "-")
                    {
                        return (decimal.Parse(a) - decimal.Parse(b)).ToString();
                    }
                    else
                    {
                        return (decimal.Parse(a) + decimal.Parse(b)).ToString();
                    }
                }
                else
                {
                    return a + previousOperator + b;
                }
            }
        }
    }
}
