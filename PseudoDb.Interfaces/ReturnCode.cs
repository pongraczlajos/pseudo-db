using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoDb.Interfaces
{
    public enum ReturnCode
    {
        Success,
        PrimaryKeyConstraintFailed,
        UniqueConstraintFailed,
        ForeignKeyConstraintFailed
    }
}
