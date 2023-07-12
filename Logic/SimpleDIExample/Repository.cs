using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimpleDIExample;
public sealed class Repository : IRepository
{
    public void SomeWork()
    {
        Console.WriteLine("Default repo work");
    }
}
