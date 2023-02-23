using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeRecoder.Domain.Domain.Shared;

namespace TimeRecoder.Domain.Domain.Terms
{
    public sealed class YmdString : ValueObject<YmdString>, IComparable<YmdString>
    {
        public static YmdString Empty => new("");

        public static YmdString NoPlan => new("99991231");

    }
}
