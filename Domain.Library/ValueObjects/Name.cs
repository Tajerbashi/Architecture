using CSharpFunctionalExtensions;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Library.ValueObjects
{
    public class Name : ValueObject
    {
        public string Value { get; }
        private Name(string value) => Value = value;

        public static Result<Name> Create([MaybeNull] string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result.Failure<Name>($"{nameof(Name)} نباید خالی باشد");
            }

            string name = value.Trim();
            if (name.Length <= 5)
            {
                return Result.Failure<Name>($"{nameof(Name)} باید بیشتر از 5 کارکتر باشد");
            }
            else if (name.Length > 30)
            {
                return Result.Failure<Name>($"{nameof(Name)} باید کمتر از 30 کارکتر باشد");
            }

            return Result.Success(new Name(name));
        }
        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
