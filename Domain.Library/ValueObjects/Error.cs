using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.ValueObjects
{
    public class Error : ValueObject
    {
        private const string Seperator = "||";
        public string Code { get; set; }
        public string Message { get; set; }
        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }
        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            yield return Code;
        }
        public string Serialize() => $"{Code} {Seperator} {Message}";

        public static Error Deserialize(string serialize)
        {
            string[] data = serialize.Split(new [] { Seperator },StringSplitOptions.RemoveEmptyEntries);
            if (data.Length < 2)
            {
                throw new Exception($"Invalid Error Serialization {serialize}");
            }

            return new Error(data[0], data[1]);
        }
    }
    public static class Errors
    {
        public static class General
        {
            public static Error NotFound([MaybeNull] object? id = null)
            {
                string field = id == null ? "": $"For Id {id}";
                return new("1",$"Record Not Fount {field}");
            }

        }
        public static class Student
        {

        }
    }
}
