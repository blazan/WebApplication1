using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DAL;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TestClassRepository : TestClassInterface
    {
        private DatabaseContext context;
        public TestClassRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Models.TestClass GetTestClassById(Guid id)
        {
            return context.Test.Find(id);
        }

        public IEnumerable<Models.TestClass> GetTestClasses()
        {
            return context.Test.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}