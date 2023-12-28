public struct DecimalNumber
{
    public double number;
    public long number2;
   /* public DecimalNumber(long number)
    {
        this.number2 = number2;
        this.number = number;
    }*/
    public void ConvertTo2()
    {
        List<double> result = new List<double>();
        for(; number >= 1; )
        {
            double remainderOfDivision = number % 2;
            number -= number / 2;
            result.Add(remainderOfDivision);
        }
        result.Reverse();
        foreach(int temp in result)
        {
            Console.Write(temp);
        }
    }

    public void ConvertTo8()
    {
        List <double> result = new List<double>();
        for(;number >= 7;)
        {
            double remainderOfDivision = number % 8;
            int resultDivision = (int)number / 8;
            number = resultDivision;
            result.Add(remainderOfDivision);
        }
        result.Reverse();
        foreach (int temp in result)
        {
            Console.Write(temp);
        }
    }
    public void ConvertTo16()
    {
        List<char> result = new List<char>();
       for(; number2 > 0; number2 /= 16)
        {
            long remainderOfDivision = (long)number2 % 16;
            char hexDigit = (char)(remainderOfDivision < 10 ? remainderOfDivision + '0' : remainderOfDivision - 10 + 'A');
            result.Insert(0, hexDigit);
        }

        foreach (char temp in result)
        { Console.Write(temp); }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number for convert:");
        double number = Convert.ToDouble(Console.ReadLine());
        DecimalNumber decimalNumber = new DecimalNumber();
        decimalNumber.number = number;
        Console.Write($"{number} in binary system: ");
        decimalNumber.ConvertTo2();
        Console.WriteLine();
        decimalNumber.number =(double) number;
        Console.Write($"{number} in octal system: ");
        decimalNumber.ConvertTo8();
        Console.WriteLine();
        decimalNumber.number2 = (long)number;
        Console.Write($"{number} in hexadecimal system: ");
        decimalNumber.ConvertTo16();
    }
}