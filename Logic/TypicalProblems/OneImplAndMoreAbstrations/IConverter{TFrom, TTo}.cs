using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.TypicalProblems.OneImplAndMoreAbstrations;

public interface IConverter<TFrom, TTo>
{
    TTo Convert(TFrom from);
}
