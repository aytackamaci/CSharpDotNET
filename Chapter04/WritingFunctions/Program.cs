using static System.Console;

TimesTable(number: 6);

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for (int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}


static decimal CalculateTax(
    decimal amount, string twoLetterRegionCode)
{
  decimal rate = 0.0M;
  switch (twoLetterRegionCode)
  {
    case "CH": // Switzerland 
        rate = 0.08M;
        break;
    case "DK": // Denmark 
    case "NO": // Norway
        rate = 0.25M;
        break;
    case "GB": // United Kingdom 
    case "FR": // France
        rate = 0.2M;
        break;
    case "HU": // Hungary
        rate = 0.27M;
        break;
    case "OR": // Oregon 
    case "AK": // Alaska 
    case "MT": // Montana
        rate = 0.0M;
        break;
    case "ND": // North Dakota 
    case "WI": // Wisconsin   
    case "ME": // Maine
    case "VA": // Virginia 
        rate = 0.05M;
        break;
    case "CA": // California rate = 0.0825M;
        break;
    default: // most US states 
        rate = 0.06M;
        break;
}
    return amount * rate;
}

/// <summary>
/// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on. </returns>
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11: // special cases for 11th to 13th 
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        return $"{number}{suffix}";
    }
}