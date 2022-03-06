using System;

namespace Mindbox
{
    /// <summary>
    /// Результат выполнения метода
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Удачный результат выполнения метода.
        /// </summary>
        public static Result Success => new();

        private Result()
        {
        }

        /// <summary>
        /// Конструктор неудачного результата выполнения метода.
        /// Принимает в конструкторе исключение в виде <see cref="System.Exception"/>.
        /// </summary>
        /// <param name="exception">Исключение в виде <see cref="System.Exception"/></param>
        public Result(Exception exception)
        {
            Exception = exception;
        }
        
        /// <summary>
        /// Исключение при выполнение метода
        /// </summary>
        public Exception Exception { get; }
        
        /// <summary>
        /// Проверяет удачный ли результат выполнения метода
        /// </summary>
        /// <returns>Результат выполнения метода</returns>
        public virtual bool IsSuccess => Exception == null;
    }
}
