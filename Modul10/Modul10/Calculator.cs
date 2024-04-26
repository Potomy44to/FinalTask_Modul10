namespace Modul10
{
	public class Calculator : ISum
	{
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public double Sum(double firstOperand, double secondOperand)
        {
            Logger.Event("Происходит расчет суммы");
            return firstOperand + secondOperand;
        }
    }
}

