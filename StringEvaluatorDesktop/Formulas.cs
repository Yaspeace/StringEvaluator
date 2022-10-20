using System;
using System.Collections.Generic;

/*
 * 2DO: 
 * 1. Сделать класс статическим
 * 2. Вместо работы со строкой (Queue<char>), добавить классы вроде Token, Variable, и т.п. и работать с ними
 *   (Это также уберёт ограничение на величину вычисляемого выражения)
 * 3. Убрать этот костыль с циклом на 100 повторений в методе Modify
 * 4. Изменить название класса на более подходящее
 * 5. Добавить возможность выбора пользователем, от скольких переменных будет выражение (соответственно изменить сигнатуру метода Evaluate)
 * 6. Добавить приоритеты функциям, чтобы не писать их вечно в скобках
 */

namespace SortStation_CS
{
    /// <summary>
    /// Класс, предоставляющий метод Evaluate - позволяет вычислить значение математического
    /// выражения, записанного в строке. Выражение может быть от двух переменных: x и y.
    /// Если переменная y не используется, её значение можно указать как 0.
    /// Доступно использование таких функций как:
    /// sin, cos, tan, ln, sqrt, ^ (степень)
    /// Примечание: Аргумент функции пишется в скобках после неё. Саму функцию тоже лучше брать в скобки.
    /// </summary>
    class Formulas
    {
        private static char[] Variables = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'z' }; //Переменные, кот. будут подставлятся вместо чисел
        private int _variableCount; //Счётчик кол-ва используемых переменных
        private double[] Values = new double[24]; //Значения, соответствующие переменным

        public Formulas()
        {
            _variableCount = 0;
            for (int i = 0; i < 24; i++)
                Values[i] = 0;
        }

        private static bool IsVariable(char _symbol) //Предикаты: чем является токен
        {
            return _symbol == 'x' || _symbol == 'y';
        }

        private static bool IsParametr(char _symbol)
        {
            return _symbol >= 'a' && _symbol <= 'z' && _symbol != 'x' && _symbol != 'y';
        }

        private static bool IsNumber(char _symbol)
        {
            return _symbol >= '0' && _symbol <= '9';
        }

        private static bool IsOperation(char _symbol)
        {
            return _symbol == '+' || _symbol == '-' || _symbol == '*' || _symbol == '/' || _symbol == '!';
        }

        private static bool IsFunc(char _symbol)
        {
            return _symbol == 'S' || _symbol == 'C' || _symbol == 'T' || _symbol == 'L' || _symbol == 'Q';
        }

        private static bool IsOpeningPar(char _symbol)
        {
            return _symbol == '(';
        }

        private static bool IsClosingPar(char _symbol)
        {
            return _symbol == ')';
        }

        private static int priority(char _symbol) //Приоритет операций
        {
            switch(_symbol)
            {
                case ('!'):
                    return 3;
                case ('*'):
                case ('/'):
                    return 2;
                case ('+'):
                case ('-'):
                    return 1;
            }
            return 0;
        }

        private static bool op_left_assoc(char _symbol) //Является ли операция лево- или правоассоциативной (принимает 1 или 2 операнда)
        {
            switch (_symbol)
            {
                // лево-ассоциативные операторы
                case '*':
                case '/':
                case '+':
                case '-':
                    return true;
                // право-ассоциативные операторы
                case '!':
                    return false;
            }
            return false;
        }

        private static int op_arg_count(char _symbol) //Возвращает кол-во операндов, принимаемых оп-цией/ф-цией
        {
            switch (_symbol)
            {
                case '*':
                case '/':
                case '+':
                case '-':
                    return 2;
                case '!':
                case 'S':
                case 'C':
                case 'T':
                case 'L':
                case 'Q':
                    return 1;

                default:
                    return _symbol - 'A';
            }
        }

        private string ModifyExpr(string _inputExpr) //Преобразование выражения в строке для возможности перевода его в ОПЗ
        {
            int i = 0;
            string _outExpr = String.Empty;
            while(i < _inputExpr.Length)
            {
                if (_inputExpr[i] == ' ') //Если пробел- не вносим
                    i++;
                //Если операнд(не унарный) или переменная или скобка- вносим
                else if ((IsOperation(_inputExpr[i]) && _inputExpr[i] != '-') || IsOpeningPar(_inputExpr[i]) || IsClosingPar(_inputExpr[i]) || IsVariable(_inputExpr[i]) || IsFunc(_inputExpr[i]))
                {
                    _outExpr += _inputExpr[i];
                    i++;
                }
                else if(_inputExpr[i] == '-') //Если встретился минус
                {
                    if(i == 0) //Если он унарный- заменяется символом '!'
                    {
                        _outExpr += '!';
                        i++;
                    }
                    else if(IsOpeningPar(_inputExpr[i-1]))
                    {
                        _outExpr += '!';
                        i++;
                    }
                    else //Если бинарный- вносится без изменений
                    {
                        _outExpr += '-';
                        i++;
                    }
                }
                else if(IsNumber(_inputExpr[i])) //Если число, вместо него вносится переменная
                {
                    string temp = String.Empty;
                    _outExpr += Variables[this._variableCount];
                    while(i < _inputExpr.Length)
                    {
                        if (!IsNumber(_inputExpr[i]) && _inputExpr[i] != ',')
                            break;
                        temp += _inputExpr[i];
                        i++;
                    }
                    this.Values[this._variableCount] = Convert.ToDouble(temp);
                    this._variableCount++;
                }
                else if(_inputExpr[i] == 's' && _inputExpr[i+1] == 'i' && _inputExpr[i+2] == 'n') //ф-ция sin заменяется на 'S'
                {
                    _outExpr += 'S';
                    i += 3;
                }
                else if( i < _inputExpr.Length - 3 && _inputExpr[i] == 'c' && _inputExpr[i + 1] == 'o' && _inputExpr[i + 2] == 's') //cos- на 'C'
                {
                    _outExpr += 'C';
                    i += 3;
                }
                else if (_inputExpr[i] == 't' && _inputExpr[i + 1] == 'a' && _inputExpr[i + 2] == 'n') //tan на 'T'
                {
                    _outExpr += 'T';
                    i += 3;
                }
                else if(_inputExpr[i] == 'l' && _inputExpr[i + 1] == 'n') //ln на 'L'
                {
                    _outExpr += 'L';
                    i += 2;
                }
                else if (_inputExpr[i] == 's' && _inputExpr[i + 1] == 'q' && _inputExpr[i + 2] == 'r' && _inputExpr[i + 3] == 't') //sqrt на 'Q'
                {
                    _outExpr += 'Q';
                    i += 4;
                }
                else if(_inputExpr[i] == '^') //Если знак возведения в степени, вносим умножения переменных (н.п. вместо x^3 будет x*x*x)
                {
                    string temp = String.Empty;
                    int j = i - 1;
                    i++;
                    while(i < _inputExpr.Length)
                    {
                        if (!IsNumber(_inputExpr[i]))
                            break;
                        temp += _inputExpr[i];
                        i++;
                    }
                    int power = Convert.ToInt32(temp);
                    if(IsClosingPar(_inputExpr[j])) //если перед знаком '^'- закрывающая скобка, нужно несколько раз записать всю скобку, н.п. (x+5)^2 --> (x+5)*(x+5)
                    {
                        temp = String.Empty;
                        temp += _inputExpr[j];
                        int numOfPars = 1;
                        while(numOfPars > 0)
                        {
                            j--;
                            temp += _inputExpr[j];
                            if (IsClosingPar(_inputExpr[j]))
                                numOfPars++;
                            if (IsOpeningPar(_inputExpr[j]))
                                numOfPars--;
                        }
                        char[] t = temp.ToCharArray();
                        Array.Reverse(t);
                        temp = new string(t);
                        power--;
                        while(power > 0)
                        {
                            _outExpr += '*';
                            _outExpr += temp;
                            power--;
                        }
                    }
                    if(IsVariable(_inputExpr[j]))
                    {
                        power--;
                        char tempchar = _inputExpr[j];
                        while(power > 0)
                        {
                            _outExpr += '*';
                            _outExpr += tempchar;
                            power--;
                        }
                    }
                }
                else if(IsParametr(_inputExpr[i]))
                {
                    _outExpr += _inputExpr[i];
                    i++;
                }
            }
            return _outExpr;
        }

        //ToDo: Можно повторять цикл не 100 раз, а пока после очередной итерации строка не будет равна строке на пред. итерации
        //Т.е. пока после итерации строка была изменена.
        private string Modify(string s1) //Повторяем 100 раз, чтобы точно всё привелось к нужному виду (костыль-костылём, но иначе- дольше писать)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{i + 1}%");
                int j = i + 1;
                while (j > 0)
                {
                    Console.Write("\b");
                    j--;
                }
                s1 = ModifyExpr(s1);
            }
            return s1;
        }

        //Алгоритм сортировочной станции Дейкстры, приводим к виду ОПЗ
        private static Queue<char> SortStation(Queue<char> input) 
        {
            char c, sc;
            Stack<char> stack = new Stack<char>();
            Queue<char> output = new Queue<char>();
            int sl = 0;
            while (input.Count > 0)
            {
                c = input.Peek();
                // Если токен является числом (идентификатором), то добавить его в очередь вывода.
                if (IsVariable(c) || IsParametr(c))
                {
                    output.Enqueue(c);
                }
                // Если токен - функция, то положить его в стек.
                else if (IsFunc(c))
                {
                    stack.Push(c);
                }
                // Если токен оператор op1, то:
                else if (IsOperation(c))
                {
                    while (stack.Count > 0)
                    {
                        sc = stack.Peek();
                        // Пока на вершине стека присутствует токен оператор op2,
                        // а также оператор op1 лево-ассоциативный и его приоритет меньше или такой же чем у оператора op2,
                        // или оператор op1 право-ассоциативный и его приоритет меньше чем у оператора op2
                        if (IsOperation(sc) &&
                            ((op_left_assoc(c) && (priority(c) <= priority(sc))) ||
                               (!op_left_assoc(c) && (priority(c) < priority(sc)))))
                        {
                            // Переложить оператор op2 из стека в очередь вывода.
                            output.Enqueue(sc);
                            stack.Pop();
                        }
                        else
                            break;
                    }
                    // положить в стек оператор op1
                    stack.Push(c);
                }
                // Если токен - левая круглая скобка, то положить его в стек.
                else if (c == '(')
                    stack.Push(c);
                // Если токен - правая круглая скобка:
                else if (c == ')')
                {
                    bool pe = false;
                    // До появления на вершине стека токена "левая круглая скобка"
                    // перекладывать операторы из стека в очередь вывода.
                    while (stack.Count > 0)
                    {
                        sc = stack.Peek();
                        if (sc == '(')
                        {
                            pe = true;
                            break;
                        }
                        else
                        {
                            output.Enqueue(sc);
                            stack.Pop();
                        }
                    }
                    // Если стек кончится до нахождения токена левая круглая скобка, то была пропущена скобка.
                    if (!pe)
                    {
                        Console.WriteLine("Error: parentheses mismatched\n");
                        return null;
                    }
                    // выкидываем токен "левая круглая скобка" из стека (не добавляем в очередь вывода).
                    stack.Pop();
                    // Если на вершине стека токен - функция, положить его в стек.
                    if (sl > 0)
                    {
                        sc = stack.Peek();
                        if (IsFunc(sc))
                        {
                            output.Enqueue(sc);
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Unknown token {c}");
                    return null; // Unknown token
                }
                input.Dequeue();
            }
            // Когда не осталось токенов на входе:
            // Если в стеке остались токены:
            while (stack.Count > 0)
            {
                sc = stack.Peek();
                if (sc == '(' || sc == ')')
                {
                    Console.WriteLine("Error: parentheses mismatched");
                    return null;
                }
                output.Enqueue(sc);
                stack.Pop();
            }
            return output;
        }

        //Возвращает позицию символа в массиве, если такого нет- возвращает -1
        private static int Find(char[] arr, char ch)
        {
            int i = 0;
            while(i < arr.Length)
            {
                if (arr[i] == ch)
                    return i;
                i++;
            }
            return -1;
        }

        //Вычисление функции, результат помещается в стек
        private Stack<char> EvalFunc(char _f, Stack<char> inStack, double xVal, double yVal)
        {
            //синус
            if(_f == 'S')
            {
                char operand = inStack.Pop();
                int pos = Find(Variables, operand);
                if(pos >= 0)
                {
                    Values[_variableCount] = Math.Sin(Values[pos]);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    if (operand == 'x')
                    {
                        Values[_variableCount] = Math.Sin(xVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                    if(operand == 'y')
                    {
                        Values[_variableCount] = Math.Sin(yVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                }
            }
            //косинус
            if(_f == 'C')
            {
                char operand = inStack.Pop();
                int pos = Find(Variables, operand);
                if (pos >= 0)
                {
                    Values[_variableCount] = Math.Cos(Values[pos]);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    if (operand == 'x')
                    {
                        Values[_variableCount] = Math.Cos(xVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                    else
                    {
                        Values[_variableCount] = Math.Cos(yVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                }
            }
            //тангенс
            if (_f == 'T')
            {
                char operand = inStack.Pop();
                int pos = Find(Variables, operand);
                if (pos >= 0)
                {
                    Values[_variableCount] = Math.Tan(Values[pos]);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    if (operand == 'x')
                    {
                        Values[_variableCount] = Math.Tan(xVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                    else
                    {
                        Values[_variableCount] = Math.Tan(yVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                }
            }
            //натур. логарифм
            if (_f == 'L')
            {
                char operand = inStack.Pop();
                int pos = Find(Variables, operand);
                if (pos >= 0)
                {
                    Values[_variableCount] = Math.Log(Values[pos]);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    if (operand == 'x')
                    {
                        Values[_variableCount] = Math.Log(xVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                    else
                    {
                        Values[_variableCount] = Math.Log(yVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                }
            }
            //квадратный корень
            if (_f == 'Q')
            {
                char operand = inStack.Pop();
                int pos = Find(Variables, operand);
                if (pos >= 0)
                {
                    Values[_variableCount] = Math.Sqrt(Values[pos]);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    if (operand == 'x')
                    {
                        Values[_variableCount] = Math.Sqrt(xVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                    else
                    {
                        Values[_variableCount] = Math.Sqrt(yVal);
                        inStack.Push(Variables[_variableCount]);
                        _variableCount++;
                    }
                }
            }
            return inStack;
        }
        
        //Вычисление унарной операции (отрицание), результат помещается в стек
        private Stack<char> EvalUnOp(Stack<char> inStack, double xVal, double yVal)
        {
            char operand = inStack.Pop();
            int pos = Find(Variables, operand);
            if (pos >= 0)
            {
                Values[pos] *= -1;
                inStack.Push(Variables[pos]);
            }
            else
            {
                if (operand == 'x')
                {
                    Values[_variableCount] = xVal * (-1);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
                else
                {
                    Values[_variableCount] = yVal * (-1);
                    inStack.Push(Variables[_variableCount]);
                    _variableCount++;
                }
            }
            return inStack;
        }

        //Вычисление бинарных оп-ций, результат помещается в стек
        private Stack<char> EvalBinOp(char _op, Stack<char> inStack, double xVal, double yVal)
        {
            char roperand = inStack.Pop(); //берём из стека правую переменную
            char loperand = inStack.Pop(); //затем левую
            double rVal, lVal;
            int pos1 = Find(Variables, loperand);
            int pos2 = Find(Variables, roperand);
            if (pos1 >= 0) //устанавливаем значение левой
                lVal = Values[pos1];
            else
            {
                if (loperand == 'x')
                    lVal = xVal;
                else
                    lVal = yVal;
            }
            if (pos2 >= 0) //затем правой
                rVal = Values[pos2];
            else
            {
                if (roperand == 'x')
                    rVal = xVal;
                else
                    rVal = yVal;
            }
            switch (_op)
            {
                case ('*'):
                    Values[_variableCount] = lVal * rVal; break;
                case ('/'):
                    Values[_variableCount] = lVal / rVal; break;
                case ('+'):
                    Values[_variableCount] = lVal + rVal; break;
                case ('-'):
                    Values[_variableCount] = lVal - rVal; break;
            }
            //результат помещаем в стек
            inStack.Push(Variables[_variableCount]);
            _variableCount++;
            return inStack;
        }

        //Вычисление значения выражения модифицируя стек. В конце в стеке останется одна переменная- значение выражения
        public double Evaluate(string _inputString, double xVal, double yVal)
        {
            _inputString = Modify(_inputString);
            Queue<char> input = new Queue<char>(_inputString);
            input = SortStation(input);
            char c = ' ';
            Stack<char> stack = new Stack<char>();
            // Пока на входе остались токены
            while (input.Count > 0)
            {
                // Прочитать следующий токен
                c = input.Peek();
                // Если токен - значение или идентификатор
                if (IsVariable(c) || IsParametr(c))
                    // Поместить его в стек
                    stack.Push(c);
                // В противном случае, токен - оператор (здесь под оператором понимается как оператор, так и название функции)
                else if (IsOperation(c) || IsFunc(c))
                {
                    // Априори известно, что оператор принимает n аргументов
                    int nargs = op_arg_count(c);
                    // Если в стеке значений меньше, чем n
                    if (stack.Count < nargs)
                        // (ошибка) Недостаточное количество аргументов в выражении.
                        return 0;
                    // В противном случае, Вычислить оператор, взяв эти значения в качестве аргументов
                    if (IsFunc(c))
                        stack = EvalFunc(c, stack, xVal, yVal);
                    else
                    {
                        if (nargs == 1)
                            EvalUnOp(stack, xVal, yVal);
                        else
                            EvalBinOp(c, stack, xVal, yVal);
                    }
                }
                input.Dequeue();
            }
            // Если в стеке осталось лишь одно значение,
            // оно будет являться результатом вычислений.
            if (stack.Count == 1)
            {
                c = stack.Pop();
                int pos = Find(Variables, c);
                return Values[pos];
            }
            // Если в стеке большее количество значений,
            // (ошибка) Пользователь ввёл слишком много значений.
            return 0;
        }
    }
}
