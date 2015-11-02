using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interface
{
    interface TestClassInterface : IDisposable
    {
        TestClass GetTestClassById(Guid id);
        IEnumerable<TestClass> GetTestClasses();
    }
}
