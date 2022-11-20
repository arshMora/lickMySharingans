// ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №310. Проверка на простоту */

/*int n = Convert.ToInt32(Console.ReadLine()); // число
Console.WriteLine(isPrime(n));

string isPrime(int n)
{
    for (int i = n/2; i >= Math.Sqrt(n); i--)
    {
        if (n % i == 0)
        {
            return "composite";
        }
    } return "prime";
}*/
// ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №312. Числа Фибоначчи */

/*int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FibonacciCompare(n,m));

bool FibonacciCompare(int x, int y)
{
    x = Fibonacci(x);
    y = Fibonacci(y);

    if (x % y == 0) return true;
    else return false;
}


int Fibonacci(int z)
{
    int fbPrev = 0;
    int fbNext = 1;
    int fbCurr = fbNext;
    for (int i = 2; i <= z; i++)
    {
        fbCurr = fbPrev + fbNext;
        fbPrev = fbNext;
        fbNext = fbCurr;
    }
    return fbCurr;
}*/




// ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/**/

/*ulong n = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine((Math.Ceiling(Math.Sqrt(5*(n*n)+4))== Math.Truncate(Math.Sqrt(5 * (n * n) + 4))) ? "true" : "false");*/


// ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №114. Сумма цифр числа */

/*int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(n));
// вычисляет сумму цифр числа n
// входные параметры - int x 
// выходные параметры - сумма цифр int sum
int SumOfDigits(int x)
{
    string xString = Convert.ToString(x); // переводим число в строку
    int sum = 0; // переменная суммы чисел
    for (int i = 0; i < xString.Length; i++)
    {
        sum += (int)Char.GetNumericValue(xString[i]); // конвертирует char символ (xString[i]) в int и суммирует
    }
    return sum;
}*/
// ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №3023. N-GCD */

/*string arrView = ""; // строковое отображение элементов массива

Console.WriteLine($"Введите значение n (кол. целых чисел): ");
int n = Convert.ToInt32(Console.ReadLine()); // количество целых чисел
int[] arr = new int[n]; // масив целых чисел

Console.WriteLine($"\nВведите значения чисел:");
for (int i = 0; i < n; i++)
{
    // вводим n целых чисел в массив arr
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

foreach(int i in arr)
{
    // записываем все элементы массива в переменную arrView с разделителем 
    arrView += Convert.ToString(i)+"|";
}
Console.Write($"\nМассив чисел: ");
Console.WriteLine(arrView = arrView.Remove(arrView.Length - 1)); // удаление последнего лишнего символа arrView

//Console.WriteLine($"\nНОД чисел {arrView} равен: {Euclid(arr)}");

Console.WriteLine($"\nНОД чисел {arrView} равен: {NEuclid(arr)}");

int NEuclid(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
       result = Euclid(arr[i], arr[i+1]);
    }
    return result;
}

int Euclid(int arrPrev, int arrNext)
{
    int nod = 0;
    while (arrPrev != 0 && arrNext != 0)
    {
        if (arrPrev > arrNext)
        {
            arrPrev = arrPrev % arrNext;
        }
        else
        {
            arrNext = arrNext % arrPrev;
        }
    }
    nod = arrPrev + arrNext;
    if (nod == 1) return 1;
    
    return nod;
}*/
//▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №3024. Perimetr */

// количество вершин треугольника
int numberOfCoordinates = 6;

// массив со всеми координатами многоугольника. 
int[] arr = new int[numberOfCoordinates];

Console.WriteLine($"Введите поочередно координаты x и y каждой вершины:");
// поочерёдный ввод координат вершин (x1,y1, x2,y2 ... xi,yi)
for (int i = 0; i < numberOfCoordinates; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"\nПериметр треугольника:\t{Perimeter(arr)}");

double Perimeter(int[] arr)
{
    // цикл для вывода в консоль текущих координат
    Console.WriteLine($"Текущие координаты: \n x\t\b\b\b\b\b| y\n▬▬▬▬▬▬▬");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}\t\b\b\b\b\b| {arr[++i]}");
    }

    // массив c координатами разностей 
    int[] deltaCoordinatesArray = new int[numberOfCoordinates];
    int suppTempForLastSub = 0;
    // пытаюсь найти разность соответствующих координат точки конца вектора и начала (x2-x1, y2-y1)
    for (int i = 0; suppTempForLastSub < 4; i++)
    {
        deltaCoordinatesArray[i] = arr[i + 2] - arr[i];
        suppTempForLastSub++;
    }
    if (suppTempForLastSub == 4)
    {
        deltaCoordinatesArray[numberOfCoordinates - 2] = arr[numberOfCoordinates - 2] - arr[0];
        deltaCoordinatesArray[numberOfCoordinates - 1] = arr[numberOfCoordinates - 1] - arr[1];
    }
    Console.WriteLine($"\nКоординаты векторов: \n x\t\b\b\b\b\b| y\n▬▬▬▬▬▬▬");
    for (int i = 0; i < deltaCoordinatesArray.Length; i++)
    {
        Console.WriteLine($"{deltaCoordinatesArray[i]}\t\b\b\b\b\b| {deltaCoordinatesArray[++i]}");
    }

    // теперь находим длины сторон треугольников по пифагору

    // массив длин сторон треугольника (всё соответственно по порядку)
    double[] deltaSidesLength = new double[deltaCoordinatesArray.Length / 2];

    // вспомогательная переменная, служая для итерации в следующем цикле while и как индексатор для массива deltaSlidesLength в этом же цикле
    int suppIterator = 0;
    // вспомогательный индексатор для возведения нужных чисел в степень
    int suppIndexator = 0;

    // цикл для нахождения всех длин сторон треугольника по пифагору
    while (suppIterator < deltaSidesLength.Length)
    {
        deltaSidesLength[suppIterator] = Math.Sqrt(Math.Pow(deltaCoordinatesArray[suppIndexator], 2) + Math.Pow(deltaCoordinatesArray[++suppIndexator], 2));
        suppIterator++;
        suppIndexator++;
    }
    Console.WriteLine($"\nДлины сторон:");
    for (int i = 0; i < deltaSidesLength.Length; i++)
    {
        Console.WriteLine($"{deltaSidesLength[i]}");
    }

    // Вычисляем периметр

    // Переменная с самим периметром боже как же зае все это подписывать. А, cамое главное, ЗАЧЕМ Я ЭТО ДЕЛАЮ?
    double perimeter = 0;

    // суммируем все элементы массива deltaSidesLength
    for (int i = 0; i < deltaSidesLength.Length; i++)
    {
        perimeter += deltaSidesLength[i];
    }
    return perimeter;
}

//▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

/* Задача №3150. Длинный обмен значений */

//▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓



Console.ReadKey();
