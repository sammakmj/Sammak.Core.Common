using FluentValidation;

namespace Sammak.Core.Common.Validation
{
    /// <summary>
    /// IValidationFactory interface
    /// </summary>
    public interface IValidationFactory
    {
        /// <typeparam name="T">
        /// The type to fetch a validator for.
        /// </typeparam>
        IValidator<T> GetValidatorInstance<T>();
    }
}
