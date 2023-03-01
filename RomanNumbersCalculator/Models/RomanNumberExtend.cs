using Avalonia.Controls;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberExtend : RomanNumber
    {
        public RomanNumberExtend(string n) : base(n) { }
        public RomanNumberExtend(ushort n) : base(n) { }
        public static RomanNumberExtend operator +(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2) => new RomanNumberExtend((ushort)(romanNumber1.ToUInt16() + romanNumber2.ToUInt16()));
        public static RomanNumberExtend operator -(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2) => new RomanNumberExtend((ushort)(romanNumber1.ToUInt16() - romanNumber2.ToUInt16()));
        public static RomanNumberExtend operator *(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2) => new RomanNumberExtend((ushort)(romanNumber1.ToUInt16() * romanNumber2.ToUInt16()));
        public static RomanNumberExtend operator /(RomanNumberExtend romanNumber1, RomanNumberExtend romanNumber2) => new RomanNumberExtend((ushort)(romanNumber1.ToUInt16() / romanNumber2.ToUInt16()));
    }
}
