using System;
using System.Linq;

namespace Mindbox
{
    public class CircleValidator : Validator<Circle>
    {
        public override Result Validate(double[] args)
        {
            if (!args.Any())
            {
                return new Result(new ArgumentException("Радиус не указан"));
            }

            if (args.Length > 1)
            {
                return new Result(new ArgumentException($"Некорректные входные данные: {string.Join(", ", args)}"));
            }

            var radius = args.First();

            if (radius < 0)
            {
                return new Result(new ArgumentException("Радиус отрицательный"));
            }

            return Result.Success;
        }
    }
}
