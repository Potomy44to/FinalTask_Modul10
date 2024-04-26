using Modul10;

Logger logger = new Logger();

Calculator calculator = new Calculator(logger);
double firstValue, secondValue;

Console.WriteLine("Ввести первое число для сложения: ");
firstValue = EnterNumber();

Console.WriteLine("Ввести второе число для сложения: ");
secondValue = EnterNumber();

Console.WriteLine("Результат сложения: {0}", calculator.Sum(firstValue, secondValue));

double EnterNumber()
{
    do
    {
        try
        {
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                throw new FormatException();
            }
            return value;
        }
        catch (FormatException e)
        {
            logger.Error("Найдена ошибка");
            Console.WriteLine(e.Message);
        }
    } while (true); 
}