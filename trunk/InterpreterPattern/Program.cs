﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    /// <summary>
    /// Lena software: evaluate expression in LUT-Enhancement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            IExpressionBase expression = parser.Parse("+ 5 6");
            Console.WriteLine("{0} = {1}", expression, expression.Evaluate());
            Console.ReadKey();
        }
    }
}
