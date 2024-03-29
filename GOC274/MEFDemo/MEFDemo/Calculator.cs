﻿using Common;
using System.ComponentModel.Composition;

namespace MEFDemo
{
    [Export(typeof(ICalculator))]
    public class MySimpleCalculator : ICalculator
    {
        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationData>> operations;
        public string Calculate(string input)
        {
            int left;
            int right;
            char operation;
            // Finds the operator.
            int fn = FindFirstNonDigit(input);
            if (fn < 0) return "Could not parse command.";

            try
            {
                // Separate out the operands.
                left = int.Parse(input.Substring(0, fn));
                right = int.Parse(input.Substring(fn + 1));
            }
            catch
            {
                return "Could not parse command.";
            }

            operation = input[fn];

            foreach (Lazy<IOperation, IOperationData> i in operations)
            {
                if (i.Metadata.Symbol.Equals(operation))
                {
                    return i.Value.Operate(left, right).ToString();
                }
            }
            return "Operation Not Found!";
        }

        private int FindFirstNonDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i])) return i;
            }
            return -1;
        }
    }
}
