using FluentValidation;
using Sammak.Core.Common.Util;

namespace Sammak.Core.Common.Validation.Impl
{
    /// <summary>
    /// ValidationFactory class
    /// </summary>
    /// <seealso cref="IValidationFactory" />
    public class ValidationFactory : IValidationFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationFactory"/> class.
        /// </summary>
        public ValidationFactory()
        {
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T">The type to fetch a validator for.</typeparam>
        /// <returns></returns>
        public IValidator<T> GetValidatorInstance<T>()
        {
            return DependencyResolver.Container.GetInstance<IValidator<T>>();
        }
    }
}
