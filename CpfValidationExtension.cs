using System.Collections.Generic;
using System;
using System.Linq;

namespace CpfExtension
{
    public static class CpfValidation
    {
        public static bool ValidateCpf(string cpf)
        {            
            List<int> cpfDigits = new List<int>();
            cpf.ToList().ForEach(digit => cpfDigits.Add(Convert.ToInt32(digit.ToString())));
            
            return ((GetFirstDigit(cpfDigits) == cpfDigits[9] && GetSecondDigit(cpfDigits) == cpfDigits[10]) ? true : false);                        
        }

        private static int GetFirstDigit(List<int> cpfDigits)
        {            
            int decreasingSequence = 10;
            int firstDigit = 0;

            for(int digit = 0; digit < cpfDigits.Count() - 2; digit++)
            {
                firstDigit = firstDigit + (cpfDigits[digit] * decreasingSequence);
                decreasingSequence--;
            }
            
            return (firstDigit * 10) % 11;;
        }

        private static int GetSecondDigit(List<int> cpfDigits)
        {            
            int decreasingSequence = 11;
            int secondDigit = 0;

            for(int digit = 0; digit < cpfDigits.Count() - 1; digit++)
            {
                secondDigit = secondDigit + (cpfDigits[digit] * decreasingSequence);
                decreasingSequence--;
            }
            
            return (secondDigit * 10) % 11;;
        }
    }

}
