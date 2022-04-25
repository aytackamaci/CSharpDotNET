using static System.Console;
using System.Linq;

namespace PrimeFactorsLib;
public class PrimeFactorsClass
{
    public string PrimeFactors(int number) 
    {
        int[] primeNumbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        if (number > 1000 || number < 2) 
        {
            throw new ArgumentException(
                message: "You should enter a number between 2 and 1000."
            );
        }
        // Create a new method here to call repeatedly.
        return FindPrimeFactors(number, primeNumbers);
    }

    public string FindPrimeFactors(int number, int[] primeNumbers)
    {
        int newNumber = number;
        string primeRep = "";
        if (primeNumbers.Contains(newNumber)) {
            return string.Concat(primeRep, newNumber);
        }
        for (int i = 0; i < primeNumbers.Length; i++) {
            while (newNumber % primeNumbers[i] == 0) {
                if (primeNumbers.Contains(newNumber)) {
                    return string.Concat(primeRep, newNumber);
                }
                primeRep = string.Concat(primeRep, primeNumbers[i] + "x");
                newNumber = newNumber / primeNumbers[i];
            }
        }

        return primeRep;
    }


}


// take the number
// create a prime number array from 1-1000 (not sure if it is enough)
// start from first element which is 2 and divide it until it's undivisible
// keep a current number and assign the result of the previous line to the current number
// start filling the prime factor string Ex: 2x2x3x5
// after it is indivisible go to the next element
// until the number is reduced to one of the elements of the array