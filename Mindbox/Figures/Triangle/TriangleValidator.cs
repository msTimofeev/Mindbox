using System;
using System.Linq;

namespace Mindbox
{
    public class TriangleValidator : Validator<Triangle>
    {
        public override Result Validate(double[] args)
        {
            if (!args.Any())
            {
                return new Result(new ArgumentException("Стороны не указаны"));
            }

            if (args.Length != 3)
            {
                return new Result(new ArgumentException($"Некорректные входные данные: {string.Join(", ", args)}"));
            }

            var sideA = args[0];
            var sideB = args[1];
            var sideC = args[2];

            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                return new Result(new ArgumentException("Одна из сторон отрицательная"));
            }

            return Result.Success;
        }
    }
}