using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TestClass
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }
        [DisplayName("Name")]
        public String Name { get; set; }
        [DisplayName("IsTest")]
        public bool IsTest { get; set; }
    }
}