namespace EnovaGit.Core.Utils
{
    public class NumericHelper: INumericHelper
    {
        public decimal ConverIntToDecimal(int value)
        {
            return (decimal)value / 100;
        }
    }
}