using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern
{
    public class AddExpression: IExpressionBase
    {
        IExpressionBase m_expr1;
        IExpressionBase m_expr2;
        public AddExpression(IExpressionBase expr1, IExpressionBase expr2)
        {
            m_expr1 = expr1;
            m_expr2 = expr2;
        }

        public double Evaluate()
        {
            double value1 = m_expr1.Evaluate();
            double value2 = m_expr2.Evaluate();
            return value1 + value2;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}", m_expr1, m_expr2);
        }
    }
}
