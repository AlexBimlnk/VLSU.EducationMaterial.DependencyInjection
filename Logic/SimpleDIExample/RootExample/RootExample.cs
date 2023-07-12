using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SimpleDIExample.RootExample;
internal class RootExample
{
    public static void Main()
    {
        var controller = new Controller(
            new Service(
                new DIPHandler(
                    new CustomRepository()),
                new ResultSender()));

        var result = controller.Index();
        Console.WriteLine(result);
    }
}
