using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    public class DoubleExpression: IExpressionBase
    {
        double m_value;

        public DoubleExpression(double value)
        {
            m_value = value;
        }

        public double Evaluate()
        {
            return m_value;
        }

        public override string ToString()
        {
            return m_value.ToString();
        }
    }
}
