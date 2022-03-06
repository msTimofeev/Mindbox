using Mindbox;

namespace Mindbox
{
    public abstract class Validator<T>
    {
        /// <summary>
        /// Проверка передаваемых аргументов
        /// </summary>
        /// <param name="args">Аргументы</param>
        /// <returns></returns>
        public abstract Result Validate(double[] args);
    }
}
