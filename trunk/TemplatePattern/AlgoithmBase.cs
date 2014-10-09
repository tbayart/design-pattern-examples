using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    public abstract class AlgoithmBase
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
        }

        public abstract void Step1();
        public abstract void Step2();
    }
}
