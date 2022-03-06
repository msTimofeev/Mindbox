using System;
using System.Linq;
using System.Reflection;

namespace Mindbox
{
    public static  class FigureFactory
    {
        public static IFigure CreateFigure(string figureTypeName, params double[] args)
        {
            if (string.IsNullOrWhiteSpace(figureTypeName))
            {
                throw new ArgumentException("Тип фигуры не задан");
            }

            var type = Type.GetType(figureTypeName);

            if (type?.GetInterface(nameof(IFigure)) == null)
            {
                throw new InvalidCastException("Невозможно создать указанный тип фигуры");
            }

            return (IFigure)Activator.CreateInstance(type, args);
        }

        public static IFigure CreateFigure<T>(params double[] args) where T : IFigure
        {
            var validatorType = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .FirstOrDefault(p => p.GetTypeInfo().IsSubclassOf(typeof(Validator<T>)));

            if (validatorType != null)
            {
                var validator = (Validator<T>)Activator.CreateInstance(validatorType);

                if (validator != null)
                {
                    var result = validator.Validate(args);

                    if (result.IsSuccess)
                    {
                        return (IFigure)Activator.CreateInstance(typeof(T), BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { args }, null);
                    }

                    throw result.Exception;
                }
            }

            throw new InvalidCastException("Невозможно создать указанный тип фигуры");

        }
    }
}