using System;
using System.Collections.Generic;
using System.Linq;

namespace GestForm
{
    public class GestFormHandler: IGestFormHandler
    {
        /// <inheritdoc />
        public void GestFormDisplay(List<int> integers)
        {
            if (integers != null && integers.Any())
            {
                foreach (int integer in integers)
                {
                    bool isDivisibleGeste = integer % Constants.DivisibleGesteValue == 0;
                    bool isDivisibleForme = integer % Constants.DivisibleFormeValue == 0;

                    if (isDivisibleForme && isDivisibleGeste)
                    {
                        Console.WriteLine(Constants.Gestform);
                    }
                    else if (isDivisibleGeste)
                    {
                        Console.WriteLine(Constants.Geste);
                    }
                    else if (isDivisibleForme)
                    {
                        Console.WriteLine(Constants.Forme);
                    }
                    else
                    {
                        Console.WriteLine(integer);
                    }
                }
            }
        }
    }
}
