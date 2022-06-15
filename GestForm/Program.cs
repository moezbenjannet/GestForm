using System.Collections.Generic;

namespace GestForm
{
    public class Program
    {
        public static void Main()
        {
            IGestFormHandler gestForm = new GestFormHandler();

            // Create and Fill a random list
            List<int> integers = GestFormHelper.CreateRandomIntegerList();

            // Proccess the list
            gestForm.GestFormDisplay(integers);
        }
    }
}
