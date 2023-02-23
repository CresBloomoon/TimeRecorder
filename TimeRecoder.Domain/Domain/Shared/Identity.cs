using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRecoder.Domain.Domain.Shared
{
    /// <summary>
    /// エンティティの同一性を表現するための値オブジェクトです
    /// </summary>
    public class Identity<T> : ValueObject<Identity<T>>, IComparable<Identity<T>>
    {
        private const int TemporaryIdValue = -1;
        public bool IsTemporary => Value == TemporaryIdValue;

        public bool IsEmpty => Value == 0;

        public int Value { get; }

        internal Guid TempValue { get; private set; }

        public Identity(int id)
        {
            Value = id;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            if (IsTemporary)
            {
                yield return TempValue;
            }
            else
            {
                yield return Value;
            }
        }

        public int CompareTo(Identity<T> other)
        {
            if (IsTemporary)
            {
                if (other.IsTemporary)
                {
                    return TempValue.CompareTo(other.TempValue);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (other.IsTemporary)
                {
                    return 1;
                }
                else
                {
                    return Value.CompareTo(other.Value);
                }
            }
        }
    }
}
