using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralGenerator.Contract
{
    interface IRomanNumeralGenerator
    {
        string Generate(int number);
    }
}
