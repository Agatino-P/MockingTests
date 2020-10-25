using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestableService
{
    public class Testable : ITestable
    {
        public string ToLetters(int i)
        {
            switch (i)
            {
                case 1:
                    return "uno";
                case 2:
                    return "due";
                default:
                    return "altro";
            }

        }
    }
}
