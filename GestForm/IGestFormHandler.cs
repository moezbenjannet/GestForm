using System.Collections.Generic;

namespace GestForm
{
    public interface IGestFormHandler
    {
        /// <summary>
        /// display foreach element :
        ///     Geste if the integer is divisible by 3,
        ///     Forme if divisible by 5,
        ///     Gestform if divisible by 5 and 3,
        ///     otherwise it display the element value.
        /// </summary>
        /// <param name="integers">list of integers</param>
        public void GestFormDisplay(List<int> integers);
    }
}
